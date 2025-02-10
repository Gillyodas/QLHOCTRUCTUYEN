using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.Model;
using QLHOCTRUCTUYEN.View;

namespace QLHOCTRUCTUYEN
{
    internal static class Program
    {
        public static Form MainForm { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// ✅ Bật hỗ trợ Unicode cho WinForms
            //System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Global.MainForm = new FormDangKy();
            Application.Run(Global.MainForm);
        }

        public static void OpenOrActivateForm(Form formInstance)
        {
            string formName = formInstance.Name;
            Form existingForm = Application.OpenForms[formName];

            if (existingForm == null || existingForm.IsDisposed)
            {
                formInstance.Show();
            }
            else
            {
                existingForm.Activate();
            }
        }
    }
}
