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
            var phonghoc = ManagePhongHoc.KiemTraMaPhongHoc_GetPhongHoc(txt_MaLop.Text);
            if (phonghoc != null)
            {
                ManagePhongHocThamGia.ThamGiaPhongHoc(UserLoginHandler.CurUser.ID_USER, phonghoc.ID_PHONGHOC, false);
                this.Close();
            }
            else { MessageBox.Show("Mã lớp không hợp lệ"); }
        }
    }
}
