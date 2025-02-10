using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using QLHOCTRUCTUYEN.View;
using System.Windows.Forms;

namespace QLHOCTRUCTUYEN.Model
{
    public class ManagePhongHocThamGia
    {
        private static QLHOCTRUCTUYENDataSetTableAdapters.PHONGHOCTHAMGIATableAdapter PHTGTableAdapter = new QLHOCTRUCTUYENDataSetTableAdapters.PHONGHOCTHAMGIATableAdapter();

        public static void ThamGiaPhongHoc(string id_user, string id_phonghoc, bool vaitro)
        {
            PHTGTableAdapter.Insert(id_phonghoc, id_user, vaitro);
            FormTrangChu form = Application.OpenForms["FormTrangChu"] as FormTrangChu;
            form.LoadListPhongHocByPhongHocThamGiaCuaNguoiDung();
        }
        public static QLHOCTRUCTUYENDataSet.PHONGHOCTHAMGIADataTable LoadListPHTGCuaUser(string id_user)
        {
            return PHTGTableAdapter.GetDataByUser(id_user);
        }
        public static bool CheckVaiTroPhongHocThamGia(string id_user, string id_phonghoc)
        {
            var datarow = LoadListPHTGCuaUser(id_user).FindByID_PHONGHOCID_USER(id_phonghoc, id_user);
            return datarow.VAITRO;
        }
        public static QLHOCTRUCTUYENDataSet.PHONGHOCTHAMGIADataTable LoadListUserInRoom(string id_phonghoc)
        {
            return PHTGTableAdapter.GetDataListUserInRoom(id_phonghoc);
        }
    }
}
