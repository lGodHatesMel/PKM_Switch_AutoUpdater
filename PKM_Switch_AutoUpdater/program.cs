using System;
using System.Windows.Forms;

namespace PKM_Switch_AutoUpdater
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new AutoUpdater());
        }
    }
}