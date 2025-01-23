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
    public partial class FormThamGiaLop : Form
    {
        public FormThamGiaLop()
        {
            InitializeComponent();
        }

        private void btn_tg_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XMaLop_Click(object sender, EventArgs e)
        {
            string Ma = txt_MaLop.Text;
            if (Model.Room.AccessRoom(Ma))
            {
                MessageBox.Show("success");
                Control.ControlRoom.ControlSetParticipationRoom0();
            }
            else {
                MessageBox.Show("fail");
            }
        }
    }
}
