using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QLHOCTRUCTUYEN.Model
{
    public class ManageRoles
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        private static QLHOCTRUCTUYENDataSetTableAdapters.ROLESTableAdapter RolesTableAdapter = new QLHOCTRUCTUYENDataSetTableAdapters.ROLESTableAdapter();
        public static QLHOCTRUCTUYENDataSet.ROLESDataTable LoadListRoles()
        {
            return RolesTableAdapter.GetData(); 
        }
    }
}
