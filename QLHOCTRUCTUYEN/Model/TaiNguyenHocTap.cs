using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;


namespace QLHOCTRUCTUYEN.Model
{
    public class TaiNguyenHocTap
    {
        private string ID_TAINGUYEN;
        private string TENTAINGUYEN;
        private string URL_TAINGUYEN;
        private string MOTA;
        // Foreign key
        private string ID_USER;
        private string ID_LOAITN;
        private string ID_PHONGHOC;
        public string IdTN { get; set; }
        public string TenTN { get; set; }
        public string URL_TN { get; set; }
        public string MoTa { get; set; }
        public string IdUser { get; set; }
        public string IdLoaiTN { get; set; }
        public string IdPH { get; set; }
    }

    public class ManageTaiNguyenHocTap
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        public static DataTable loadListTaiNguyenHocTap_PhongHoc (string idPhongHoc)
        {
            using (SqlConnection conn = new SqlConnection (connSql))
            {
                conn.Open ();
                DataTable dataTable = new DataTable();
                string SqlQueryStr = "SELECT * FROM TAINGUYENHOCTAP WHERE ID_PHONGHOC = @idPhongHoc AND TRANGTHAI = 1";
                using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn))
                {
                    SqlCmd.Parameters.AddWithValue("idPhongHoc",idPhongHoc);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(SqlCmd))
                    {
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
        private static string CreateID()
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "SELECT COUNT(*) FROM TAINGUYENHOCTAP";
                using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn))
                {
                    string index = Convert.ToString(SqlCmd.ExecuteScalar());

                    return "TN" + index;
                }
            }
        }
        public static bool CreateTaiNguyenHocTap(string name, string url, string mota, string idUser, string idLoaiTN, string idPhong)
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "INSERT INTO TAINGUYENHOCTAP " +
                    "VALUES (@idTaiNguyen, @name, @url, @mota, 1, @idUser, @idLoaiTN, @idPhongHoc)";
                using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn))
                {
                    SqlCmd.Parameters.AddWithValue("@idTaiNguyen", CreateID());
                    SqlCmd.Parameters.AddWithValue("@name", name);
                    SqlCmd.Parameters.AddWithValue("@url", url);
                    SqlCmd.Parameters.AddWithValue("@mota", mota);
                    SqlCmd.Parameters.AddWithValue("@idUser", idUser);
                    SqlCmd.Parameters.AddWithValue("@idLoaiTN", idLoaiTN);
                    SqlCmd.Parameters.AddWithValue("@idPhongHoc", idPhong);

                    int rowsAffected = SqlCmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public static bool UpdateTaiNguyenHocTap(string id, string name, string url, string mota, string idLoaiTN)
        {
            using (SqlConnection conn =new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "UPDATE TAINGUYENHOCTAP SET TENTAINGUYEN = @name, URL_TAINGUYEN = @url, MOTA = @mota, ID_LOAITN = idLoaiTN WHERE ID_TAINGUYEN = @id";
                using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr,conn))
                {
                    SqlCmd.Parameters.AddWithValue("@name", name);
                    SqlCmd.Parameters.AddWithValue("@url", url);
                    SqlCmd.Parameters.AddWithValue("@mota", mota);
                    SqlCmd.Parameters.AddWithValue("@idLoaiTN", idLoaiTN);
                    SqlCmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = SqlCmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public static bool DeleteTaiNguyenHocTap(string id)
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "UPDATE TAINGUYENHOCTAP SET TRANGTHAI = 0 WHERE ID_TAINGUYEN = @id";
                using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn))
                {
                    SqlCmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = SqlCmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public static TaiNguyenHocTap ReadTaiNguyenHocTap(string id)
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "SELECT * FROM TAINGUYENHOCTAP WHERE ID_TAINGUYEN = @id";
                using ( SqlCommand SqlCmd = new SqlCommand( SqlQueryStr, conn))
                {
                    SqlCmd.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = SqlCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TaiNguyenHocTap tnht = new TaiNguyenHocTap
                            {
                                IdTN = reader.GetString(0),
                                TenTN = reader.GetString(1),
                                URL_TN = reader.GetString(2),
                                MoTa = reader.GetString(3),
                                IdUser = reader.GetString(5),
                                IdLoaiTN = reader.GetString(6),
                                IdPH = reader.GetString(7)
                            };
                            return tnht;
                        } return null;
                    }
                }
            }
        }
    }
}
