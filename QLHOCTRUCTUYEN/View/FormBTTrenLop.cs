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

namespace QLHOCTRUCTUYEN
{
    public partial class FormBTTrenLop : Form
    {
        public FormBTTrenLop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentUser user = CurrentUserSession.CurrentUser;
            MessageBox.Show($"Tên tài khoản là: {user.Email}\n Vai tro là: {user.IDRole}");
        }
    }
}
