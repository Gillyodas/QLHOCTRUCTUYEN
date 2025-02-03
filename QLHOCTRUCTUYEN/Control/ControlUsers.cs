using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.View;
using QLHOCTRUCTUYEN.Model;
using System.Data;

namespace QLHOCTRUCTUYEN.Control
{
    public class ControlUsers
    {
        public static bool IsLogin { get; private set; } = false;
        public static void ControlCreateUser(string Ten, string Email, string Pass)
        {
            bool success = Model.ManageUsers.CreateUser(Ten, Email, Pass);
            FormDangKy formDK = new FormDangKy();
            formDK.DangKyThanhCong(success);
        }
        public static void ControlLogin(string email, string pass)
        {
            if (UserLoginHandler.ValidLogin(email, pass))
            {
                FormDangKy.DangNhapThatBai(false);
                IsLogin = true;
            }
            else FormDangKy.DangNhapThatBai(true);
        }
        public static DataTable ControlLoadListUserInPhongHocByVaiTro(string id_phonghoc, bool vaitro)
        {
            return ManageUsers.ListUserInPhongHocByVaiTro(id_phonghoc, vaitro);
        }
    }
}
