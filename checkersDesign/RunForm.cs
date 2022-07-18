using System.Windows.Forms;

namespace checkersDesign
{
    internal class RunForm
    {
        internal static void Run()
        {
            Application.EnableVisualStyles();
            new FormLogin().ShowDialog();
        }
    }
}
