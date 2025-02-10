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
using QLHOCTRUCTUYEN.QLHOCTRUCTUYENDataSetTableAdapters;

namespace QLHOCTRUCTUYEN.Model
{
    public class ManagePhongHocThamGia
    {
        private static QLHOCTRUCTUYENDataSetTableAdapters.PHONGHOCTHAMGIATableAdapter PHTGTableAdapter = new QLHOCTRUCTUYENDataSetTableAdapters.PHONGHOCTHAMGIATableAdapter();

        public static bool ThamGiaPhongHoc(string id_user, string id_phonghoc, bool vaitro)
        {
            DataTable dt = PHTGTableAdapter.GetDataByID(id_phonghoc, id_user);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Người dùng đã tham gia phòng học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int rowAffected = PHTGTableAdapter.Insert(id_phonghoc, id_user, vaitro);
            FormTrangChu form = Application.OpenForms["FormTrangChu"] as FormTrangChu;
            form.LoadListPhongHocByPhongHocThamGiaCuaNguoiDung();
            return rowAffected > 0;
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
        public static bool ThoatPhong(string id_user, string id_phonghoc)
        {
            int rowAffected = PHTGTableAdapter.UpdateTrangThaiQuery(id_user, id_phonghoc);
            return rowAffected > 0;
        }
    }
}
