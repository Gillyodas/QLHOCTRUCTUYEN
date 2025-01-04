using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.View;

namespace QLHOCTRUCTUYEN.View
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void pic_TaoVaThamGiaLop_Click(object sender, EventArgs e)
        {
           // Tạo form con
             FormTaovaThamGiaLop ChildForm = new FormTaovaThamGiaLop();
            
            // Lấy vị trí của PictureBox trong form
            Point pictureBoxLocation = pic_TaoVaThamGiaLop.Location;

            // Tính toán vị trí form con sao cho nằm dưới và bên trái PictureBox
            int x = pictureBoxLocation.X; // X của form con bằng X của PictureBox
            int y = pictureBoxLocation.Y + pic_TaoVaThamGiaLop.Height*4; // Y của form con = Y của PictureBox + chiều cao của PictureBox

            // Đặt vị trí form con
            ChildForm.StartPosition = FormStartPosition.Manual;
            ChildForm.Location = new Point(x, y);
            ChildForm.TopMost = true;// để luôn ở trên cùng của lớp
            // Hiển thị form con
            ChildForm.Show();
        }
    }
}
