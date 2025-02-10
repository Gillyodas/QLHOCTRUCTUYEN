using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using QLHOCTRUCTUYEN.Model;
using System.Runtime.CompilerServices;
using QLHOCTRUCTUYEN.View;

namespace QLHOCTRUCTUYEN
{
    public partial class FormDangKy : Form
    {
        private string connStr = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        private bool isValidHoTen = false, isValidEmail = false, isValidPass = false, isValidReEnterPass = false;
        private bool isValidEmailDN = false, isValidPassDN = false;
        public FormDangKy()
        {
            InitializeComponent();
            UpdateBtnDangKyState();
            UpdateBtnDangNhapState();
            NhapSanEmailPass();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void NhapSanEmailPass()
        {
            txtEmailDN.Text = "admin@gmail.com";
            txtPassDN.Text = "1";
        }
        private void UpdateBtnDangKyState()
        {
            btnDangKy.Enabled = isValidHoTen && isValidEmail && isValidPass && isValidReEnterPass;
        }
        private void UpdateBtnDangNhapState()
        {
            btnDangNhapDN.Enabled = isValidEmailDN && isValidPassDN;
        }
        public static bool FuncIsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]{2,6}$";
            return Regex.IsMatch(email, pattern);
        }
        private void txtHoTenIsValid(object sender, EventArgs e)
        {
            isValidHoTen = !string.IsNullOrWhiteSpace(txtHoTen.Text);
            lblBatBuocHoTen.Text = isValidHoTen ? "" : "Nhập họ tên";
            UpdateBtnDangKyState();
        }
        private void txtEmailIsValid(object sender, EventArgs e)
        {
            isValidEmail = !string.IsNullOrWhiteSpace(txtEmail.Text) && FuncIsValidEmail(txtEmail.Text);
            lblUnvalidEmail.Text = isValidEmail ? "" : "example@gmail.com";
            UpdateBtnDangKyState();
        }
        private void txtPassIsValid(object sender, EventArgs e)
        {
            isValidPass = !string.IsNullOrWhiteSpace(txtPass.Text);
            lblUnvalidPass.Text = isValidPass ? "" : "Nhập mật khẩu";
            UpdateBtnDangKyState();
        }
        private void txtReEnterPassIsValid(object sender, EventArgs e)
        {
            isValidReEnterPass = txtReEnterPass.Text == txtPass.Text && !string.IsNullOrWhiteSpace(txtReEnterPass.Text);
            lblUnvalidReEnterPass.Text = isValidReEnterPass ? "" : "Nhập lại phải giống mật khẩu";
            UpdateBtnDangKyState();
        }
        private void txtEmailDN_TextChanged(object sender, EventArgs e)
        {
            isValidEmailDN = !string.IsNullOrWhiteSpace(txtEmailDN.Text) && FuncIsValidEmail(txtEmailDN.Text);
            lblUnvalidEmailDN.Text = isValidEmailDN ? "" : "example@gmail.com";
            UpdateBtnDangNhapState();
        }
        private void txtPassDN_TextChanged(object sender, EventArgs e)
        {
            isValidPassDN = !string.IsNullOrWhiteSpace(txtPassDN.Text);
            lblUnvalidPassDN.Text = isValidPassDN ? "" : "Nhập mật khẩu";
            UpdateBtnDangNhapState();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKyThanhCong(ManageUsers.CreateUser(txtHoTen.Text, txtEmail.Text, txtPass.Text));
        }
        private void btnDangNhapDN_Click(object sender, EventArgs e)
        {
            if (UserLoginHandler.ValidLogin(txtEmailDN.Text, txtPassDN.Text))
            {
                Global.MainForm.Hide();
                Global.MainForm = new FormTrangChu();
                Global.MainForm.Show();
            }
            else MessageBox.Show("Dang nhap that bai");
        }
        public void DangKyThanhCong(bool success)
        {
            if (success)
            {
                MessageBox.Show("Thanh cong");
            }
            else MessageBox.Show("That bai");
        }
        private void btnChuyenSangFormDK_Click(object sender, EventArgs e)
        {
            panDangNhap.Visible = false;
            panDangKy.Visible = true;
        }
        private void btnChuyenSangFormDN_Click(object sender, EventArgs e)
        {
            panDangKy.Visible= false;
            panDangNhap.Visible = true;
        }
        private void lblQuenMK_Click(object sender, EventArgs e)
        {

        }
    }
}
