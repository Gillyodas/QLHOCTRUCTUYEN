using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.Model;
using System.Runtime.CompilerServices;

namespace QLHOCTRUCTUYEN.View
{
    public partial class FormCTTaiKhoan : Form
    {
        public FormCTTaiKhoan()
        {
            InitializeComponent();
            SetThongTin();
        }
        public void SetThongTin()
        {
            string imagePath = @"Images\" + UserLoginHandler.CurUser.ANHDAIDIEN;
            txt_HoTen.Text = UserLoginHandler.CurUser.TENUSER;
            txt_email.Text = UserLoginHandler.CurUser.EMAIL;
            try
            {
                pic_AnhDaiDien.Image = Image.FromFile(imagePath);
            }
            catch(Exception ex)
            {
            }
        }
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Global.MainForm.Hide();
            Global.MainForm = new FormDangKy();
            Global.MainForm.Show();
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            Program.OpenOrActivateForm(doiMatKhau);
        }
        private void btn_DoiThongTin_Click(object sender, EventArgs e)
        {
            bool gioiTinh = false;

            if (rdB_Nam.Checked)
                gioiTinh = true;
            else if (rdB_Nam.Checked)
                gioiTinh = false;
            if (!ManageUsers.UpdateUser(txt_HoTen.Text, txt_email.Text, gioiTinh))
                MessageBox.Show("fail");
            FormTrangChu form = Application.OpenForms["FormTrangChu"] as FormTrangChu;
            form.LoadHienThiThongTinNguoiDung();
            SetThongTin();
        }

        private void btn_XoaTK_Click(object sender, EventArgs e)
        {
            ManageUsers.XoaNguoiDung(UserLoginHandler.CurUser.ID_USER);
            btn_DangXuat_Click(null, EventArgs.Empty);
        }
    }
}
