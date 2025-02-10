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
    public partial class QL_Role : Form
    {
        public QL_Role()
        {
            InitializeComponent();
            LoadRoles();
        }
        private string connStr = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        private DataSet dataSet = new DataSet();
        private void LoadRoles()
        {
            dgv_DsRoles.AutoGenerateColumns = true;
            BindingSource bs = new BindingSource();
            bs.DataSource = ManageRoles.LoadListRoles();
            dgv_DsRoles.DataSource = bs;
        }

        private void SaveChanges()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "SELECT * FROM ROLES";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(dataSet, "ROLES");
                }
                MessageBox.Show("Thay đổi đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            lbl_NhapRole.Visible = true;
            txt_Them.Visible = true;
            btn_Luu.Visible = true;

            string TenRole = txt_Them.Text.Trim();

            if (string.IsNullOrEmpty(TenRole))
            {
                MessageBox.Show("Tên vai trò không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable table = dataSet.Tables["ROLES"];
            DataRow newRow = table.NewRow();
            newRow["TENROLE"] = TenRole;
            table.Rows.Add(newRow);

            SaveChanges();
            LoadRoles();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            dgv_DsRoles.ReadOnly = false;
            if (dgv_DsRoles.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgv_DsRoles.CellValueChanged += dgv_DsRoles_CellValueChanged;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            dgv_DsRoles.ReadOnly = false;
            if (dgv_DsRoles.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow row = ((DataRowView)dgv_DsRoles.CurrentRow.DataBoundItem).Row;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa vai trò này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                row.Delete();
                SaveChanges();
                MessageBox.Show("Vai trò đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            SaveChanges();
            LoadRoles();
        }
        private void dgv_DsRoles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgv_DsRoles.Rows[e.RowIndex].Cells["ID_ROLE"].Value.ToString();
                string ten = dgv_DsRoles.Rows[e.RowIndex].Cells["TENROLE"].Value.ToString();
                bool trangthai = Convert.ToBoolean(dgv_DsRoles.Rows[e.RowIndex].Cells["TRANGTHAI"].Value);
                if ()
                {
                    
                }
                else
                {
                    MessageBox.Show("Sửa vai trò thất bại!");
                }
            }
        }
    }
}
