using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLHOCTRUCTUYEN.Model
{
    public static class Room
    {

        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        // dùng để lấy mới tạo từ createIDRoom
        public static string getIDPhong;
        // dùng để lấy thông tin user hiện tại
        public static CurrentUser user = CurrentUserSession.CurrentUser;

        public static void CreatRoom(string nameroom)
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                // Câu lệnh UPDATE
                string SqlQueryStr = "INSERT INTO PHONGHOC (ID_PHONGHOC, TENPHONGHOC, MAPHONG, TRANGTHAI) VALUES (@NewIdPhong, @TenPhong, @MaPhong, 1)";

                using (SqlCommand Cmd = new SqlCommand(SqlQueryStr, conn))
                {
                    // Thêm tham số cho câu lệnh SQL
                    Cmd.Parameters.AddWithValue("@NewIdPhong", createIdRoom()); // Tạo ID phòng mới
                    Cmd.Parameters.AddWithValue("@TenPhong", nameroom); // Tên phòng truyền vào
                    Cmd.Parameters.AddWithValue("@MaPhong", CheckCodeRoom()); // Mã phòng có thể được tạo tùy ý, bạn có thể thay thế bằng giá trị phù hợp

                    // Thực thi câu lệnh UPDATE
                    int change = Cmd.ExecuteNonQuery();
                    if (change > 0)
                    {
                        MessageBox.Show("tao lop thanh cong");
                    }
                }
            }
        }

        private static string createIdRoom()
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string querystr = "SELECT COUNT(*) FROM PhongHoc"; // Lấy số lượng phòng hiện tại
                using (SqlCommand cmd = new SqlCommand(querystr, conn))
                {
                    // Lấy số lượng phòng và tạo ID mới dựa trên đó
                    int count = (int)cmd.ExecuteScalar(); // Dùng ExecuteScalar để lấy một giá trị duy nhất (số lượng phòng)
                    getIDPhong = "P" + (count + 1).ToString();
                    return getIDPhong; // Tạo ID phòng mới theo định dạng PH + Số phòng tiếp theo
                }
            }
        }
        // them Phong Hoc Tham Gia voi IDPhong va Id User với nút tạo lớp học
        public static void SetParticipationRoom1()
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string querystr = "INSERT INTO PHONGHOCTHAMGIA (ID_PHONGHOC, ID_USER, VAITRO) VALUES (@IdPhong, @IdUser, 1) ";
                using (SqlCommand cmd = new SqlCommand(querystr, conn))
                {
                    cmd.Parameters.AddWithValue("@IdPhong", getIDPhong);
                    cmd.Parameters.AddWithValue("@IdUser", user.UserId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // them Phong Hoc Tham Gia voi IDPhong va Id User với nút tham gia lớp học
        public static void SetParticipationRoom0()
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string querystr = "INSERT INTO PHONGHOCTHAMGIA (ID_PHONGHOC, ID_USER, VAITRO) VALUES (@IdPhong, @IdUser, 0) ";
                using (SqlCommand cmd = new SqlCommand(querystr, conn))
                {
                    cmd.Parameters.AddWithValue("@IdPhong", getIDPhong);
                    cmd.Parameters.AddWithValue("@IdUser", user.UserId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        // tạo chuỗi ký tự ngẫu nhiên với số lượng ký tự nhập bởi tham số
        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }

            return new string(result);
        }
        private static string CheckCodeRoom()
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string maphong;
                bool exists;

                do
                {
                    maphong = GenerateRandomString(6);
                    string query = "SELECT COUNT(*) FROM PHONGHOC WHERE MAPHONG = @MAPHONG";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MAPHONG", maphong);
                        exists = (int)cmd.ExecuteScalar() > 0; // Kiểm tra xem mã phòng đã tồn tại hay chưa
                    }
                } while (exists);

                return maphong;
            }
        }
        // tạo ra các panel đại diện cho phòng
        public static void CallPanelRoom(FormTrangChu form)
        {
            int numRoom = CheckRoom.CheckRoomAmount();
            int panelWidth = 150;
            int panelHeight = 100;
            int gap = 20;
            int startX = 50;
            int startY = 50;
            int panelsPerRow = 6;
            string connectionString = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
            CurrentUser user = CurrentUserSession.CurrentUser;

            List<string> roomNames = new List<string>();

            // Lấy danh sách tên phòng học mà user tham gia
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT PHONGHOC.TENPHONGHOC FROM PHONGHOC " +
                        "JOIN PHONGHOCTHAMGIA ON PHONGHOCTHAMGIA.ID_PHONGHOC = PHONGHOC.ID_PHONGHOC " +
                        "WHERE ID_USER = @IdUser", conn))
                    {
                        cmd.Parameters.AddWithValue("@IdUser", user.UserId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                roomNames.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ: Log hoặc thông báo lỗi
                MessageBox.Show($"Lỗi khi lấy danh sách phòng học: {ex.Message}");
                return;
            }

            // Tạo panel cho từng phòng
            for (int i = 0; i < roomNames.Count; i++)
            {
                int x = startX + (i % panelsPerRow) * (panelWidth + gap);
                int y = startY + (i / panelsPerRow) * (panelHeight + gap);
                FormTrangChu.CreatePanel_Room(i.ToString(), x, y, roomNames[i], form);
            }
        }
        public static bool AccessRoom(string CodeRoom)
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT MAPHONG, ID_PHONGHOC FROM PHONGHOC WHERE MAPHONG= @maphong", conn))
                {
                    cmd.Parameters.AddWithValue("@maphong", CodeRoom);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            getIDPhong = reader.GetString(1);
                            return true;
                        }
                        else { return false; }
                    }
                }

            }

        }
    }
}