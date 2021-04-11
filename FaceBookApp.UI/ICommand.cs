using System.Drawing;

namespace FaceBookApp.UI
{
    public interface ICommand
    {
        Point Location { get; set; }

        Size Size { get; set; }

        void Execute();
    }
}
