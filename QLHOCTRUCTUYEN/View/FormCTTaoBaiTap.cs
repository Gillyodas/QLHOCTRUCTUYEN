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
    public partial class FormCTTaoBaiTap : Form
    {
        public FormCTTaoBaiTap()
        {
            InitializeComponent();
            NgayHienTai();
            LoadLoaiTaiNguyen();
        }
        private void NgayHienTai()
        {
            DateTime ngayHienTai = DateTime.Now;
            dtp_NgayDang.Value = ngayHienTai;
        }
        private void LoadLoaiTaiNguyen()
        {
            cbb_LoaiTaiNguyen.DataSource = ManageLoaiTN.ListLoaiTaiNguyen();
            cbb_LoaiTaiNguyen.DisplayMember = "TENLOAITN";
            cbb_LoaiTaiNguyen.ValueMember = "ID_LOAITN";
        }
        private void btn_XacNhanTaoBT_Click(object sender, EventArgs e)
        {
            bool check = ManageTaiNguyenHocTap.CreateTaiNguyenHocTap(UserLoginHandler.CurUser.ID_USER, txt_TieuDe.Text, txt_MoTa.Text, cbb_LoaiTaiNguyen.SelectedValue.ToString(), ManagePhongHoc.CurPhongHoc.ID_PHONGHOC, dtp_NgayDang.Value, dtp_HanBT.Value);
            if (check)
            {
                FormTrangChu form = Application.OpenForms["FormTrangChu"] as FormTrangChu;
                form.HienThiDanhSachTaiNguyenHocTapTrongPhongHoc();
            }
            else
                MessageBox.Show("that bai");
        }
    }
}
