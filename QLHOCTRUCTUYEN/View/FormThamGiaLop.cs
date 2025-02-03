using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.Control;

namespace QLHOCTRUCTUYEN.View
{
    public partial class FormThamGiaLop : Form
    {
        public FormThamGiaLop()
        {
            InitializeComponent();
        }
        private void btn_tg_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_XMaLop_Click(object sender, EventArgs e)
        {
            ControlRoom.ControlCurrentUserThamGiaPhongHoc(txt_MaLop.Text);
        }
        public static void ThamGiaLopThanhCong(bool success)
        {
            if (success)
            {
                MessageBox.Show("Tham gia lớp thành công");
            }
            else
            {
                MessageBox.Show("Mã lớp không hợp lệ");
            }
        }
    }
}
