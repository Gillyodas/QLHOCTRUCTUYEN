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
    public partial class FormTTPhongHoc : Form
    {
        public FormTTPhongHoc()
        {
            InitializeComponent();
            SetThongTinFormPhongHoc();
        }
        private void FormTTPhongHoc_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false; // Vô hiệu hóa nút thu nhỏ
            this.MaximizeBox = false; // Vô hiệu hóa nút phóng to
        }
        private void SetThongTinFormPhongHoc()
        {
            txt_MaPhong.Text = ManagePhongHoc.CurPhongHoc.MAPHONG;
            txt_Ten.Text = ManagePhongHoc.CurPhongHoc.TENPHONGHOC;
            txt_MoTa.Text = ManagePhongHoc.CurPhongHoc.MOTA;
        }
        private void btn_ThayDoi_Click(object sender, EventArgs e)
        {
            if (ManagePhongHoc.UpdatePhongHoc(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC, txt_Ten.Text, txt_MoTa.Text, UserLoginHandler.CurUser.ID_USER))
            {
                FormTrangChu form = Application.OpenForms["FormTrangChu"] as FormTrangChu;
                form.LoadHienThiThongTinPhongHoc(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC);
                form.LoadListPhongHocByPhongHocThamGiaCuaNguoiDung();
            }
            else MessageBox.Show("Fail");
        }
    }
}
