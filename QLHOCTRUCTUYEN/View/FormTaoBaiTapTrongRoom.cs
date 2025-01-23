using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHOCTRUCTUYEN.View
{
    public partial class FormTaoBaiTapTrongRoom : Form
    {
        public FormTaoBaiTapTrongRoom()
        {
            InitializeComponent();
        }

        private void FormTaoBaiTapTrongRoom_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void lbl_BT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bai Tap");
            FormCTTaoBaiTap form = new FormCTTaoBaiTap();
            form.ShowDialog();
        }

        private void lbl_KT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kiem Tra");
            FormCTTaoBaiTap form = new FormCTTaoBaiTap();
            form.ShowDialog();
        }

        private void lbl_CauHoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cau Hoi");
            FormCTTaoBaiTap form = new FormCTTaoBaiTap();
            form.ShowDialog();
        }

        private void lbl_TaiLieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tai Lieu");
            FormCTTaoBaiTap form = new FormCTTaoBaiTap();
            form.ShowDialog();
        }
    }
}
