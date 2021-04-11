using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FaceBookApp.UI
{
    public class MenuItemPanel : Panel
    {
        private Point StartLocation { get; set; }

        public int PaddingBetweenItems { get; set; }

        private readonly List<ICommand> r_Items;

        public MenuItemPanel()
        {
            this.Padding = new Padding(0, 5, 0, 0);
            this.PaddingBetweenItems = 5;
            this.StartLocation = new Point(this.Location.X + (int)(this.Size.Width * 0.1 / 2), this.Location.Y + this.Padding.Top);
            this.r_Items = new List<ICommand>();
        }

        private void itemsRelocation()
        {
            Point currentLocation = new Point(StartLocation.X, StartLocation.Y);
            foreach (ICommand item in this.r_Items)
            {
                item.Size = new Size((int)(this.Size.Width * 0.9), item.Size.Height);
                item.Location = new Point(currentLocation.X, currentLocation.Y);
                currentLocation.Y += this.PaddingBetweenItems + item.Size.Height;
            }
        }

        public void AddItem(ICommand i_Item)
        {
            Control item = i_Item as Control;
            if(item != null)
            {
                this.r_Items.Add(i_Item);
                this.itemsRelocation();
                this.Controls.Add(item);
            }
        }

        public void AddItems(List<ICommand> i_Items)
        {
            foreach (ICommand item in i_Items)
            {
                this.AddItem(item);
            }
        }

        public void RemoveItem(ICommand i_Item)
        {
            if(r_Items.Contains(i_Item))
            {
                this.r_Items.Remove(i_Item);
                this.Controls.Remove(i_Item as Control); // if its in the list its will be Control
                this.itemsRelocation();
            }
        }
    }
}