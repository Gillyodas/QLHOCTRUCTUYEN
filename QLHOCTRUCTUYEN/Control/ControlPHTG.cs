using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHOCTRUCTUYEN.Model;
using QLHOCTRUCTUYEN.View;

namespace QLHOCTRUCTUYEN.Control
{
    public class ControlPHTG
    {
        public static QLHOCTRUCTUYENDataSet.PHONGHOCTHAMGIADataTable ControlLoadListUserInRoom(string id_phonghoc)
        {
            return ManagePhongHocThamGia.LoadListUserInRoom(id_phonghoc);
        }
        public static QLHOCTRUCTUYENDataSet.PHONGHOCTHAMGIADataTable ControlLoadListPHTGCuaUser(string id_user)
        {
            return ManagePhongHocThamGia.LoadListPHTGCuaUser(id_user);
        }
    }
}
