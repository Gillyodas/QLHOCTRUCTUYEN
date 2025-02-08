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
        }

        private void SaveChanges()
        {
            //ManageLoaiTN.UpdateLoaiTN(dgv_DsLTN.DataSource)
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            //lbl_DsLTN.Visible = true;
            //txt_LoaiTaiNguyen.Visible = true;

            //string TenLoaiTN = txt_LoaiTaiNguyen.Text.Trim();

            //if (string.IsNullOrEmpty(TenLoaiTN))
            //{
            //    MessageBox.Show("Tên loại tài nguyên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //DataTable table = dataSet.Tables["LOAITAINGUYEN"];
            //DataRow newRow = table.NewRow();
            //newRow["TENLOAITN"] = TenLoaiTN;
            //table.Rows.Add(newRow);

            //SaveChanges();
            //LoadLoaiTN();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            dgv_DsLTN.ReadOnly = false;
            if (dgv_DsLTN.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn loại tài nguyên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgv_DsLTN.CellValueChanged += dgv_DsLTN_CellValueChanged;
        }

        private void dgv_DsLTN_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_DsLTN.Columns["TENLOAITN"].Index)
            {
                DataRow row = ((DataRowView)dgv_DsLTN.Rows[e.RowIndex].DataBoundItem).Row;
                SaveChanges();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            dgv_DsLTN.ReadOnly = false;
            if (dgv_DsLTN.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn loại tài nguyên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow row = ((DataRowView)dgv_DsLTN.CurrentRow.DataBoundItem).Row;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại tài nguyên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                row.Delete();
                SaveChanges();
                MessageBox.Show("Loại tài nguyên đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            SaveChanges();
            LoadLoaiTN();
        }
    }
}
