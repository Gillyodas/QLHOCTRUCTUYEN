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


namespace QLHOCTRUCTUYEN.Model
{
    public class TaiNguyenHocTap
    {
        private string ID_TAINGUYEN;
        private string TENTAINGUYEN;
        private string URL_TAINGUYEN;
        private string MOTA;
        // Foreign key
        private string ID_USER;
        private string ID_LOAITN;
        private string ID_PHONGHOC;
        public string IdTN { get; set; }
        public string TenTN { get; set; }
        public string URL_TN { get; set; }
        public string MoTa { get; set; }
        public string IdUser { get; set; }
        public string IdLoaiTN { get; set; }
        public string IdPH { get; set; }
    }

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
        public void CreateTaiNguyenHocTap(string id_user, string ten, string url, string mota, string id_loaitn, string id_phonghoc, DateTime ngaydang, DateTime thoihan)
        {
            tainguyenhoctapTableAdapter.Insert(CreateID(), ten, url, mota, true, id_loaitn, id_phonghoc, id_user, ngaydang, thoihan);
        }
        public object XemChiTietTaiNguyenHocTap(string id_tainguyen)
        {
            return tainguyenhoctapTableAdapter.GetData().FindByID_TAINGUYEN(id_tainguyen);
        }
        public DataTable LoadListTNHT(string id_phonghoc)
        {
            var dataTable = new QLHOCTRUCTUYENDataSet.TAINGUYENHOCTAPDataTable();
            tainguyenhoctapTableAdapter.Fill(dataTable);
            return dataTable.AsEnumerable().Where(row => row.ID_PHONGHOC == id_phonghoc).CopyToDataTable();
        }
        public void UpdateTaiNguyenHocTap(string id_tainguyen, string ten, string url, string mota, DateTime ngaydang, DateTime thoihan)
        {
            var row = tainguyenhoctapTableAdapter.GetData().FindByID_TAINGUYEN(id_tainguyen);
            if (row != null)
            {
                row.TENTAINGUYEN = ten;
                row.URL_TAINGUYEN = url;
                row.MOTA = mota;
                row.NGAYDANG = ngaydang;
                row.THOIHAN = thoihan;
                tainguyenhoctapTableAdapter.Update(row);
            }
        }
        public void DeleteTNHT(string id_tainguyen)
        {
            var row = tainguyenhoctapTableAdapter.GetData().FirstOrDefault(r => r.ID_TAINGUYEN == id_tainguyen);
            if (row != null)
            {
                row.TRANGTHAI = false;
                tainguyenhoctapTableAdapter.Update(row);
            }
        }
        public DataTable LocTaiNguyenTheoLoai(string id_phonghoc, string id_loaitn)
        {
            var dataTable = new QLHOCTRUCTUYENDataSet.TAINGUYENHOCTAPDataTable();
            tainguyenhoctapTableAdapter.Fill(dataTable);
            return dataTable.AsEnumerable().Where(r => r.ID_PHONGHOC == id_phonghoc && r.ID_LOAITN == id_loaitn).CopyToDataTable();
        }
    }
}
