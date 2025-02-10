using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.Model;

namespace QLHOCTRUCTUYEN.View
{
    public partial class FormCTBaiTap : Form
    {
        public static QLHOCTRUCTUYENDataSet.TAINGUYENHOCTAPRow TaiNguyen {  get; set; }
        public FormCTBaiTap()
        {
            InitializeComponent();
            SetBase();
        }
        public void SetBase()
        {
            lbl_TieuDe.Text = TaiNguyen.TENTAINGUYEN;
            dtp_NgayDang.Value = TaiNguyen.NGAYDANG;
            dtp_ThoiHan.Value = TaiNguyen.THOIHAN;
            txt_MoTa.Text = TaiNguyen.MOTA;
        }
      
    }
}
