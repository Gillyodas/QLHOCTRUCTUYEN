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
using QLHOCTRUCTUYEN.View;
using System.Windows.Forms;


namespace QLHOCTRUCTUYEN.Model
{
    public class ManageTaiNguyenHocTap
    {
        private static QLHOCTRUCTUYENDataSetTableAdapters.TAINGUYENHOCTAPTableAdapter tainguyenhoctapTableAdapter = new QLHOCTRUCTUYENDataSetTableAdapters.TAINGUYENHOCTAPTableAdapter();
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        private static string CreateID()
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                conn.Open();
                string SqlQueryStr = "SELECT COUNT(*) FROM TAINGUYENHOCTAP";
                using (SqlCommand cmd = new SqlCommand(SqlQueryStr, conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    return "TN" + (count + 1).ToString();
                }
            }
        }
        public static bool CreateTaiNguyenHocTap(string id_user, string ten, string mota, string id_loaitn, string id_phonghoc, DateTime ngaydang, DateTime thoihan)
        {
            string id_tainguyen = CreateID();
            int rowsAffected = tainguyenhoctapTableAdapter.Insert(id_tainguyen, ten, mota, true, id_loaitn, id_phonghoc, id_user, ngaydang, thoihan);
            ManageKQHT.AutoCreateKQHT(id_tainguyen);
            FormTrangChu form = Application.OpenForms["FormTrangChu"] as FormTrangChu;
            form.LoadDgvKQHT();
            return rowsAffected > 0;
        }
        public static QLHOCTRUCTUYENDataSet.TAINGUYENHOCTAPRow XemChiTietTaiNguyenHocTap(string id_tainguyen)
        {
            return tainguyenhoctapTableAdapter.GetData().FindByID_TAINGUYEN(id_tainguyen);
        }
        public static QLHOCTRUCTUYENDataSet.TAINGUYENHOCTAPDataTable LoadListTNHTByPhongHoc(string id_phonghoc, string id_ltn)
        {
            return tainguyenhoctapTableAdapter.GetDataByPhongHocAndLoaiTN(id_phonghoc, id_ltn);
        }
        public static bool UpdateTaiNguyenHocTap(string id_tainguyen, string ten, string mota, DateTime thoihan)
        {
            var row = tainguyenhoctapTableAdapter.GetData().FindByID_TAINGUYEN(id_tainguyen);
            if (row != null)
            {
                row.TENTAINGUYEN = ten;
                row.MOTA = mota;
                row.THOIHAN = thoihan;
                int rowAffected = tainguyenhoctapTableAdapter.Update(row);
                return rowAffected > 0;
            }
            return false;
        }
        public static bool XoaTNHT(string id_tainguyen)
        {
            int rowAffected = tainguyenhoctapTableAdapter.UpdateTrangThaiQuery(id_tainguyen);
            return rowAffected > 0;
        }
    }
}
