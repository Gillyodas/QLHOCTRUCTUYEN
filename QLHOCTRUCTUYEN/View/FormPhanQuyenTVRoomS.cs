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
    public partial class FormPhanQuyenTVRoomS : Form
    {
        public FormPhanQuyenTVRoomS()
        {
            InitializeComponent();
        }

        private void FormPhanQuyenTVRoomS_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;  // Tắt icon phóng to  
            this.MinimizeBox = false;  // Tắt icon thu nhỏ 
        }
    }
}
