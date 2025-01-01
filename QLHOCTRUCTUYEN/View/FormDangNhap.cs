using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHOCTRUCTUYEN
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy formDangKy = new FormDangKy();
            formDangKy.Show();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Control.ControlUsers.ControlLogin(txtEmail.Text, txtPass.Text);
        }

        public void DangNhapThanhcong(bool success)
        {
            if (success)
            {
                this.Hide();
                FormBTTrenLop formBTTrenLop = new FormBTTrenLop();
                formBTTrenLop.Show();
            }
        }
    }
}
