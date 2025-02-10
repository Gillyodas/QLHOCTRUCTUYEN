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
        private void LoadRoles()
        {
            dgv_DsRoles.AutoGenerateColumns = true;
            BindingSource bs = new BindingSource();
            bs.DataSource = ManageRoles.LoadListRoles();
            dgv_DsRoles.DataSource = bs;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            lbl_NhapRole.Visible = true;
            txt_Them.Visible = true;
            btn_Luu.Visible = true;

            
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string TenRole = txt_Them.Text.Trim();

            if (string.IsNullOrEmpty(TenRole))
            {
                MessageBox.Show("Tên vai trò không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ManageRoles.CreateRole(TenRole))
            {
                LoadRoles();
            }
            else
            {
                MessageBox.Show("Thêm vai trò thất bại!");
            }
        }
        private void dgv_DsRoles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgv_DsRoles.Rows[e.RowIndex].Cells["ID_ROLE"].Value.ToString();
                string ten = dgv_DsRoles.Rows[e.RowIndex].Cells["TENROLE"].Value.ToString();
                bool trangthai = Convert.ToBoolean(dgv_DsRoles.Rows[e.RowIndex].Cells["TRANGTHAI"].Value);
                if (ManageRoles.UpdateRole(id, ten, trangthai))
                {
                    LoadRoles();
                }
                else
                {
                    MessageBox.Show("Sửa vai trò thất bại!");
                }
            }
        }
    }
}
