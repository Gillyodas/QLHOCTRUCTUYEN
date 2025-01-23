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
    public partial class FormTTPhongHoc : Form
    {
        public FormTTPhongHoc()
        {
            InitializeComponent();
        }

        private void FormTTPhongHoc_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false; // Vô hiệu hóa nút thu nhỏ
            this.MaximizeBox = false; // Vô hiệu hóa nút phóng to
        }
    }
}
