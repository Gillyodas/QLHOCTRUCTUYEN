namespace QLHOCTRUCTUYEN.View
{
    partial class FormCTTaiKhoan
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
            this.spl_1 = new System.Windows.Forms.SplitContainer();
            this.pnl_baoTrai = new System.Windows.Forms.Panel();
            this.btn_XoaTK = new System.Windows.Forms.Button();
            this.gr_Avarta = new System.Windows.Forms.GroupBox();
            this.pic_AnhDaiDien = new System.Windows.Forms.PictureBox();
            this.pnl_BaoPhai = new System.Windows.Forms.Panel();
            this.btn_DoiThongTin = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_DoiMK = new System.Windows.Forms.Button();
            this.rdB_Nu = new System.Windows.Forms.RadioButton();
            this.rdB_Nam = new System.Windows.Forms.RadioButton();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spl_1)).BeginInit();
            this.spl_1.Panel1.SuspendLayout();
            this.spl_1.Panel2.SuspendLayout();
            this.spl_1.SuspendLayout();
            this.pnl_baoTrai.SuspendLayout();
            this.gr_Avarta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhDaiDien)).BeginInit();
            this.pnl_BaoPhai.SuspendLayout();
            this.SuspendLayout();
            // 
            // spl_1
            // 
            this.spl_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl_1.Location = new System.Drawing.Point(0, 0);
            this.spl_1.Name = "spl_1";
            // 
            // spl_1.Panel1
            // 
            this.spl_1.Panel1.Controls.Add(this.pnl_baoTrai);
            // 
            // spl_1.Panel2
            // 
            this.spl_1.Panel2.Controls.Add(this.pnl_BaoPhai);
            this.spl_1.Size = new System.Drawing.Size(800, 345);
            this.spl_1.SplitterDistance = 303;
            this.spl_1.TabIndex = 0;
            // 
            // pnl_baoTrai
            // 
            this.pnl_baoTrai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_baoTrai.Controls.Add(this.btn_XoaTK);
            this.pnl_baoTrai.Controls.Add(this.gr_Avarta);
            this.pnl_baoTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_baoTrai.Location = new System.Drawing.Point(0, 0);
            this.pnl_baoTrai.Name = "pnl_baoTrai";
            this.pnl_baoTrai.Size = new System.Drawing.Size(303, 345);
            this.pnl_baoTrai.TabIndex = 1;
            // 
            // btn_XoaTK
            // 
            this.btn_XoaTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XoaTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_XoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTK.ForeColor = System.Drawing.Color.White;
            this.btn_XoaTK.Location = new System.Drawing.Point(0, 286);
            this.btn_XoaTK.Name = "btn_XoaTK";
            this.btn_XoaTK.Size = new System.Drawing.Size(301, 57);
            this.btn_XoaTK.TabIndex = 13;
            this.btn_XoaTK.Text = "XÓA TÀI KHOẢN";
            this.btn_XoaTK.UseVisualStyleBackColor = false;
            this.btn_XoaTK.Click += new System.EventHandler(this.btn_XoaTK_Click);
            // 
            // gr_Avarta
            // 
            this.gr_Avarta.Controls.Add(this.pic_AnhDaiDien);
            this.gr_Avarta.Location = new System.Drawing.Point(51, 38);
            this.gr_Avarta.Name = "gr_Avarta";
            this.gr_Avarta.Size = new System.Drawing.Size(200, 229);
            this.gr_Avarta.TabIndex = 0;
            this.gr_Avarta.TabStop = false;
            this.gr_Avarta.Text = "Ảnh Đại Diện";
            // 
            // pic_AnhDaiDien
            // 
            this.pic_AnhDaiDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_AnhDaiDien.Location = new System.Drawing.Point(3, 18);
            this.pic_AnhDaiDien.Name = "pic_AnhDaiDien";
            this.pic_AnhDaiDien.Size = new System.Drawing.Size(194, 208);
            this.pic_AnhDaiDien.TabIndex = 1;
            this.pic_AnhDaiDien.TabStop = false;
            // 
            // pnl_BaoPhai
            // 
            this.pnl_BaoPhai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_BaoPhai.Controls.Add(this.btn_DoiThongTin);
            this.pnl_BaoPhai.Controls.Add(this.btn_DangXuat);
            this.pnl_BaoPhai.Controls.Add(this.btn_DoiMK);
            this.pnl_BaoPhai.Controls.Add(this.rdB_Nu);
            this.pnl_BaoPhai.Controls.Add(this.rdB_Nam);
            this.pnl_BaoPhai.Controls.Add(this.txt_email);
            this.pnl_BaoPhai.Controls.Add(this.txt_HoTen);
            this.pnl_BaoPhai.Controls.Add(this.label4);
            this.pnl_BaoPhai.Controls.Add(this.label3);
            this.pnl_BaoPhai.Controls.Add(this.label1);
            this.pnl_BaoPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BaoPhai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_BaoPhai.Location = new System.Drawing.Point(0, 0);
            this.pnl_BaoPhai.Name = "pnl_BaoPhai";
            this.pnl_BaoPhai.Size = new System.Drawing.Size(493, 345);
            this.pnl_BaoPhai.TabIndex = 0;
            // 
            // btn_DoiThongTin
            // 
            this.btn_DoiThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiThongTin.Location = new System.Drawing.Point(165, 286);
            this.btn_DoiThongTin.Name = "btn_DoiThongTin";
            this.btn_DoiThongTin.Size = new System.Drawing.Size(156, 38);
            this.btn_DoiThongTin.TabIndex = 13;
            this.btn_DoiThongTin.Text = "ĐÔI THÔNG TIN";
            this.btn_DoiThongTin.UseVisualStyleBackColor = true;
            this.btn_DoiThongTin.Click += new System.EventHandler(this.btn_DoiThongTin_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Location = new System.Drawing.Point(324, 286);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(156, 38);
            this.btn_DangXuat.TabIndex = 12;
            this.btn_DangXuat.Text = "ĐĂNG XUẤT";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMK.Location = new System.Drawing.Point(3, 286);
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Size = new System.Drawing.Size(156, 38);
            this.btn_DoiMK.TabIndex = 11;
            this.btn_DoiMK.Text = "ĐỔI MẬT KHẨU";
            this.btn_DoiMK.UseVisualStyleBackColor = true;
            this.btn_DoiMK.Click += new System.EventHandler(this.btn_DoiMK_Click);
            // 
            // rdB_Nu
            // 
            this.rdB_Nu.AutoSize = true;
            this.rdB_Nu.Location = new System.Drawing.Point(324, 115);
            this.rdB_Nu.Name = "rdB_Nu";
            this.rdB_Nu.Size = new System.Drawing.Size(45, 20);
            this.rdB_Nu.TabIndex = 10;
            this.rdB_Nu.TabStop = true;
            this.rdB_Nu.Text = "Nữ";
            this.rdB_Nu.UseVisualStyleBackColor = true;
            // 
            // rdB_Nam
            // 
            this.rdB_Nam.AutoSize = true;
            this.rdB_Nam.Location = new System.Drawing.Point(174, 115);
            this.rdB_Nam.Name = "rdB_Nam";
            this.rdB_Nam.Size = new System.Drawing.Size(57, 20);
            this.rdB_Nam.TabIndex = 9;
            this.rdB_Nam.TabStop = true;
            this.rdB_Nam.Text = "Nam";
            this.rdB_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(185, 177);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(244, 22);
            this.txt_email.TabIndex = 7;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(185, 46);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(244, 22);
            this.txt_HoTen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // FormCTTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.spl_1);
            this.Name = "FormCTTaiKhoan";
            this.Text = "FormCTTaiKhoan";
            this.spl_1.Panel1.ResumeLayout(false);
            this.spl_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spl_1)).EndInit();
            this.spl_1.ResumeLayout(false);
            this.pnl_baoTrai.ResumeLayout(false);
            this.gr_Avarta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhDaiDien)).EndInit();
            this.pnl_BaoPhai.ResumeLayout(false);
            this.pnl_BaoPhai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spl_1;
        private System.Windows.Forms.GroupBox gr_Avarta;
        private System.Windows.Forms.PictureBox pic_AnhDaiDien;
        private System.Windows.Forms.Panel pnl_baoTrai;
        private System.Windows.Forms.Panel pnl_BaoPhai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdB_Nu;
        private System.Windows.Forms.RadioButton rdB_Nam;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Button btn_XoaTK;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_DoiMK;
        private System.Windows.Forms.Button btn_DoiThongTin;
    }
}