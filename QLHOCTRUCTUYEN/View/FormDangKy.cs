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

namespace QLHOCTRUCTUYEN
{
    public partial class FormDangKy : Form
    {
        private string connStr = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        private bool isValidHoTen = false, isValidEmail = false, isValidPass = false, isValidReEnterPass = false;
        private bool isValidEmailDN = false, isValidPassDN = false;
        //public event SentDataSighUpUser sentdata;
        //private ControlUsers ControlUsers;
        public FormDangKy()
        {
            InitializeComponent();
            //ControlUsers = new ControlUsers(this);
            UpdateBtnDangKyState();
            UpdateBtnDangNhapState();
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
            Control.ControlUsers.ControlCreateUser(txtHoTen.Text, txtEmail.Text, txtPass.Text);
            //if (sentdata != null)
            //{
            //    DataSentSighUp args = new DataSentSighUp(txtHoTen.Text, txtEmail.Text, txtPass.Text);
            //    sentdata(this, args);
            //    btnDangKy.Enabled = false;
            //    btnDangKy.Visible = true;
            //}
            //else MessageBox.Show("Loi");

        }
        private void btnDangNhapDN_Click(object sender, EventArgs e)
        {
            Control.ControlUsers.ControlLogin(txtEmailDN.Text, txtPassDN.Text);
        }
        public void DangKyThanhCong(bool success)
        {
            if (success)
            {
                MessageBox.Show("Thanh cong");
            }
            else MessageBox.Show("That bai");
        }
        public void DangNhapThanhcong(bool success)
        {
            if (success)
            {

                FormBTTrenLop formBTTrenLop = new FormBTTrenLop();
                formBTTrenLop.Show();

            }
            else MessageBox.Show("Dang nhap that bai");
            this.Hide(); // Đóng Form 2 từ Form 3.
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

    public class DataSentSighUp : EventArgs
    {
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }

        public DataSentSighUp(string hoten, string email, string pass)
        {
            HoTen = hoten;
            Email = email;
            Pass = pass;
        }
    }
    public delegate void SentDataSighUpUser(object sender, DataSentSighUp e);
}
