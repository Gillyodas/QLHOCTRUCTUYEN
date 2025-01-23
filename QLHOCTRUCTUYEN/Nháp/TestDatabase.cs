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

namespace QLHOCTRUCTUYEN.Nháp
{
    public partial class TestDatabase : Form
    {
        public TestDatabase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin người dùng từ CurrentUserSession
            CurrentUser user = CurrentUserSession.CurrentUser;
            MessageBox.Show($"Tên tài khoản là: {user.Email}\n Vai tro là: {user.IDRole}");

        }
    }
}
