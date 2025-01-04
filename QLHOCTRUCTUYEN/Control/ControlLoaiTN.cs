using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLHOCTRUCTUYEN.Control
{
    public class ControlLoaiTN
    {
        public static DataTable ControlLoadLoaiTN()
        {
            return Model.ManageLoaiTN.LoadLoaiTN();
        }
    }
}
