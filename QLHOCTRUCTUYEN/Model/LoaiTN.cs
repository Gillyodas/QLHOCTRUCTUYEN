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
    public class LoaiTN
    {
        string IDLOAITN;
        string TENLOAITN;

        public string IDLOAITN1 { get; set; }
        public string TENLOAITN1 { get; set; }
    }
    public class ManageLoaiTN
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        public static DataTable LoadLoaiTN()
        {
            List<LoaiTN> listLoaiTN = new List<LoaiTN>();
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "SELECT * FROM LOAITAINGUYEN";
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(SqlQueryStr, conn))
                {
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}
