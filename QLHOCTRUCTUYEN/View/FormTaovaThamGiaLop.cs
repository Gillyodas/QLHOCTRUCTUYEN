using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHOCTRUCTUYEN.View
{
    public partial class FormTaovaThamGiaLop : Form
    {
        public FormTaovaThamGiaLop()
        {
            InitializeComponent();
        }

        private void FormTaovaThamGiaLop_Load(object sender, EventArgs e)
        {
            // Tắt hiện tên form trên thanh tiêu đề

            this.Text = "";
            // Tắt nút "X" (Đóng form)
            this.ControlBox = false;

            // Tắt nút thu nhỏ
            this.MinimizeBox = false;

            // Tắt nút phóng to
            this.MaximizeBox = false;
        }

        private void panel_ThamGiaLop_MouseHover(object sender, EventArgs e)
        {
            panel_ThamGiaLop.BackColor = Color.Gray;
            lb_ThamGiaLop.ForeColor = Color.White;
        }

        private void panel_ThamGiaLop_MouseLeave(object sender, EventArgs e)
        {
            panel_ThamGiaLop.BackColor = SystemColors.Control;
            lb_ThamGiaLop.ForeColor = Color.Black;
        }

        private void lb_ThamGiaLop_MouseHover(object sender, EventArgs e)
        {
            panel_ThamGiaLop.BackColor = Color.Gray;
            lb_ThamGiaLop.ForeColor = Color.White;

        }

        private void lb_ThamGiaLop_MouseLeave(object sender, EventArgs e)
        {
            panel_ThamGiaLop.BackColor = SystemColors.Control;
            lb_ThamGiaLop.ForeColor = Color.Black;
        }

        private void lb_TaoLop_MouseHover(object sender, EventArgs e)
        {
            panel_TaoLop.BackColor = Color.Gray;
            lb_TaoLop.ForeColor= Color.White;
        }

        private void lb_TaoLop_MouseLeave(object sender, EventArgs e)
        {
            panel_TaoLop.BackColor = SystemColors.Control;
            lb_TaoLop.ForeColor = Color.Black;
        }

        private void panel_TaoLop_MouseHover(object sender, EventArgs e)
        {
            panel_TaoLop.BackColor = Color.Gray;
            lb_TaoLop.ForeColor = Color.White;
        }

        private void panel_TaoLop_MouseLeave(object sender, EventArgs e)
        {
            panel_TaoLop.BackColor = SystemColors.Control;
            lb_TaoLop.ForeColor = Color.Black;
        }
        private void panel_ThamGiaLop_Click(object sender, EventArgs e)
        {
            FormThamGiaLop FormThamGia = new FormThamGiaLop();
            this.Close();
            FormThamGia.ControlBox = false;         // Tắt toàn bộ thanh điều khiển (X, Minimize, Maximize)
            FormThamGia.Text = "";                  // Xóa tiêu đề (nếu không muốn tiêu đề hiện)
            FormThamGia.StartPosition = FormStartPosition.CenterScreen;
            FormThamGia.ShowDialog();
        }

        private void panel_TaoLop_Click(object sender, EventArgs e)
        {
            FormTaoLopHoc FormTaoLop = new FormTaoLopHoc();
            this.Close();
            FormTaoLop.ControlBox = false;
            FormTaoLop.Text = "";                  // Xóa tiêu đề (nếu không muốn tiêu đề hiện)
            FormTaoLop.StartPosition = FormStartPosition.CenterScreen;
            FormTaoLop.ShowDialog();
        }
    }
}
