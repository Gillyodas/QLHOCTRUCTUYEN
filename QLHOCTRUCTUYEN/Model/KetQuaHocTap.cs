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
        public static void UpdateKQHT(QLHOCTRUCTUYENDataSet.KETQUAHOCTAPDataTable dt)
        {
            KQHTTableAdapter.Update(dt);
        }
        public QLHOCTRUCTUYENDataSet.KETQUAHOCTAPDataTable XexKQHTCuaUserTheoPhongHoc(string id_user, string id_phonghoc)
        {
            return KQHTTableAdapter.GetKQHTCuaUserTheoPhongHoc(id_user, id_phonghoc);
        }
        public static QLHOCTRUCTUYENDataSet.KETQUAHOCTAPDataTable XemDanhSachKQHTCuaTatcaUserTrongPhongHoc(string id_phonghoc)
        {
            try
            {
                return KQHTTableAdapter.GetData_KQHT_TenUser_TenTNHT_InRoom(id_phonghoc);
            }
            catch (Exception ex)
            { return null; }
        }
    }
}
