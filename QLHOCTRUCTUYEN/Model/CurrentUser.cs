using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHOCTRUCTUYEN.Model
{
    //private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
    public class CurrentUser
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string IDRole { get; set; }
        // Các thuộc tính khác mà bạn cần lưu trữ

        // Constructor có thể để khởi tạo nếu cần
        public CurrentUser(string userId, string username, string email, string role)
        {
            UserId = userId;
            Username = username;
            Email = email;
            IDRole = role;
        }
    }
    public class UserService
    {
        public CurrentUser Login(string username, string password)
        {
  
        // Kết nối đến cơ sở dữ liệu và kiểm tra thông tin đăng nhập
            string connectionString = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString; 
            string query = "SELECT ID_USER, TENUSER, EMAIL, ID_ROLE FROM USERS WHERE Email = @Username ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read(); // Lấy thông tin người dùng
                    string userId = reader.GetString(0);
                    string userEmail = reader.GetString(2);
                    string userRole = reader.GetString(3);

                    // Tạo đối tượng CurrentUser và trả về
                    return new CurrentUser(userId, username, userEmail, userRole);
                }
                else
                {
                    return null; // Nếu không tìm thấy người dùng
                }
            }
        }

    }
    public static class CurrentUserSession
    {
        public static CurrentUser CurrentUser { get; set; }

        // Bạn có thể tạo các phương thức để thiết lập, xóa hoặc lấy thông tin người dùng
        public static void SetCurrentUser(CurrentUser user)
        {
            CurrentUser = user;
        }

        public static void ClearCurrentUser()
        {
            CurrentUser = null;
        }
    }
    

}
