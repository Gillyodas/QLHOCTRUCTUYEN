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
        private static string CreateIDRole()
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "SELECT COUNT(*) FROM ROLES";
                using (SqlCommand cmd = new SqlCommand(SqlQueryStr, conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    return "R" + (count + 1).ToString();
                }
            }
        }
        public static bool CreateRole(string ten)
        {
            int rowAffected = RolesTableAdapter.Insert(CreateIDRole(), ten, true);
            return rowAffected > 0;
        }
        public static QLHOCTRUCTUYENDataSet.ROLESDataTable LoadListRoles()
        {
            return RolesTableAdapter.GetData(); 
        }
        public static bool UpdateRole(string id, string ten, bool trangthai)
        {
            int rowAffected = RolesTableAdapter.UpdateRoleQuery(ten, trangthai, id);
            return rowAffected > 0;
        }
    }
}
