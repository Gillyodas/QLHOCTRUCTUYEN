using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHOCTRUCTUYEN.Control
{
    public class ControlKetQuaHocTap
    {
        public static void ControlLoadListKQHTForPhongHoc(string id_phong)
        {
            FormBTTrenLop.dtKQHTForPhongHoc = Model.ManageKQHT.LoadListKQHTForPhongHoc(id_phong);
        }
    }
}
