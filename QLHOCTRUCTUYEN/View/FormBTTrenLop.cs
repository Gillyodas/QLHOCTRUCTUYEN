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
    public partial class FormBTTrenLop : Form
    {
        private static DataTable ListTNHT;
        public static DataTable dtKQHTForPhongHoc;
        public static DataTable listTNHT { get => ListTNHT; set => ListTNHT = value; }
        public FormBTTrenLop()
        {
            InitializeComponent();
            panThemTN.Visible = false;
            Control.ControlTaiNguyenHocTap.ControlLoadListTNHT("P001");
            LoadListTaiNguyenHocTap(listTNHT);
            lblUser.Text = FormDangKy.CurrentUser.TenUser;
            LoadDataGridTableKQHT(dtKQHTForPhongHoc);
        }
        public void LoadListTaiNguyenHocTap(DataTable dsTNHT)
        {
            foreach (DataRow dr in dsTNHT.Rows)
            {
                ListViewItem item = new ListViewItem(dr["TENTAINGUYEN"].ToString());
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add(dr["NGAYDANG"].ToString());
                item.SubItems.Add(dr["THOIHAN"].ToString());
                lsvDSBaiTap.Items.Add(item);
            }
        }
        private void btnThemBT_Click(object sender, EventArgs e)
        {
            ViewLoadLoaiTN(Control.ControlLoaiTN.ControlLoadLoaiTN());
            panThemTN.Visible = true;
        }
        private void ViewLoadLoaiTN(DataTable dsLoaiTN)
        {
            cbbLoaiTN.DataSource = dsLoaiTN;
            cbbLoaiTN.DisplayMember = "TENLOAITN";
            cbbLoaiTN.ValueMember = "ID_LOAITN";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            panThemTN.Visible = false;
        }
        public void LoadDataGridTableKQHT(DataTable dtKQHTForPhong)
        {
            Control.ControlKetQuaHocTap.ControlLoadListKQHTForPhongHoc("P001");
            dgvKQHT.AutoGenerateColumns = true;
            dgvKQHT.DataSource = dtKQHTForPhong;
        }
    }
}
