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
using QLHOCTRUCTUYEN.Control;

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
            string imagePath = @"Images\" + Users.AnhDaiDien;
            string tmp = Users.AnhDaiDien;
            txt_HoTen.Text = Users.TenUser;
            txt_email.Text = Users.Email;
            try
            {
                pic_AnhDaiDien.Image = Image.FromFile(imagePath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
