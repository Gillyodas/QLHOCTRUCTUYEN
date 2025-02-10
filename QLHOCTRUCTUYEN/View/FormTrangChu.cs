using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHOCTRUCTUYEN.Model;
using QLHOCTRUCTUYEN.View;
using System.Configuration;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace QLHOCTRUCTUYEN.View
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();

            SetVisibleTab_QLPH(false);
            LoadData();
        }
        public void LoadListPhongHocByPhongHocThamGiaCuaNguoiDung()
        {
            lsv_DanhSachPhongHocThamGia.Items.Clear();
            var phongHocList = ManagePhongHoc.LoadListPhongHocByPhongHocThamGiaCuaUser(UserLoginHandler.CurUser.ID_USER);
            if (phongHocList == null || !phongHocList.Any()) { }
            else
            {
                foreach (var item in phongHocList)
                {
                    ListViewItem lsvitem = new ListViewItem();
                    lsvitem.Tag = item.ID_PHONGHOC;
                    lsvitem.Text = item.TENPHONGHOC;
                    lsv_DanhSachPhongHocThamGia.Items.Add(lsvitem);
                }
            }
        }
        public void SetVisibleFeaturesTheoVaiTro()
        {
            if(!ManagePhongHocThamGia.CheckVaiTroPhongHocThamGia(UserLoginHandler.CurUser.ID_USER, ManagePhongHoc.CurPhongHoc.ID_PHONGHOC))
            {
                btn_TaoThongBao.Visible = false;
                btn_TaoBT.Visible = false;
                btn_Them.Visible = false;
                pic_addGV.Visible = false;
            }
        }
        public void SetVisibleTab_QLPH(bool visible)
        {
            tab_QLPH.Visible = visible;
        }
        private void lsv_DanhSachPhongHocThamGia_ItemActivate(object sender, EventArgs e)
        {
            if (lsv_DanhSachPhongHocThamGia.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsv_DanhSachPhongHocThamGia.SelectedItems[0];
                string id_phonghoc = selectedItem.Tag.ToString();
                SetVisibleTab_QLPH(true);
                ManagePhongHoc.CurrentPhongHoc(id_phonghoc);
                SetVisibleFeaturesTheoVaiTro();
                LoadHienThiThongTinPhongHoc(id_phonghoc);
                HienThiDanhSachNguoiDungTrongPhongHoc();
                HienThiDanhSachTaiNguyenHocTapTrongPhongHoc();
                LoadDgvKQHT();
                LoadFlpMessage(this);
            }
        }
        public void LoadHienThiThongTinPhongHoc(string id_phonghoc)
        {
            lbl_TenLop.Text = ManagePhongHoc.CurPhongHoc.TENPHONGHOC;
            txt_MaLop.Text = ManagePhongHoc.CurPhongHoc.MAPHONG;
        }
        public void LoadHienThiThongTinNguoiDung()
        {
            lbl_tk.Text = UserLoginHandler.CurUser.TENUSER;
        }
        public static void CreatePanel_Room(string STTroom,int x, int y, string txtLbl, FormTrangChu form)
        {
            
            // Tạo Panel nhỏ
            Panel panel_Nho = new Panel
            {
                Name = "panel_Room" + STTroom,
                Size = new Size(150, 100), // Kích thước Panel nhỏ
                Location = new Point(x, y), // Vị trí trong panel_GiaoDien
                BackColor = Color.LightBlue,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Tạo Label bên trong Panel nhỏ
            Label label = new Label
            {
                Name = "label_RoomName" + STTroom,
                Text = txtLbl, // Nội dung của Label
                AutoSize = true,
                ForeColor = Color.DarkBlue,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            // Tính toán vị trí để Label căn giữa
            int labelX = (panel_Nho.Width - label.PreferredWidth) / 2;
            int labelY = (panel_Nho.Height - label.PreferredHeight) / 2;
            label.Location = new Point(labelX, labelY);

            // Thêm Label vào Panel nhỏ
            panel_Nho.Controls.Add(label);

            // Thêm Panel nhỏ vào Panel_GiaoDien
            form.pnl_ManHinh.Controls.Add(panel_Nho);
        }
        // hàm tạo bảng tin
        // có thể thêm biến để lưu thời gian đăng
        //fen thêm nếu muốn
        public void CreateMessage(string STTMess, string TenNguoiDang, string TenTaiNguyen , FormTrangChu form)//******************************************************************************************
        {
            Panel pnl_Mess = new Panel
            {
                Anchor = AnchorStyles.Right , // Bám theo chiều ngang // Bám theo chiều ngang
                Name = "panel_Mess" + STTMess,
                Size = new Size( form.flp_Messsage.Width - 25 , 50), // Kích thước Panel nhỏ
               // Location = new Point(x, y), // Vị trí trong panel_GiaoDien
                BackColor = Color.LightBlue,
                BorderStyle = BorderStyle.FixedSingle,
                
                

            };
            Label label = new Label
            {
                Name = "label_Mess" + STTMess,
                Text = TenNguoiDang + " đã đăng một thông báo mới:" + TenTaiNguyen, // Nội dung của Label
                AutoSize = false,
                ForeColor = Color.DarkBlue,
                Font = new Font("Arial", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter, // Căn giữa cả ngang và dọc
                Dock = DockStyle.Fill, // Label chiếm toàn bộ không gian của Panel
                Location = new Point(5, 5), // Chừa khoảng trống bên trong Panel
                
            };

            // Thêm Label vào Panel Mess
            pnl_Mess.Controls.Add(label);

            // Thêm Panel nhỏ vào Panel_GiaoDien
            form.flp_Messsage.Controls.Add(pnl_Mess);  // Thêm control vào cuối
            form.flp_Messsage.Controls.SetChildIndex(pnl_Mess, 0);  // Di chuyển lên đầu
        }
        // Hàm xử lý sự kiện Click cho PictureBox bên phải
        private static void PicRight_Click(object sender, EventArgs e, string STTMess)
        {
            MessageBox.Show("Bạn đã nhấn vào icon phải của bài tập số: " + STTMess, "Thông báo");
           
        }
        // Hàm xử lý sự kiện click vào PictureBox bên trái
        private static void PicLeft_Click(object sender, EventArgs e, string STTMess)
        {
            MessageBox.Show($"Icon bên trái của Panel {STTMess} đã được nhấn!", "Thông báo");
            FormCTBaiTap form = new FormCTBaiTap();
            form.ShowDialog();
        }
        private void pic_TaoVaThamGiaLop_Click(object sender, EventArgs e)
        {
           // Tạo form con
           
             FormTaovaThamGiaLop ChildForm = new FormTaovaThamGiaLop();

           
                // Lấy vị trí của PictureBox trong form
                Point pictureBoxLocation = pic_TaoVaThamGiaLop.Location;

                // Tính toán vị trí form con sao cho nằm dưới và bên trái PictureBox
                int x = pictureBoxLocation.X ; // X của form con bằng X của PictureBox
                int y = pictureBoxLocation.Y + pic_TaoVaThamGiaLop.Height * 4; // Y của form con = Y của PictureBox + chiều cao của PictureBox

                // Đặt vị trí form con
                ChildForm.StartPosition = FormStartPosition.Manual;
                ChildForm.Location = new Point(x, y);
                ChildForm.TopMost = true;// để luôn ở trên cùng của lớp
                                         // Hiển thị form con
                ChildForm.Show(); 
        }
        private void panel_ManHinhChinh_MouseClick(object sender, MouseEventArgs e)
        {
            tab_QLPH.Visible = false;
        }
        public void HienThiDanhSachTaiNguyenHocTapTrongPhongHoc()
        {
            lsv_BaiTap.Items.Clear();
            var TNHTTable = ManageTaiNguyenHocTap.LoadListTNHTByPhongHoc(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC, "L4");
            foreach (DataRow row in TNHTTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["TENTAINGUYEN"].ToString());
                item.SubItems.Add(row["NGAYDANG"].ToString());
                item.SubItems.Add(row["THOIHAN"].ToString());
                item.Tag = row["ID_TAINGUYEN"].ToString();
                lsv_BaiTap.Items.Insert(0, item);
            }
        }
        private void HienThiDanhSachNguoiDungTrongPhongHoc()
        {
            lsv_GiaoVien.Items.Clear();
            var giaoVienTable = ManageUsers.ListUserInPhongHocByVaiTro(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC, true);
            foreach (DataRow row in giaoVienTable.Rows)
            {
                ListViewItem item = new ListViewItem(" ", 0);
                item.SubItems.Add(row["TENUSER"].ToString());
                lsv_GiaoVien.Items.Add(item);
            }
            lsv_SinhVien.Items.Clear();
            var sinhVienTable = ManageUsers.ListUserInPhongHocByVaiTro(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC, false);
            foreach (DataRow row in sinhVienTable.Rows)
            {
                ListViewItem item = new ListViewItem(" ", 0);
                item.SubItems.Add(row["TENUSER"].ToString());
                lsv_SinhVien.Items.Add(item);
            }
        }
        public void LoadData()
        {
            LoadListPhongHocByPhongHocThamGiaCuaNguoiDung();
            LoadHienThiThongTinNguoiDung();
            if(UserLoginHandler.CurUser.ID_ROLE != "R0")
            {
                pan_QLLTN.Visible = false;
                pan_QLRole.Visible = false;
            }
        }
        public void LoadDgvKQHT()
        {
            dgv_KQHT.AutoGenerateColumns = true;
            dgv_KQHT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindingSource bs = new BindingSource();
            bs.DataSource = ManageKQHT.XemDanhSachKQHTCuaTatcaUserTrongPhongHoc(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC);
            dgv_KQHT.DataSource = bs;

            dgv_KQHT.Columns["KETQUA"].ReadOnly = false;
            dgv_KQHT.Columns["TIENTRINH"].ReadOnly = false;
            dgv_KQHT.Columns["ID_USER"].ReadOnly = true;
            dgv_KQHT.Columns["ID_TAINGUYEN"].ReadOnly = true;
            dgv_KQHT.Columns["TENUSER"].ReadOnly = true;
            dgv_KQHT.Columns["TENTAINGUYEN"].ReadOnly = true;
        }
        public void LoadFlpMessage(FormTrangChu form)
        {
            form.flp_Messsage.Controls.Clear();
            var TNHTTable = ManageTaiNguyenHocTap.LoadListTNHTByPhongHoc(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC, "");
            int i = 0;
            foreach (DataRow row in TNHTTable.Rows)
            {
                CreateMessage(i.ToString(), row["TENUSER"].ToString(), row["TENTAINGUYEN"].ToString(), this);
                i++;
            }
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            FormCTTaiKhoan form = new FormCTTaiKhoan();
            Program.OpenOrActivateForm(form);
        }
        private void pan_QLRole_Click(object sender, EventArgs e)
        {
            QL_Role form = new QL_Role();
            Program.OpenOrActivateForm(form);
        }
        private void pan_QLLTN_Click(object sender, EventArgs e)
        {
            QL_LoaiTaiNguyen form = new QL_LoaiTaiNguyen();
            Program.OpenOrActivateForm(form);
        }
        private void btn_TaoThongBao_Click(object sender, EventArgs e)
        {
            FormCTTaoBaiTap form = new FormCTTaoBaiTap();
            Program.OpenOrActivateForm(form);

        }
        private void btn_TaoBT_Click(object sender, EventArgs e)
        {
            FormCTTaoBaiTap form = new FormCTTaoBaiTap();
            Program.OpenOrActivateForm(form);
            form.SetStateBtn_Xoa();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            FormTTPhongHoc form = new FormTTPhongHoc();
            Program.OpenOrActivateForm(form);
        }
        private void pic_addGV_Click(object sender, EventArgs e)
        {
            FormMoiThamGiaLop form = new FormMoiThamGiaLop();
            Program.OpenOrActivateForm(form);
        }
        private void lsv_BaiTap_DoubleClick(object sender, EventArgs e)
        {
            if(lsv_BaiTap.SelectedItems.Count > 0)
            {
                FormCTTaoBaiTap.TaiNguyen = ManageTaiNguyenHocTap.XemChiTietTaiNguyenHocTap(lsv_BaiTap.SelectedItems[0].Tag as string);
                FormCTTaoBaiTap form = new FormCTTaoBaiTap();
                Program.OpenOrActivateForm(form);
                form.SetSuaBT();
            }
        }
        private void dgv_KQHT_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id_tainguyen = dgv_KQHT.Rows[e.RowIndex].Cells["ID_TAINGUYEN"].Value.ToString();
                string id_user = dgv_KQHT.Rows[e.RowIndex].Cells["ID_USER"].Value.ToString();
                object value = dgv_KQHT.Rows[e.RowIndex].Cells["KETQUA"].Value;
                float diem = (value != null && value != DBNull.Value) ? Convert.ToSingle(value) : 0f;
                bool tientrinh = Convert.ToBoolean(dgv_KQHT.Rows[e.RowIndex].Cells["TIENTRINH"].Value);

                if (ManageKQHT.UpdateKQHT(id_user, id_tainguyen, diem, tientrinh))
                {
                    LoadDgvKQHT();
                }
                else
                {
                    MessageBox.Show("Sửa kết quả học tập thất bại!");
                }
            }
        }
    }
}
