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
        public static Form MainForm { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tạo form đăng ký/đăng nhập trước
            FormDangKy formDK = new FormDangKy();
            MainForm = new FormTrangChu();

            // Hiển thị formDK dưới dạng dialog để chặn luồng
            formDK.ShowDialog();

            // Sau khi formDK đóng, kiểm tra login
            if (Control.ControlUsers.IsLogin)
            {
                Application.Run(MainForm); // Chạy formTT nếu login thành công
            }
            else
            {
                Application.Exit(); // Thoát nếu không login
            }
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
