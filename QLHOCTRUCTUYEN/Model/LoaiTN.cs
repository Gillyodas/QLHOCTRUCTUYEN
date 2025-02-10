using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Data;

namespace QLHOCTRUCTUYEN.Model
{
    public class ManageLoaiTN
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        private static QLHOCTRUCTUYENDataSetTableAdapters.LOAITAINGUYENTableAdapter LOAITAINGUYENTableAdapter = new QLHOCTRUCTUYENDataSetTableAdapters.LOAITAINGUYENTableAdapter();
        private static string CreateIDLoaiTaiNguyen()
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "SELECT COUNT(*) FROM LOAITAINGUYEN";
                using (SqlCommand cmd = new SqlCommand(SqlQueryStr, conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    return "L" + (count + 1).ToString();
                }
            }
        }
        public static QLHOCTRUCTUYENDataSet.LOAITAINGUYENDataTable ListLoaiTaiNguyen()
        {
            return LOAITAINGUYENTableAdapter.GetData();
        }
        public static bool UpdateLoaiTN(string id, string ten, bool trangthai)
        {
            int rowAffected = LOAITAINGUYENTableAdapter.UpdateQuery(ten, trangthai, id);
            return rowAffected > 0;
        }
        public static bool ThemLoaiTaiNguyen(string tenLTN)
        {
            int rowAffected = LOAITAINGUYENTableAdapter.Insert(CreateIDLoaiTaiNguyen(), tenLTN, true);
            return rowAffected > 0;
        }
    }
}
