using System;
using System.Drawing;
using System.Windows.Forms;

namespace FaceBookApp.UI
{
    public class CommandButton : Button, ICommand
    {
        private EventHandler ExecuteEvent { get; set; }

        public CommandButton()
        {
            initMenuItemFeatures();
            ExecuteEvent = null;
        }

        public CommandButton(string i_Text, Image i_Image, string i_ButtonName)
        {
            initMenuItemFeatures();
            Image = new Bitmap(i_Image, new Size(16, 16));
            Name = i_ButtonName;
            Text = i_Text;
        }

        private void initMenuItemFeatures()
        {
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Hand;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 223, 226);
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 246, 247);
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = SystemColors.ActiveCaptionText;
            this.Size = new Size(187, 41);
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.UseVisualStyleBackColor = false;
        }

        public CommandButton SetEvent(EventHandler i_EventHandler)
        {
            this.ExecuteEvent = i_EventHandler;
            return this;
        }

        public void Execute()
        {
            ExecuteEvent?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnClick(EventArgs i_E)
        {
            Execute();
        }
    }
}