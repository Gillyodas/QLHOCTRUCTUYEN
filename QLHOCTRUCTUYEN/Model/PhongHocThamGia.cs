using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace QLHOCTRUCTUYEN.Model
{
    public class PhongHocThamGia
    {
        string ID_PHONG;
        string ID_USER;
        bool VAITRO;
        public string IdPhong { get; set; }
        public string IdUser { get; set; }
        public bool VaiTro { get; set; }
    }
    public class ManagePhongHocThamGia
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        public static DataTable DataTablePhongHocThamGia = new DataTable();
        public static void LoadListPhongHocThamGiaCuaUser(string id_user)
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();

                string SqlQueryStr = "SELECT * FROM PHONGHOCTHAMGIA WHERE ID_USER = @id_user";
                using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn))
                {
                    SqlCmd.Parameters.AddWithValue("id_user", id_user);
                    
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(SqlCmd))
                    {
                        dataAdapter.Fill(DataTablePhongHocThamGia);
                    }
                }
            }
        }
        public static void ThamGiaPhongHoc(string id_user, string id_phong, string maphong)
        {
            QLHOCTRUCTUYENDataSetTableAdapters.PHONGHOCTHAMGIATableAdapter phonghoc = new QLHOCTRUCTUYENDataSetTableAdapters.PHONGHOCTHAMGIATableAdapter();
        }
    }
}
