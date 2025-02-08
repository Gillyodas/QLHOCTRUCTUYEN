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
namespace QLHOCTRUCTUYEN.View
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
            
            tab_QLPH.Visible = false;
            //this.ReloadRequested += FormTT_ReloadRequested;
        }
        public void LoadListPhongHocByPhongHocThamGiaCuaNguoiDung()
        {
            lsv_DanhSachPhongHocThamGia.Items.Clear();
            var phongHocList = ControlRoom.ControlListPhongHocByPhongHocThamGia(Users.IdUser);
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
        private void lsv_DanhSachPhongHocThamGia_ItemActivate(object sender, EventArgs e)
        {
            if (lsv_DanhSachPhongHocThamGia.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsv_DanhSachPhongHocThamGia.SelectedItems[0];
                string id_phonghoc = selectedItem.Tag.ToString();
                tab_QLPH.Visible = true;
                ControlRoom.ControlCurrentPhongHoc(id_phonghoc);
                LoadHienThiThongTinPhongHoc(id_phonghoc);
                HienThiDanhSachNguoiDungTrongPhongHoc();
                HienThiDanhSachTaiNguyenHocTapTrongPhongHoc();
                LoadDgvKQHT();
                LoadFlpMessage();
            }
        }
        private void LoadHienThiThongTinPhongHoc(string id_phonghoc)
        {
            lbl_TenLop.Text = ManagePhongHoc.CurPhongHoc.TENPHONGHOC;
            txt_MaLop.Text = ManagePhongHoc.CurPhongHoc.MAPHONG;
        }
        public void LoadHienThiThongTinNguoiDung()
        {
            lbl_tk.Text = Users.TenUser;
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
        public static void CreateMessage(string STTMess, string TenNguoiDang, string TenTaiNguyen , FormTrangChu form)//******************************************************************************************
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
                Text = TenNguoiDang + " đã đăng một bài tập mới:" + TenTaiNguyen, // Nội dung của Label
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
            form.flp_Messsage.Controls.Add(pnl_Mess);
        }
        public static void CreateAssignment(string STTMess, string TenBT, FormTrangChu form)//***************************************************************************************************************
        {
            // Tạo Panel Assignment
            Panel pnl_Asigment = new Panel
            {
                Anchor = AnchorStyles.Right,
                Name = "panel_Mess" + STTMess,
                Size = new Size(form.flp_Messsage.Width - 20, 50),
                BackColor = Color.LightBlue,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10) // Thêm margin 10 pixel mỗi bên
            };

            // Tạo PictureBox bên trái
            PictureBox picLeft = new PictureBox
            {
                Name = "picLeft_Mess" + STTMess,
                Size = new Size(40, 40), // Kích thước của icon
                Image = Properties.Resources.checklist, // Thay bằng icon mong muốn
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(5, 5) // Vị trí trong Panel
            };

            // Gán sự kiện Click cho PictureBox bên trái
            picLeft.Click += (sender, e) => PicLeft_Click(sender, e, STTMess);

            // Tạo PictureBox bên phải
            PictureBox picRight = new PictureBox
            {
                Name = "picRight_Mess" + STTMess,
                Size = new Size(40, 40), // Kích thước của icon
                Image = Properties.Resources.more, // Thay bằng icon mong muốn
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(pnl_Asigment.Width - 45, 5) // Vị trí trong Panel
            };

            // Gán sự kiện Click cho PictureBox bên phải
            picRight.Click += (sender, e) => PicRight_Click(sender, e, STTMess);

            // Tạo Label ở giữa
            Label label = new Label
            {
                Name = "label_Mess" + STTMess,
                Text = "Nộp kết quả bài " + TenBT, // Nội dung của Label
                AutoSize = false,
                ForeColor = Color.DarkBlue,
                Font = new Font("Arial", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.None, // Không chiếm toàn bộ Panel
                Size = new Size(pnl_Asigment.Width - 100, 40), // Chiều rộng trừ hai icon (40 + 40 + khoảng cách)
                Location = new Point(50, 5) // Vị trí chính giữa Panel (đã tính toán khoảng trống của icon)
            };

            // Thêm các thành phần vào Panel Assignment
            pnl_Asigment.Controls.Add(picLeft);
            pnl_Asigment.Controls.Add(picRight);
            pnl_Asigment.Controls.Add(label);

            // Thêm Panel Assignment vào FlowLayoutPanel
            //form.flp_BaiTap.Controls.Add(pnl_Asigment);
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
        private void lsv_GiaoVien_SelectedIndexChanged(object sender, EventArgs e)//*********************************************************************************
        {
            if (lsv_GiaoVien.SelectedItems.Count > 0) // Kiểm tra có hàng được chọn
            {
                // Lấy mục được chọn
                ListViewItem selectedItem = lsv_GiaoVien.SelectedItems[0];

                // Lấy tọa độ của mục đã chọn (không tính tiêu đề)
                int x = selectedItem.Position.X;
                int y = selectedItem.Position.Y;

                // Tạo form mới
                FormPhanQuyenTVRoomG form = new FormPhanQuyenTVRoomG();

                // Mở form tại vị trí click của item
                form.StartPosition = FormStartPosition.Manual; // Đặt vị trí thủ công
                form.Location = new Point(x + this.Left + lsv_GiaoVien.Left, y + this.Top + lsv_GiaoVien.Top); // Cộng thêm offset nếu cần thiết
                form.TopMost = true;
                // Hiển thị form
                form.Show();
            }
        }
        private void lsv_SinhVien_SelectedIndexChanged(object sender, EventArgs e)//**********************************************************************
        {
            if (lsv_SinhVien.SelectedItems.Count > 0) // Kiểm tra có hàng được chọn
            {
                // Lấy mục được chọn
                ListViewItem selectedItem = lsv_SinhVien.SelectedItems[0];

                // Lấy tọa độ của mục đã chọn (không tính tiêu đề)
                int x = selectedItem.Position.X;
                int y = selectedItem.Position.Y;

                // Tạo form mới
                FormPhanQuyenTVRoomS form = new FormPhanQuyenTVRoomS();
                

                // Mở form tại vị trí click của item
                form.StartPosition = FormStartPosition.Manual; // Đặt vị trí thủ công
                form.Location = new Point(x + this.Left + lsv_GiaoVien.Left, y + this.Top + lsv_GiaoVien.Top); // Cộng thêm offset nếu cần thiết
                form.TopMost = true;
                // Hiển thị form
                form.Show();
            }
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            FormCTTaiKhoan form = new FormCTTaiKhoan();
            form.ShowDialog();
        }
        private void panel_ManHinhChinh_MouseClick(object sender, MouseEventArgs e)
        {
            tab_QLPH.Visible = false;
        }
        private void HienThiDanhSachTaiNguyenHocTapTrongPhongHoc()
        {
            lsv_BaiTap.Items.Clear();
            var TNHTTable = ControlTaiNguyenHocTap.LoadDanhSachTNHTTrongPhong(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC);
            foreach (DataRow row in TNHTTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["TENTAINGUYEN"].ToString());
                item.SubItems.Add(row["NGAYDANG"].ToString());
                item.SubItems.Add(row["THOIHAN"].ToString());
                item.Tag = row["ID_TAINGUYEN"].ToString();
                lsv_BaiTap.Items.Add(item);
            }
        }
        private void HienThiDanhSachNguoiDungTrongPhongHoc()
        {
            lsv_GiaoVien.Items.Clear();
            var giaoVienTable = ControlUsers.ControlLoadListUserInPhongHocByVaiTro(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC, true);
            foreach (DataRow row in giaoVienTable.Rows)
            {
                ListViewItem item = new ListViewItem(" ", 0);
                item.SubItems.Add(row["TENUSER"].ToString());
                lsv_GiaoVien.Items.Add(item);
            }
            lsv_SinhVien.Items.Clear();
            var sinhVienTable = ControlUsers.ControlLoadListUserInPhongHocByVaiTro(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC, false);
            foreach (DataRow row in sinhVienTable.Rows)
            {
                ListViewItem item = new ListViewItem(" ", 0);
                item.SubItems.Add(row["TENUSER"].ToString());
                lsv_SinhVien.Items.Add(item);
            }
        }
        private void btn_TaoBT_Click_1(object sender, EventArgs e)
        {
            LoadListPhongHocByPhongHocThamGiaCuaNguoiDung();
            LoadHienThiThongTinNguoiDung();
        }
        private void LoadDgvKQHT()
        {
            dgv_KQHT.AutoGenerateColumns = true;
            BindingSource bs = new BindingSource();
            bs.DataSource = ControlKetQuaHocTap.Data_KQHTCuaUserTrongPhong(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC);
            dgv_KQHT.DataSource = bs;
        }
        private void LoadFlpMessage()
        {
            var TNHTTable = ControlTaiNguyenHocTap.LoadDanhSachTNHTTrongPhong(ManagePhongHoc.CurPhongHoc.ID_PHONGHOC);
            int i = 0;
            foreach (DataRow row in TNHTTable.Rows)
            {
                CreateMessage(i.ToString(), row["TENUSER"].ToString(), row["TENTAINGUYEN"].ToString(), this);
                i++;
            }
        }







        //public void LoadDataGridViewBTTrenLop()
        //{
        //    dataGridView2.AutoGenerateColumns = true;
        //    dataGridView2.DataSource = Control.ControlTaiNguyenHocTap.LoadDanhSachTNHTTrongPhong("P001");
        //}
    }
}
