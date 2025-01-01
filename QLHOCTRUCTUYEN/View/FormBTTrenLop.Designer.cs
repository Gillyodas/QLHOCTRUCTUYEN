namespace QLHOCTRUCTUYEN
{
    partial class FormBTTrenLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUser = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.grbMenuNguoiDung = new System.Windows.Forms.GroupBox();
            this.tabMenuPhongHoc = new System.Windows.Forms.TabControl();
            this.tabBangTin = new System.Windows.Forms.TabPage();
            this.tabBaiTap = new System.Windows.Forms.TabPage();
            this.btnXoaBT = new System.Windows.Forms.Button();
            this.btnSuaBT = new System.Windows.Forms.Button();
            this.btnThemBT = new System.Windows.Forms.Button();
            this.lsvDSBaiTap = new System.Windows.Forms.ListView();
            this.colBaiTap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDaNop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChuaNop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayDang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThoiHan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMoiNguoi = new System.Windows.Forms.TabPage();
            this.tabDiem = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colSinhVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiem1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbDaThamGia = new System.Windows.Forms.GroupBox();
            this.btnPhongHocDaThamGia = new System.Windows.Forms.Button();
            this.btnViecCanLam = new System.Windows.Forms.Button();
            this.grbGiangDay = new System.Windows.Forms.GroupBox();
            this.btnPhongHocDaTao = new System.Windows.Forms.Button();
            this.btnCanXemXet = new System.Windows.Forms.Button();
            this.grbMenuNguoiDung.SuspendLayout();
            this.tabMenuPhongHoc.SuspendLayout();
            this.tabBaiTap.SuspendLayout();
            this.tabDiem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbDaThamGia.SuspendLayout();
            this.grbGiangDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(986, 11);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(62, 42);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Location = new System.Drawing.Point(6, 11);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(65, 42);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // grbMenuNguoiDung
            // 
            this.grbMenuNguoiDung.Controls.Add(this.btnUser);
            this.grbMenuNguoiDung.Controls.Add(this.btnTrangChu);
            this.grbMenuNguoiDung.Location = new System.Drawing.Point(1, 1);
            this.grbMenuNguoiDung.Name = "grbMenuNguoiDung";
            this.grbMenuNguoiDung.Size = new System.Drawing.Size(1048, 71);
            this.grbMenuNguoiDung.TabIndex = 2;
            this.grbMenuNguoiDung.TabStop = false;
            this.grbMenuNguoiDung.Text = " ";
            // 
            // tabMenuPhongHoc
            // 
            this.tabMenuPhongHoc.Controls.Add(this.tabBangTin);
            this.tabMenuPhongHoc.Controls.Add(this.tabBaiTap);
            this.tabMenuPhongHoc.Controls.Add(this.tabMoiNguoi);
            this.tabMenuPhongHoc.Controls.Add(this.tabDiem);
            this.tabMenuPhongHoc.Location = new System.Drawing.Point(201, 78);
            this.tabMenuPhongHoc.Name = "tabMenuPhongHoc";
            this.tabMenuPhongHoc.SelectedIndex = 0;
            this.tabMenuPhongHoc.Size = new System.Drawing.Size(848, 478);
            this.tabMenuPhongHoc.TabIndex = 0;
            // 
            // tabBangTin
            // 
            this.tabBangTin.Location = new System.Drawing.Point(4, 25);
            this.tabBangTin.Name = "tabBangTin";
            this.tabBangTin.Padding = new System.Windows.Forms.Padding(3);
            this.tabBangTin.Size = new System.Drawing.Size(840, 449);
            this.tabBangTin.TabIndex = 0;
            this.tabBangTin.Text = "Bảng tin";
            this.tabBangTin.UseVisualStyleBackColor = true;
            // 
            // tabBaiTap
            // 
            this.tabBaiTap.Controls.Add(this.btnXoaBT);
            this.tabBaiTap.Controls.Add(this.btnSuaBT);
            this.tabBaiTap.Controls.Add(this.btnThemBT);
            this.tabBaiTap.Controls.Add(this.lsvDSBaiTap);
            this.tabBaiTap.Location = new System.Drawing.Point(4, 25);
            this.tabBaiTap.Name = "tabBaiTap";
            this.tabBaiTap.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaiTap.Size = new System.Drawing.Size(733, 434);
            this.tabBaiTap.TabIndex = 1;
            this.tabBaiTap.Text = "Bài tập trên lớp";
            this.tabBaiTap.UseVisualStyleBackColor = true;
            // 
            // btnXoaBT
            // 
            this.btnXoaBT.Location = new System.Drawing.Point(652, 6);
            this.btnXoaBT.Name = "btnXoaBT";
            this.btnXoaBT.Size = new System.Drawing.Size(75, 51);
            this.btnXoaBT.TabIndex = 3;
            this.btnXoaBT.Text = "Xóa";
            this.btnXoaBT.UseVisualStyleBackColor = true;
            // 
            // btnSuaBT
            // 
            this.btnSuaBT.Location = new System.Drawing.Point(571, 6);
            this.btnSuaBT.Name = "btnSuaBT";
            this.btnSuaBT.Size = new System.Drawing.Size(75, 51);
            this.btnSuaBT.TabIndex = 2;
            this.btnSuaBT.Text = "Sửa";
            this.btnSuaBT.UseVisualStyleBackColor = true;
            // 
            // btnThemBT
            // 
            this.btnThemBT.Location = new System.Drawing.Point(490, 6);
            this.btnThemBT.Name = "btnThemBT";
            this.btnThemBT.Size = new System.Drawing.Size(75, 51);
            this.btnThemBT.TabIndex = 1;
            this.btnThemBT.Text = "Thêm";
            this.btnThemBT.UseVisualStyleBackColor = true;
            // 
            // lsvDSBaiTap
            // 
            this.lsvDSBaiTap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBaiTap,
            this.colDaNop,
            this.colChuaNop,
            this.colNgayDang,
            this.colThoiHan});
            this.lsvDSBaiTap.HideSelection = false;
            this.lsvDSBaiTap.Location = new System.Drawing.Point(0, 63);
            this.lsvDSBaiTap.Name = "lsvDSBaiTap";
            this.lsvDSBaiTap.Size = new System.Drawing.Size(733, 368);
            this.lsvDSBaiTap.TabIndex = 0;
            this.lsvDSBaiTap.UseCompatibleStateImageBehavior = false;
            this.lsvDSBaiTap.View = System.Windows.Forms.View.Details;
            // 
            // colBaiTap
            // 
            this.colBaiTap.Text = "Bài tập";
            this.colBaiTap.Width = 349;
            // 
            // colDaNop
            // 
            this.colDaNop.Text = "Đã nộp";
            this.colDaNop.Width = 70;
            // 
            // colChuaNop
            // 
            this.colChuaNop.Text = "Chưa nộp";
            this.colChuaNop.Width = 70;
            // 
            // colNgayDang
            // 
            this.colNgayDang.Text = "Ngày đăng";
            this.colNgayDang.Width = 120;
            // 
            // colThoiHan
            // 
            this.colThoiHan.Text = "Thời hạn";
            this.colThoiHan.Width = 120;
            // 
            // tabMoiNguoi
            // 
            this.tabMoiNguoi.Location = new System.Drawing.Point(4, 25);
            this.tabMoiNguoi.Name = "tabMoiNguoi";
            this.tabMoiNguoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabMoiNguoi.Size = new System.Drawing.Size(733, 434);
            this.tabMoiNguoi.TabIndex = 2;
            this.tabMoiNguoi.Text = "Mọi người";
            this.tabMoiNguoi.UseVisualStyleBackColor = true;
            // 
            // tabDiem
            // 
            this.tabDiem.Controls.Add(this.listView1);
            this.tabDiem.Location = new System.Drawing.Point(4, 25);
            this.tabDiem.Name = "tabDiem";
            this.tabDiem.Size = new System.Drawing.Size(733, 434);
            this.tabDiem.TabIndex = 3;
            this.tabDiem.Text = "Điểm";
            this.tabDiem.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSinhVien,
            this.colDiem1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(727, 428);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colDiem1
            // 
            this.colDiem1.Text = "Điểm";
            this.colDiem1.Width = 57;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grbDaThamGia);
            this.groupBox2.Controls.Add(this.grbGiangDay);
            this.groupBox2.Location = new System.Drawing.Point(1, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 493);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // grbDaThamGia
            // 
            this.grbDaThamGia.Controls.Add(this.btnPhongHocDaThamGia);
            this.grbDaThamGia.Controls.Add(this.btnViecCanLam);
            this.grbDaThamGia.Location = new System.Drawing.Point(0, 147);
            this.grbDaThamGia.Name = "grbDaThamGia";
            this.grbDaThamGia.Size = new System.Drawing.Size(200, 126);
            this.grbDaThamGia.TabIndex = 2;
            this.grbDaThamGia.TabStop = false;
            this.grbDaThamGia.Text = "Đã tham gia";
            // 
            // btnPhongHocDaThamGia
            // 
            this.btnPhongHocDaThamGia.Location = new System.Drawing.Point(3, 67);
            this.btnPhongHocDaThamGia.Name = "btnPhongHocDaThamGia";
            this.btnPhongHocDaThamGia.Size = new System.Drawing.Size(195, 40);
            this.btnPhongHocDaThamGia.TabIndex = 2;
            this.btnPhongHocDaThamGia.Text = "Lớp 2";
            this.btnPhongHocDaThamGia.UseVisualStyleBackColor = true;
            // 
            // btnViecCanLam
            // 
            this.btnViecCanLam.Location = new System.Drawing.Point(3, 21);
            this.btnViecCanLam.Name = "btnViecCanLam";
            this.btnViecCanLam.Size = new System.Drawing.Size(195, 40);
            this.btnViecCanLam.TabIndex = 1;
            this.btnViecCanLam.Text = "Việc cần làm";
            this.btnViecCanLam.UseVisualStyleBackColor = true;
            // 
            // grbGiangDay
            // 
            this.grbGiangDay.Controls.Add(this.btnPhongHocDaTao);
            this.grbGiangDay.Controls.Add(this.btnCanXemXet);
            this.grbGiangDay.Location = new System.Drawing.Point(0, 15);
            this.grbGiangDay.Name = "grbGiangDay";
            this.grbGiangDay.Size = new System.Drawing.Size(200, 126);
            this.grbGiangDay.TabIndex = 1;
            this.grbGiangDay.TabStop = false;
            this.grbGiangDay.Text = "Giảng dạy";
            // 
            // btnPhongHocDaTao
            // 
            this.btnPhongHocDaTao.Location = new System.Drawing.Point(3, 67);
            this.btnPhongHocDaTao.Name = "btnPhongHocDaTao";
            this.btnPhongHocDaTao.Size = new System.Drawing.Size(195, 40);
            this.btnPhongHocDaTao.TabIndex = 2;
            this.btnPhongHocDaTao.Text = "Lớp 1";
            this.btnPhongHocDaTao.UseVisualStyleBackColor = true;
            // 
            // btnCanXemXet
            // 
            this.btnCanXemXet.Location = new System.Drawing.Point(3, 21);
            this.btnCanXemXet.Name = "btnCanXemXet";
            this.btnCanXemXet.Size = new System.Drawing.Size(195, 40);
            this.btnCanXemXet.TabIndex = 1;
            this.btnCanXemXet.Text = "Cần xem xét";
            this.btnCanXemXet.UseVisualStyleBackColor = true;
            // 
            // FormBTTrenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabMenuPhongHoc);
            this.Controls.Add(this.grbMenuNguoiDung);
            this.Name = "FormBTTrenLop";
            this.Text = "Form1";
            this.grbMenuNguoiDung.ResumeLayout(false);
            this.tabMenuPhongHoc.ResumeLayout(false);
            this.tabBaiTap.ResumeLayout(false);
            this.tabDiem.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grbDaThamGia.ResumeLayout(false);
            this.grbGiangDay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.GroupBox grbMenuNguoiDung;
        private System.Windows.Forms.TabControl tabMenuPhongHoc;
        private System.Windows.Forms.TabPage tabBangTin;
        private System.Windows.Forms.TabPage tabBaiTap;
        private System.Windows.Forms.TabPage tabMoiNguoi;
        private System.Windows.Forms.TabPage tabDiem;
        private System.Windows.Forms.ListView lsvDSBaiTap;
        private System.Windows.Forms.ColumnHeader colBaiTap;
        private System.Windows.Forms.ColumnHeader colDaNop;
        private System.Windows.Forms.ColumnHeader colChuaNop;
        private System.Windows.Forms.ColumnHeader colNgayDang;
        private System.Windows.Forms.Button btnThemBT;
        private System.Windows.Forms.Button btnXoaBT;
        private System.Windows.Forms.Button btnSuaBT;
        private System.Windows.Forms.ColumnHeader colThoiHan;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colSinhVien;
        private System.Windows.Forms.ColumnHeader colDiem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbDaThamGia;
        private System.Windows.Forms.Button btnPhongHocDaThamGia;
        private System.Windows.Forms.Button btnViecCanLam;
        private System.Windows.Forms.GroupBox grbGiangDay;
        private System.Windows.Forms.Button btnPhongHocDaTao;
        private System.Windows.Forms.Button btnCanXemXet;
    }
}

