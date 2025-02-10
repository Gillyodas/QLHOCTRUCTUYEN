using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.QLHOCTRUCTUYENDataSetTableAdapters;


namespace QLHOCTRUCTUYEN.Model
{
    public class ManageKQHT
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        private static QLHOCTRUCTUYENDataSetTableAdapters.KETQUAHOCTAPTableAdapter KQHTTableAdapter = new QLHOCTRUCTUYENDataSetTableAdapters.KETQUAHOCTAPTableAdapter();
        public void CreateKQHT(string id_user, string id_tn, int kq, bool tientrinh)
        {
            KQHTTableAdapter.Insert(id_user, id_tn, kq, tientrinh);
        }
        public static bool UpdateKQHT(double kq, bool tientring, string id_user, string id_tn)
        {
            try
            {
                int rowAffected = KQHTTableAdapter.Update(kq, tientring, id_user, id_tn, kq, tientring);
                return rowAffected > 0;
            }
            catch (DBConcurrencyException)
            {
                //Lỗi xung đột dữ liệu! Hãy tải lại bảng trước khi cập nhật
                return false;
            }
        }
        public QLHOCTRUCTUYENDataSet.KETQUAHOCTAPDataTable ListKQHTCuaUserTheoPhongHoc(string id_user, string id_phonghoc)
        {
            return KQHTTableAdapter.GetKQHTCuaUserTheoPhongHoc(id_user, id_phonghoc);
        }
        public static QLHOCTRUCTUYENDataSet.KETQUAHOCTAPDataTable XemDanhSachKQHTCuaTatcaUserTrongPhongHoc(string id_phonghoc)
        {
            return KQHTTableAdapter.GetDataKQHT_DgvKQHT_ByPhongHoc(id_phonghoc);
        }
        public static bool UpdateKQHT(string id_user, string id_tainguyen, float kq, bool tientrinh)
        {
            int rowAffected = KQHTTableAdapter.UpdateKQHTQuery(kq, tientrinh, id_user, id_tainguyen);
            return rowAffected > 0;
        }
        public static bool AutoCreateKQHT(string id_tainguyen)
        {
            bool success = true;

            foreach (QLHOCTRUCTUYENDataSet.USERSRow row in ManageUsers.ListUserInPhongHocByVaiTro(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC, false))
            {
                try
                {
                    int rowAffected = KQHTTableAdapter.Insert(row.ID_USER, id_tainguyen, 0, false);
                    if (rowAffected == 0)
                    {
                        success = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm kết quả học tập: {ex.Message}");
                    success = false;
                }
            }
            return success;
        }

    }
}
