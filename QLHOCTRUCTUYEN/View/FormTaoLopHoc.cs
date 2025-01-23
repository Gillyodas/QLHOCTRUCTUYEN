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
    public partial class FormTaoLopHoc : Form
    {
        public FormTaoLopHoc()
        {
            InitializeComponent();
        }


        private void btnTaoLop_Huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_TaoLop_Click(object sender, EventArgs e)
        {
            string name = txt_TenLopHoc.Text;
            Control.ControlRoom.ControlCreateRoom(name);
            Control.ControlRoom.ControlSetParticipationRoom1();
        }
    }
}
