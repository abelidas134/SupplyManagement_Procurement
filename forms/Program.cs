using forms;
using System.Windows.Forms;

namespace Forms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new procurementPanel());
        }
    }
}