using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;

namespace QLHOCTRUCTUYEN.Model
{
    public class Users
    {
        private string ID_USER;
        private string TENUSER;
        private string EMAIL;
        private string PASSWORD_HASH;
        private bool TRANGTHAI;

        //Foreign key
        private string ID_ROLE;
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

        // Hàm kiểm tra mật khẩu nhập vào có khớp với mật khẩu hash không
        //public static bool VerifyPassword(string password, string hashedPassword)
        //{
        //    // Tách chuỗi hash đã lưu thành các thành phần
        //    string[] parts = hashedPassword.Split(':');
        //    if (parts.Length != 3)
        //    {
        //        return false; // Định dạng hash không hợp lệ
        //    }

        //    int iterations;
        //    if (!int.TryParse(parts[0], out iterations))
        //    {
        //        return false; // Số lần lặp không hợp lệ
        //    }

        //    byte[] salt;
        //    try
        //    {
        //        salt = Convert.FromBase64String(parts[1]);
        //    }
        //    catch (FormatException)
        //    {
        //        return false; // Định dạng salt không hợp lệ
        //    }

        //    byte[] hash;
        //    try
        //    {
        //        hash = Convert.FromBase64String(parts[2]);
        //    }
        //    catch (FormatException)
        //    {
        //        return false; // Định dạng hash không hợp lệ
        //    }

        //    // Băm mật khẩu được cung cấp với salt và số lần lặp đã lưu
        //    byte[] testHash = HashPassword(password, salt, iterations, HashSize);

        //    // So sánh hash được tạo với hash đã lưu
        //    return CryptographicOperations.FixedTimeEquals(hash, testHash);
        //}
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

                SqlCommand SqlCmd = new SqlCommand(SqlQueryStr, conn);

                string index = Convert.ToString(SqlCmd.ExecuteScalar());

                return 'U' + index;
            }
        }
        public static void CreateUser (string ten, string email, string pass)
        {
            string id = CreateID();
            (byte[] salt, byte[] hash) = PasswordHasher.HashPassword(pass);
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();

                string SqlQueryStr = "INSERT INTO USERS " +
                                     "VALUES (@Id, @Ten, @Email, 1, 'R1', @Salt, @HPass)";

                SqlCommand SqlCmd = new SqlCommand(SqlQueryStr,conn);

                SqlCmd.Parameters.AddWithValue("@Id", id);
                SqlCmd.Parameters.AddWithValue("@Ten", ten);
                SqlCmd.Parameters.AddWithValue("@Email", email);
                SqlCmd.Parameters.AddWithValue("@Salt", salt);
                SqlCmd.Parameters.AddWithValue("@HPass", hash);
                int rowsAffected = SqlCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    SqlCmd.Parameters.Clear();

                }
            }
        }

    }
}
