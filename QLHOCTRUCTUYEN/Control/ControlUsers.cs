using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHOCTRUCTUYEN.Control
{
    public class ControlUsers
    {
        private FormDangKy sender;
        public ControlUsers(FormDangKy sender)
        {
            this.sender = sender;
            this.sender.sentdata += ControlCreateUser;
        }

        public void ControlCreateUser(object sender, DataSentSighUp e)
        {
            Model.ManageUsers.CreateUser(e.HoTen, e.Email, e.Pass);
        }

        public static void test()
        {

        }
        
    }
}
