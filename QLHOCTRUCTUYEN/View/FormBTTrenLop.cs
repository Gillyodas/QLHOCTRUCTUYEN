using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHOCTRUCTUYEN
{
    public partial class FormBTTrenLop : Form
    {
        public FormBTTrenLop()
        {
            InitializeComponent();
            Control.ControlTaiNguyenHocTap.ControlLoadListTNHT("P001");
        }

        public void LoadListTaiNguyenHocTap(DataTable dsTNHT)
        {
            foreach (DataRow dr in dsTNHT.Rows)
            {
                ListViewItem item = new ListViewItem(dr["TENTAINGUYEN"].ToString());
                lsvDSBaiTap.Items.Add(item);
            }
        }
    }
}
