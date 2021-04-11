using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using FaceBookApp.Logic;
using FacebookWrapper.ObjectModel;

namespace FaceBookApp.UI
{
    public partial class FormCheckIns : Form
    {
        private const string k_GoogleMapsUrl = "https://www.google.com/maps/search/";

        private FacebookObjectFilter<Checkin> m_FilterdCheckinList;

        private IStartegySorter<Checkin> StrategySorterCheckins { get; set; }

        private FacadeFbData CheckinsData { get; }

        public FormCheckIns(FacadeFbData i_CheckinsData)
        {
            InitializeComponent();
            CheckinsData = i_CheckinsData;
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            new Thread(() =>
            {
                m_FilterdCheckinList = CheckinsData.GetCheckins();
                fetchCheckins(eNumFilter.ThisMonth);
            }).Start();
        }

        private void fetchCheckins(eNumFilter i_Filter)
        {
            m_FilterdCheckinList.InitFilterList(i_Filter);
            if (m_FilterdCheckinList.ObjectList.Count == 0)
            {
                setComboBoxEnabled(comboBoxSort, false);
                comboBoxCheckinFilter.Invoke(new Action(() => MessageBox.Show("No Checkins to retrieve in " + comboBoxCheckinFilter.SelectedItem.ToString() + " :(")));
            }
            else
            {
                insertToListBox(m_FilterdCheckinList.ObjectList);
            }

            setComboBoxEnabled(comboBoxCheckinFilter, true);
        }

        private void insertToListBox(IEnumerable<Checkin> i_Collection)
        {
            foreach (Checkin checkin in i_Collection)
            {
                listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add(checkin)));
            }

            setComboBoxEnabled(comboBoxSort, true);
        }

        private void comboBoxCheckinFilter_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            setComboBoxEnabled(comboBoxCheckinFilter, false);
            eNumFilter filter = (eNumFilter)comboBoxCheckinFilter.SelectedIndex;
            listBoxCheckins.Items.Clear();
            pictureBoxCheckIn.Image = null; // Reset Image
            webBrowserGoogleMaps.Navigate("about:blank"); // reset web browser url
            new Thread(() => fetchCheckins(filter)).Start();
        }

        private void comboBoxSort_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            setComboBoxEnabled(comboBoxSort, false);
            listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Clear()));
            pictureBoxCheckIn.Image = null; // Reset Image
            webBrowserGoogleMaps.Navigate("about:blank"); // reset web browser url

            switch (comboBoxSort.SelectedItem.ToString())
            {
                case "Date":
                    StrategySorterCheckins = new SortByDate<Checkin>();
                    break;
                case "Name":
                    StrategySorterCheckins = new SortByName<Checkin>();
                    break;
                case "Likes":
                    MessageBox.Show(@"Feature isnt available due to facebook limits");
                    StrategySorterCheckins = null; // because feature isnt supported by the dll (but it will work if it does)
                    // StrategySorterCheckins = new SortByLikes<Checkin>();
                    break;
                default:
                    MessageBox.Show(@"Something went wrong, try again");
                    StrategySorterCheckins = null;
                    break;
            }

            if(StrategySorterCheckins != null)
            {
                insertToListBox(CheckinsData.SortStrategy(
                    m_FilterdCheckinList.ObjectList,
                    StrategySorterCheckins));
            }
        }

        private void listBoxCheckins_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            if (listBoxCheckins.SelectedItems.Count == 1)
            {
                Checkin checkin = listBoxCheckins.SelectedItem as Checkin;
                pictureBoxCheckIn.LoadAsync(checkin.PictureURL);
                string url = string.Format("{0}{1}", k_GoogleMapsUrl, checkin.Place.Name);
                webBrowserGoogleMaps.ScriptErrorsSuppressed = true;
                webBrowserGoogleMaps.Navigate(url);
            }
        }

        private void listBoxCheckins_Format(object i_Sender, ListControlConvertEventArgs i_E)
        { // item name format 
            DateTime? createdTime = ((Checkin)i_E.ListItem).CreatedTime;
            string placeName = ((Checkin)i_E.ListItem).Place.Name;
            string date = "no-date";

            if (string.IsNullOrEmpty(placeName))
            {
                placeName = "[invalid Place Name]";
            }

            if (createdTime != null)
            {
                date = createdTime.Value.ToString("dd/MM/yyyy");
            }

            i_E.Value = date + " - " + placeName;
        }

        private void setComboBoxEnabled(ComboBox i_Combo, bool i_IsEnabled)
        {
            i_Combo.Invoke(new Action(() => i_Combo.Enabled = i_IsEnabled));
        }
    }
}
