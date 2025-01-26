using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Configuration;
using System.Data.SqlTypes;
using System.Data;

namespace QLHOCTRUCTUYEN.Model
{
    public class ManagePhongHoc
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        private static QLHOCTRUCTUYENDataSetTableAdapters.PHONGHOCTableAdapter phonghocTableAdapter = new QLHOCTRUCTUYENDataSetTableAdapters.PHONGHOCTableAdapter();
        private static string CreateIDPhongHoc()
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "SELECT COUNT(*) FROM PHONGHOC";
                using (SqlCommand cmd = new SqlCommand(SqlQueryStr, conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    return "PH" + (count + 1).ToString();
                }
            }
        }
        private static string CreateMaPhongHoc(string id_phonghoc)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            char[] stringChars = new char[3];

            for (int i = 0; i < 3; i++)
            {
                // Chọn một ký tự ngẫu nhiên từ tập hợp
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars) + id_phonghoc;
        }
        public bool KiemTraMaPhongHoc(string maphong, string id_phonghoc)
        {
            using (SqlConnection conn = new SqlConnection (connSql))
            {
                conn.Open();
                string QuerySqlStr = "SELECT COUNT(*) FROM PHONGHOC WHERE ID_PHONGHOC = @id_phonghoc AND MAPHONG + @maphong";
                using (SqlCommand SqlCmd = new SqlCommand(QuerySqlStr, conn))
                {
                    SqlCmd.Parameters.AddWithValue("@id_phonghoc", id_phonghoc);
                    SqlCmd.Parameters.AddWithValue("@maphong", maphong);
                    int count = (int)SqlCmd.ExecuteScalar();
                    if (count == 0)
                        return false;
                    else 
                        return true;
                }
            }
        }
        public void CreatePhongHoc(string id_user, string mota, string ten)
        {

            phonghocTableAdapter.Insert(CreateIDPhongHoc(), ten, CreateMaPhongHoc(CreateIDPhongHoc()), mota, true, id_user);
        }
        public object XemThongTinPhongHoc(string id_phonghoc)
        {
            return phonghocTableAdapter.GetData().FirstOrDefault(row => row.ID_PHONGHOC == id_phonghoc);
        }
        public void UpdatePhongHoc(string id_phonghoc, string ten, string mota)
        {
            var phongHocData = phonghocTableAdapter.GetData();
            var row = phongHocData.FindByID_PHONGHOC(id_phonghoc);
            if (row != null)
            {
                row.TENPHONGHOC = ten;
                row.MOTA = mota;
                phonghocTableAdapter.Update(phongHocData);
            }
        }
    }
}
