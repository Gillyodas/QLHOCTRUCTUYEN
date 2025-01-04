using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHOCTRUCTUYEN.Control
{
    public class ControlTaiNguyenHocTap
    {
        public static void ControlLoadListTNHT(string id_Phong)
        {
            //FormBTTrenLop.LoadListTaiNguyenHocTap(Model.ManageTaiNguyenHocTap.loadListTaiNguyenHocTap_PhongHoc(id_Phong));
            FormBTTrenLop.listTNHT = Model.ManageTaiNguyenHocTap.loadListTaiNguyenHocTap_PhongHoc(id_Phong);
        }
    }
}
