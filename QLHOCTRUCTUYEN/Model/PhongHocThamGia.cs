using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace QLHOCTRUCTUYEN.Model
{
    public class ManagePhongHocThamGia
    {
        QLHOCTRUCTUYENDataSetTableAdapters.PHONGHOCTHAMGIATableAdapter PHTGTableAdapter = new QLHOCTRUCTUYENDataSetTableAdapters.PHONGHOCTHAMGIATableAdapter();
        public void ThamGiaPhongHoc(string id_user, string id_phonghoc)
        {
            PHTGTableAdapter.Insert(id_phonghoc, id_user, 1);
        }
    }
}
