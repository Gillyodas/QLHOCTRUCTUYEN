using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.QLHOCTRUCTUYENDataSetTableAdapters;


namespace QLHOCTRUCTUYEN.Model
{
    public class KetQuaHocTap
    {
    }

    public class ManageKQHT
    {
        private static string connSql = ConfigurationManager.ConnectionStrings["QLHOCTRUCTUYEN"].ConnectionString;
        private static QLHOCTRUCTUYENDataSetTableAdapters.KETQUAHOCTAPTableAdapter KQHTTableAdapter = new QLHOCTRUCTUYENDataSetTableAdapters.KETQUAHOCTAPTableAdapter();
        
        private string CreateIDKQHT()
        {
            using (SqlConnection conn = new SqlConnection(connSql))
            {
                string SqlQueryStr = "SELECT COUNT(*) FROM KETQUAHOCTAP";
                using (SqlCommand cmd = new SqlCommand(SqlQueryStr, conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    return "KQ" + (count + 1).ToString();
                }
            }
        }
        public void CreateKQHT(string id_user, string id_tn, int kq, bool tientrinh)
        {
            KQHTTableAdapter.Insert(id_user, id_tn, kq, tientrinh);
        }
        public void UpdateKQHT(string id_user, string id_tn, int kq, bool tientrinh)
        {
            var row = KQHTTableAdapter.GetData().FindByID_USERID_TAINGUYEN(id_user, id_tn);
            if (row != null)
            {
                row.TIENTRINH = tientrinh;
                row.KETQUA = kq;
                KQHTTableAdapter.Update(row);
            }
        }
        public QLHOCTRUCTUYENDataSet.KETQUAHOCTAPDataTable XexKQHTCuaUserTheoPhongHoc(string id_user, string id_phonghoc)
        {
            return KQHTTableAdapter.GetKQHTCuaUserTheoPhongHoc(id_user, id_phonghoc);
        }
        public QLHOCTRUCTUYENDataSet.KETQUAHOCTAPDataTable XemDanhSachKQHTCuaTatcaUserTrongPhongHoc(string id_phonghoc)
        {
            return KQHTTableAdapter.GetDataByTNHTTrongPhongHoc(id_phonghoc);
        }
        public QLHOCTRUCTUYENDataSet.KETQUAHOCTAPDataTable XemKQHTTheoTNHTTrongPhongHoc()
        {
            var QueryLinQ = 
        }

    }
}
