using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.Model;
using QLHOCTRUCTUYEN.View;

namespace QLHOCTRUCTUYEN.Control
{
    public class ControlRoom
    {
        //public static void ControlCreateRoom(string name)
        //{
        //    Model.Room.CreatRoom(name);
        //}
        //public static void ControlSetParticipationRoom1( ) 
        //{
        //    Model.Room.SetParticipationRoom1();
        //}
        //public static void ControlSetParticipationRoom0()
        //{
        //    Model.Room.SetParticipationRoom0();
        //}
        //public static void ControlCreatePanelRoom(FormTrangChu form)
        //{
        //    Model.Room.CallPanelRoom(form);
        //}
        public static void ControlCurrentPhongHoc(string id_phonghoc)
        {
            ManagePhongHoc.CurrentPhongHoc(id_phonghoc);
        }
        public static QLHOCTRUCTUYENDataSet.PHONGHOCDataTable ControlListPhongHocByPhongHocThamGia(string id_user)
        {
            return ManagePhongHoc.LoadListPhongHocByPhongHocThamGiaCuaUser(id_user);
        }
        public static void ControlReloadTrangChu()
        {
            FormTrangChu form = Application.OpenForms["FormTrangChu"] as FormTrangChu;
            if (form != null)
            {
                form.LoadListPhongHocByPhongHocThamGiaCuaNguoiDung(); // Gửi yêu cầu reload
            }
        }
        public static void ControlCurrentUserThamGiaPhongHoc(string maphong)
        {
            var phonghoc = ManagePhongHoc.KiemTraMaPhongHoc_GetPhongHoc(maphong);
            if ( phonghoc != null)
            {
                ManagePhongHocThamGia.ThamGiaPhongHoc(Users.IdUser, phonghoc.ID_PHONGHOC, false);
                FormThamGiaLop.ThamGiaLopThanhCong(true);
            } else { FormThamGiaLop.ThamGiaLopThanhCong(false); }
        }
        public static void ControlTaoPhongHoc(string tenphong, string mota)
        {
            bool success = ManagePhongHoc.CreatePhongHoc(Users.IdUser, tenphong, mota);
            FormTaoLopHoc.TaoPhongThanhCong(success);
        }
    }
}
