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
    public static class PHONGHOC
    { 
        public static string IdPhongHoc {  get; set; }
        public static string TenPhongHoc { get; set; }
        public static string MaPhong {  get; set; }
        public static string MoTa {  get; set; }
        public static string IdUser { get; set; }
    }
    public class ManagePhongHoc
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        private static QLHOCTRUCTUYENDataSetTableAdapters.PHONGHOCTableAdapter phonghocTableAdapter = new QLHOCTRUCTUYENDataSetTableAdapters.PHONGHOCTableAdapter();
        public static QLHOCTRUCTUYENDataSet.PHONGHOCRow CurPhongHoc { get; private set; }
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
        public static QLHOCTRUCTUYENDataSet.PHONGHOCRow KiemTraMaPhongHoc_GetPhongHoc(string maphong)
        {
            QLHOCTRUCTUYENDataSet.PHONGHOCRow phonghoc = phonghocTableAdapter.GetPhongHocByMaPhong(maphong).FirstOrDefault();
            return phonghoc;
        }
        public static bool CreatePhongHoc(string id_user, string ten, string mota)
        {
            string idphonghoc = CreateIDPhongHoc();
            int rowsAffected = phonghocTableAdapter.Insert(idphonghoc, ten, CreateMaPhongHoc(CreateIDPhongHoc()), mota, true, id_user);
            if (rowsAffected > 0)
            {
                ManagePhongHocThamGia.ThamGiaPhongHoc(id_user, idphonghoc, true);
                return true;
            } else return false;
            
        }
        public static void CurrentPhongHoc(string id_phonghoc)
        {
             CurPhongHoc =  phonghocTableAdapter.GetData().FindByID_PHONGHOC(id_phonghoc);
        }
        public void UpdatePhongHoc(string id_phonghoc, string ten, string mota, string id_user)
        {
            if (Model.ManagePhongHocThamGia.CheckVaiTroPhongHocThamGia(id_user, id_phonghoc))
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
        public static QLHOCTRUCTUYENDataSet.PHONGHOCDataTable LoadListPhongHocByPhongHocThamGiaCuaUser(string id_user)
        {
            try
            {
                return phonghocTableAdapter.GetDataPhongHocByPhongHocThamGiaCuaUser(id_user);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
