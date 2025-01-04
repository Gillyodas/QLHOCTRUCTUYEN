using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.View;

namespace QLHOCTRUCTUYEN
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormDangKy formDK = new FormDangKy();
            if (formDK.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormBTTrenLop());
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
