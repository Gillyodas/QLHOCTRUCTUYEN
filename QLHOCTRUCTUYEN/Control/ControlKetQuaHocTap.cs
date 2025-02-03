using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHOCTRUCTUYEN.Model;
using QLHOCTRUCTUYEN.View;

namespace QLHOCTRUCTUYEN.Control
{
    public class ControlKetQuaHocTap
    {
        public static DataTable Data_KQHTCuaUserTrongPhong(string id_phonghoc)
        {
            return ManageKQHT.XemDanhSachKQHTCuaTatcaUserTrongPhongHoc(id_phonghoc);
        }
    }
}
