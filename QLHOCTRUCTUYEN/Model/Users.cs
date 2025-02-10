using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;
using QLHOCTRUCTUYEN.QLHOCTRUCTUYENDataSetTableAdapters;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Web;

namespace QLHOCTRUCTUYEN.Model
{
    public class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 200000;
        // Hàm tạo hash cho mật khẩu
        internal static (byte[] Salt, byte[] Hash) HashPassword(string password)
        {
            byte[] salt = GenerateSalt();
            byte[] hash = HashPassword(password, salt, Iterations, HashSize);
            return (salt, hash); // Trả về tuple chứa salt và hash
        }
        private static byte[] GenerateSalt()
        {
            byte[] salt = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        internal static byte[] HashPassword(string password, byte[] salt, int iterations, int hashSize)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(hashSize);
            }
        }

        //Hàm kiểm tra mật khẩu nhập vào có khớp với mật khẩu hash không
        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result |= a[i] ^ b[i];
            }
            return result == 0;
        }

        public static bool VerifyPassword(string password, byte[] saltBase64, byte[] hashBase64)
        {
            // Hash mật khẩu nhập vào với salt đã lưu
            byte[] testHash = HashPassword(password, saltBase64, Iterations, HashSize);

            // So sánh testHash với hash đã lưu
            return FixedTimeEquals(hashBase64, testHash);
        }
    }

    public class ManageUsers
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        private static QLHOCTRUCTUYENDataSetTableAdapters.USERSTableAdapter UsersTableAdapter = new QLHOCTRUCTUYENDataSetTableAdapters.USERSTableAdapter();
        public static string CreateID()
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "SELECT COUNT(*) FROM USERS";

                using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn))
                {
                    string index = Convert.ToString(SqlCmd.ExecuteScalar());

                    return 'U' + index;
                }
            }
        }
        private static bool EmailIsNotUsed(string email)
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "SELECT COUNT(*) FROM USERS WHERE TRANGTHAI = 1 AND EMAIL = @email";
                using (SqlCommand sqlCmd = new SqlCommand(SqlQueryStr, conn))
                {
                    sqlCmd.Parameters.AddWithValue("@email", email);
                    int index = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    if (index == 0)
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }
        public static bool CreateUser (string ten, string email, string pass)
        {
            if (EmailIsNotUsed(email))
            {
                string id = CreateID();
                (byte[] salt, byte[] hash) = PasswordHasher.HashPassword(pass);
                using (SqlConnection conn = new SqlConnection(connSql))
                {
                    conn.Open();

                    string SqlQueryStr = "INSERT INTO USERS (ID_USER, TENUSER, EMAIL, TRANGTHAI, ID_ROLE, SALT, PASSWORD_HASH, ANHDAIDIEN, GIOITINH) " +
                                         "VALUES (@Id, @Ten, @Email, 1, 'R1', @Salt, @HPass, '', NULL)";

                    using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn))
                    {
                        SqlCmd.Parameters.AddWithValue("@Id", id);
                        SqlCmd.Parameters.AddWithValue("@Ten", "N" + ten);
                        SqlCmd.Parameters.AddWithValue("@Email", email);
                        SqlCmd.Parameters.AddWithValue("@Salt", salt);
                        SqlCmd.Parameters.AddWithValue("@HPass", hash);
                        int rowsAffected = SqlCmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }
        public static bool DoiMK(string MkCu, string MkMoi)
        {
            var (salt, hash, userId) = UserLoginHandler.GetUserByEmail(UserLoginHandler.CurUser.EMAIL);
            if (salt == null || hash == null) return false;

            if (UserLoginHandler.ValidatePassword(MkCu, salt, hash))
            {
                (byte[] newsalt, byte[] newhash) =  PasswordHasher.HashPassword(MkMoi);
                using (SqlConnection conn = new SqlConnection(connSql))
                {
                    conn.Open();
                    string SqlQueryStr = "UPDATE USERS SET SALT = @salt, PASSWORD_HASH = @hash WHERE ID_USER = @id_user AND TRANGTHAI = 1";
                    using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn))
                    {
                        SqlCmd.Parameters.AddWithValue("@salt", newsalt);
                        SqlCmd.Parameters.AddWithValue("@hash", newhash);
                        SqlCmd.Parameters.AddWithValue("@id_user", UserLoginHandler.CurUser.ID_USER);
                        int rowsAffected = SqlCmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            } return false;
        }
        public static void XoaNguoiDung(string id_user)
        {
            UsersTableAdapter.UpdateTrangThaiUser(id_user);
        }
        public QLHOCTRUCTUYENDataSet.USERSDataTable TimKiemTheoEmail(string email)
        {
            return UsersTableAdapter.GetDataByEmail(email);
        }
        public QLHOCTRUCTUYENDataSet.USERSDataTable LoadListUsersByPhongHocThamGia(string id_phonghoc)
        {
            return UsersTableAdapter.GetDataUsersByPhongHocThamGia(id_phonghoc);
        }
        public static QLHOCTRUCTUYENDataSet.USERSDataTable ListUserInPhongHocByVaiTro(string id_phonghoc, bool vaitro)
        {
            return UsersTableAdapter.GetListUserInPhongHocByVaiTro(id_phonghoc, vaitro);
        }
        public static bool UpdateUser(string ten, string email, bool gioitinh)
        {
            int rowEffected = UsersTableAdapter.UpdateUser(ten, email, "", gioitinh, UserLoginHandler.CurUser.ID_USER);
            UserLoginHandler.CurUser = UsersTableAdapter.GetData().FindByID_USER(UserLoginHandler.CurUser.ID_USER);
            return rowEffected > 0;
        }
    }
    public class UserLoginHandler
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        private static QLHOCTRUCTUYENDataSetTableAdapters.USERSTableAdapter UsersTableAdapter = new QLHOCTRUCTUYENDataSetTableAdapters.USERSTableAdapter();
        public static QLHOCTRUCTUYENDataSet.USERSRow CurUser { get; internal set; }
        internal static (byte[] salt, byte[] hash, object userId) GetUserByEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();

                using (SqlCommand SqlCmd = new SqlCommand("SELECT ID_USER, SALT, PASSWORD_HASH, ANHDAIDIEN FROM USERS WHERE TRANGTHAI = 1 AND EMAIL = @email", conn))
                {
                    SqlCmd.Parameters.AddWithValue("@email", email);

                    using (SqlDataReader reader = SqlCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] salt = new byte[16];
                            byte[] hash = new byte[32];

                            reader.GetBytes(reader.GetOrdinal("SALT"), 0, salt, 0, salt.Length);
                            reader.GetBytes(reader.GetOrdinal("PASSWORD_HASH"), 0, hash, 0, hash.Length);

                            object userId = reader["ID_USER"] != DBNull.Value ? reader["ID_USER"] : null;

                            return (salt, hash, userId);
                        }
                    }
                }
            }
            return (null, null, null);
        }
        internal static bool ValidatePassword(string inputPassword, byte[] salt, byte[] hash)
        {
            return PasswordHasher.VerifyPassword(inputPassword, salt, hash);
        }
        public static bool ValidLogin(string email, string pass)
        {
            var (salt, hash, userId) = GetUserByEmail(email);

            if (salt == null || hash == null) return false;

            if (ValidatePassword(pass, salt, hash))
            {
                CurUser = UsersTableAdapter.GetData().FindByID_USER(userId?.ToString());
                return true;
            }

            return false;
        }
    }
}
