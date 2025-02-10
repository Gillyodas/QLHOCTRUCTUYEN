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
        public static QLHOCTRUCTUYENDataSet.TAINGUYENHOCTAPRow TaiNguyen { get; set; }
        public FormCTTaoBaiTap()
        {
            InitializeComponent();
            NgayHienTai();
            LoadLoaiTaiNguyen();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public void SetStateBtn_Xoa()
        {
            btn_XoaBT.Visible = false;
        }
        public void SetSuaBT()
        {
            txt_TieuDe.Text = TaiNguyen.TENTAINGUYEN;
            txt_MoTa.Text = TaiNguyen.MOTA;
            dtp_NgayDang.Value = TaiNguyen.NGAYDANG;
            dtp_HanBT.Value = TaiNguyen.THOIHAN;
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
                form.LoadFlpMessage(form);
            }
            else
                MessageBox.Show("that bai");
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (ManageTaiNguyenHocTap.UpdateTaiNguyenHocTap(TaiNguyen.ID_TAINGUYEN, txt_TieuDe.Text, txt_MoTa.Text, dtp_HanBT.Value))
            {
                FormTrangChu form = Application.OpenForms["FormTrangChu"] as FormTrangChu;
                form.HienThiDanhSachTaiNguyenHocTapTrongPhongHoc();
            }
            else MessageBox.Show("Sửa thất bại");
        }
        private void btn_XoaBT_Click(object sender, EventArgs e)
        {
            if(ManageTaiNguyenHocTap.XoaTNHT(TaiNguyen.ID_TAINGUYEN))
            {
                FormTrangChu form = Application.OpenForms["FormTrangChu"] as FormTrangChu;
                form.HienThiDanhSachTaiNguyenHocTapTrongPhongHoc();
                this.Close();
            }
            else MessageBox.Show("Xóa thất bại");
        }
    }
}
