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

    public partial class FormTaoLopHoc : Form
    {
        private bool isValidTenPhongHoc = true; //can xem lai
        public FormTaoLopHoc()
        {
            InitializeComponent();
            UpdateBtnTaoLopState();
        }
        private void UpdateBtnTaoLopState()
        {
            btn_TaoLop.Enabled = isValidTenPhongHoc;
        }
        private void btnTaoLop_Huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_TaoLop_Click(object sender, EventArgs e)
        {
            if(!ManagePhongHoc.CreatePhongHoc(UserLoginHandler.CurUser.ID_USER, txt_TenLopHoc.Text, txt_MoTa.Text))
            {
                MessageBox.Show("Tạo phòng thất bại");
            }
        }
        private void btn_TaoLop_TextChanged(object sender, EventArgs e)
        {
            isValidTenPhongHoc = !string.IsNullOrWhiteSpace(txt_TenLopHoc.Text);
            UpdateBtnTaoLopState();
        }
    }
}
