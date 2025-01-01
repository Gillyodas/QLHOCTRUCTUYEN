﻿using System;
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
        //public ControlUsers(FormDangKy sender)
        //{
        //    this.sender = sender;
        //    this.sender.sentdata += ControlCreateUser;
        //}

        //public void ControlCreateUser(object sender, DataSentSighUp e)
        //{
        //    Model.ManageUsers.CreateUser(e.HoTen, e.Email, e.Pass);
        //}

        public static void ControlCreateUser(string Ten, string Email, string Pass)
        {
            bool success = Model.ManageUsers.CreateUser(Ten, Email, Pass);
            FormDangKy formDK = new FormDangKy();
            formDK.DangKyThanhCong(success);
        }

        public static void ControlLogin(string email, string pass)
        {
            FormDangKy formDK = new FormDangKy();
            if (Model.UserLoginHandler.ValidLogin(email, pass) != null)
                formDK.DangNhapThanhcong(true);
            else formDK.DangNhapThanhcong(false);
        }
        
    }
}