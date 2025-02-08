using QLHOCTRUCTUYEN.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; //thư viện cho hàm mã hóa

namespace QLHOCTRUCTUYEN.View
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string MatKhauCu = txt_Matkhau.Text.Trim();
            string MatKhauMoi = txt_Matkhaumoi.Text.Trim();
            string XacNhanMk = txt_XacnhanMK.Text.Trim();

            if (string.IsNullOrEmpty(MatKhauCu) || string.IsNullOrEmpty(MatKhauMoi) || string.IsNullOrEmpty(XacNhanMk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MatKhauMoi != XacNhanMk)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ManageUsers.DoiMK(MatKhauCu, XacNhanMk))
            {
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại");
            }
        }
    }
}
