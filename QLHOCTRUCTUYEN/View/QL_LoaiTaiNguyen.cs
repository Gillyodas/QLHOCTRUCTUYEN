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
using System.Data.SqlClient;
using QLHOCTRUCTUYEN.Model;

namespace QLHOCTRUCTUYEN.View
{
    public partial class QL_LoaiTaiNguyen : Form
    {
        public QL_LoaiTaiNguyen()
        {
            InitializeComponent();
            LoadLoaiTN();
        }
        private void LoadLoaiTN()
        {
            dgv_DsLTN.AutoGenerateColumns = true;
            BindingSource bs = new BindingSource();
            bs.DataSource = ManageLoaiTN.ListLoaiTaiNguyen();
            dgv_DsLTN.DataSource = bs;
            dgv_DsLTN.Columns["ID_LOAITN"].ReadOnly = true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            lbl_DsLTN.Visible = true;
            txt_LoaiTaiNguyen.Visible = true;
            btn_Luu.Visible = true;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_LoaiTaiNguyen.Text))
            {
                MessageBox.Show("Tên loại tài nguyên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(ManageLoaiTN.ThemLoaiTaiNguyen(txt_LoaiTaiNguyen.Text))
                {
                    LoadLoaiTN();
                }
                else
                {
                    MessageBox.Show("Thêm loại tài nguyên thất bại!");
                }
            }
        }
        private void dgv_DsLTN_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgv_DsLTN.Rows[e.RowIndex].Cells["ID_LOAITN"].Value.ToString();
                string ten = dgv_DsLTN.Rows[e.RowIndex].Cells["TENLOAITN"].Value.ToString();
                bool trangthai = Convert.ToBoolean(dgv_DsLTN.Rows[e.RowIndex].Cells["TRANGTHAI"].Value);
                if (ManageLoaiTN.UpdateLoaiTN(id, ten, trangthai))
                {
                    LoadLoaiTN();
                }
                else
                {
                    MessageBox.Show("Sửa loại tài nguyên thất bại!");
                }
            }
        }
    }
}
