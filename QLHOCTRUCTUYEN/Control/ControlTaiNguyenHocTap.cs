using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHOCTRUCTUYEN.Model;

namespace QLHOCTRUCTUYEN.Control
{
    public class ControlTaiNguyenHocTap
    {
        public static QLHOCTRUCTUYENDataSet.TAINGUYENHOCTAPDataTable LoadDanhSachTNHTTrongPhong(string id_phonghoc)
        {
            return ManageTaiNguyenHocTap.LoadListTNHTByPhongHoc(id_phonghoc);
        }
    }
}
