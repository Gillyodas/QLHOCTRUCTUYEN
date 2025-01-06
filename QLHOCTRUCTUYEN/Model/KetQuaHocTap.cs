using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;


namespace QLHOCTRUCTUYEN.Model
{
    public class KetQuaHocTap
    {
    }

    public class ManageKQHT
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        public static DataTable DataTableKQHTForUser = new DataTable();
        public static DataTable LoadListKQHTForPhongHoc(string id_phong)
        {
            DataTable DataTableKQHTForPhongHoc = new DataTable();
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "SELECT * FROM KETQUAHOCTAP WHERE ID_TAINGUYEN IN " +
                    "(SELECT ID_TAINGUYEN FROM TAINGUYENHOCTAP WHERE ID_PHONGHOC = @id_phong)";
                using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn))
                {
                    SqlCmd.Parameters.AddWithValue("@id_phong", id_phong);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(SqlCmd))
                    {
                        dataAdapter.Fill(DataTableKQHTForPhongHoc);
                    }
                }
            }
            return DataTableKQHTForPhongHoc;
        }
        public static void LoadListKQHTForUser(string id_user, string id_tainguyen)
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "SELECT * FROM KETQUAHOCTAP WHERE ID_USER = @id_user AND ID_TAINGUYEN = @id_tainguyen";
                using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn))
                {
                    SqlCmd.Parameters.AddWithValue("@id_user", id_user);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(SqlCmd))
                    {
                        dataAdapter.Fill(DataTableKQHTForUser);
                    }
                }
            }
        }
        public static void AddNewKQHTToDataTable(string id_user, string id_tnht, float kq, bool tientrinh)
        {
            DataTableKQHTForUser.Rows.Add(id_user, id_tnht, kq, tientrinh);
        }
        public static void UpdateKQHTToSql()
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();

                foreach (DataRow row in DataTableKQHTForUser.Rows)
                {
                    string SqlQueryStr = "INSERT INTO KETQUAHOCTAP (ID_USER, ID_TAINGUYEN, KETQUA, TIENTRINH) VALUES (@id_user, @id_tnht, @kq, @tientrinh)";
                    using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn))
                    {
                        SqlCmd.Parameters.AddWithValue("@id_user", row["ID_USER"]);
                        SqlCmd.Parameters.AddWithValue("@id_tnht", row["ID_TAINGUYEN"]);
                        SqlCmd.Parameters.AddWithValue("@kq", row["KETQUA"]);
                        SqlCmd.Parameters.AddWithValue("@tientrinh", row["TIENTRINH"]);

                        SqlCmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
