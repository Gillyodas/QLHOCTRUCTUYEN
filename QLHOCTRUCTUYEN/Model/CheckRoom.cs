using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.View;

namespace QLHOCTRUCTUYEN.Model
{
   
    public class CheckRoom
    {
        
        public static CurrentUser user = CurrentUserSession.CurrentUser;
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;

        // kiểm tra số lượng phòng tham gia
        public static int CheckRoomAmount ()
        {
            using (SqlConnection conn = new SqlConnection (connSql))
            {
                conn.Open();
                string queryStr = " SELECT COUNT(*) FROM PHONGHOCTHAMGIA WHERE ID_USER = @IdUser ";
                using (SqlCommand cmd = new SqlCommand(queryStr, conn)) 
                {
                    cmd.Parameters.AddWithValue("@IdUser", user.UserId);
                    return (int)cmd.ExecuteScalar();
                }    

            }    
        }
        //tạo ra các panel đại diện là phòng học của đang tham gia của người dùng
       
    }
}
