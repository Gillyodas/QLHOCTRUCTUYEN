using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;

namespace QLHOCTRUCTUYEN.Model
{
    public class Users
    {
        private string ID_USER;
        private string TENUSER;
        private string EMAIL;
        private bool TRANGTHAI;
        // Foreign key
        private string ID_ROLE;

        public string IdUser { get; set; }
        public string TenUser { get; set; }
        public string Email { get; set; }
        public bool TrangThai { get; set; }
        public string IdRole { get; set; }
    }


    public class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 200000;
        // Hàm tạo hash cho mật khẩu
        public static (byte[] Salt, byte[] Hash) HashPassword(string password)
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

        private static byte[] HashPassword(string password, byte[] salt, int iterations, int hashSize)
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
                string SqlQueryStr = "SELECT COUNT(*) FROM USERS WHERE EMAIL = @email";
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

                    string SqlQueryStr = "INSERT INTO USERS " +
                                         "VALUES (@Id, @Ten, @Email, 1, 'R1', @Salt, @HPass)";

                    using (SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn))
                    {
                        SqlCmd.Parameters.AddWithValue("@Id", id);
                        SqlCmd.Parameters.AddWithValue("@Ten", ten);
                        SqlCmd.Parameters.AddWithValue("@Email", email);
                        SqlCmd.Parameters.AddWithValue("@Salt", salt);
                        SqlCmd.Parameters.AddWithValue("@HPass", hash);
                        int rowsAffected = SqlCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else return false;
                    }
                }
            } return false;
        }

    }

    public class UserLoginHandler
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        public static Users ValidLogin(string email, string pass)
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();

                using (SqlCommand SqlCmd = new SqlCommand("SELECT * FROM USERS WHERE EMAIL = @email", conn))
                {
                    SqlCmd.Parameters.AddWithValue("@email", email);

                    using (SqlDataReader reader = SqlCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] salt = new byte[16];
                            byte[] hash = new byte[32];

                            long bytesReadSalt = reader.GetBytes(reader.GetOrdinal("SALT"), 0, salt, 0, salt.Length);
                            long bytesReadHash = reader.GetBytes(reader.GetOrdinal("HASHPASSWORD"), 0, hash, 0, hash.Length);

                            if (PasswordHasher.VerifyPassword(pass, salt, hash))
                            {
                                Users user = new Users
                                {
                                    IdUser = reader.GetString(0),
                                    TenUser = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    TrangThai = reader.GetBoolean(3),
                                    IdRole = reader.GetString(4),
                                };

                                return user;
                            }
                        }
                        return null;
                    }
                }
            }
        }


    }
}
