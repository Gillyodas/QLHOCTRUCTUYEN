using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace QLHOCTRUCTUYEN.Model
{
    public class PhongHoc
    {
        string ID_PHONG;
        string TENPHONG;
        string MOTA;
        string MAPHONG;
        public string IdPhong { get; set; }
        public string TenPhong { get; set; }
        public string MoTa { get; set; }
        public string MaPhong { get; set; }
    }

    public class ManagePhongHoc
    {
    }
}
