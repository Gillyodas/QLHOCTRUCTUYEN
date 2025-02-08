namespace QLHOCTRUCTUYEN.View
{
    partial class FormCTTaoBaiTap
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
            this.txt_TieuDe = new System.Windows.Forms.TextBox();
            this.dtp_HanBT = new System.Windows.Forms.DateTimePicker();
            this.grp_TieuDe = new System.Windows.Forms.GroupBox();
            this.lbl_NgayDang = new System.Windows.Forms.Label();
            this.lbl_HanBT = new System.Windows.Forms.Label();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_XacNhanTaoBT = new System.Windows.Forms.Button();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.dtp_NgayDang = new System.Windows.Forms.DateTimePicker();
            this.cbb_LoaiTaiNguyen = new System.Windows.Forms.ComboBox();
            this.lbl_LoauTaiNguyen = new System.Windows.Forms.Label();
            this.grp_TieuDe.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_TieuDe
            // 
            this.txt_TieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TieuDe.Location = new System.Drawing.Point(3, 18);
            this.txt_TieuDe.Name = "txt_TieuDe";
            this.txt_TieuDe.Size = new System.Drawing.Size(695, 30);
            this.txt_TieuDe.TabIndex = 0;
            // 
            // dtp_HanBT
            // 
            this.dtp_HanBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_HanBT.Location = new System.Drawing.Point(357, 36);
            this.dtp_HanBT.Name = "dtp_HanBT";
            this.dtp_HanBT.Size = new System.Drawing.Size(299, 27);
            this.dtp_HanBT.TabIndex = 2;
            // 
            // grp_TieuDe
            // 
            this.grp_TieuDe.Controls.Add(this.txt_TieuDe);
            this.grp_TieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TieuDe.Location = new System.Drawing.Point(0, 0);
            this.grp_TieuDe.Name = "grp_TieuDe";
            this.grp_TieuDe.Size = new System.Drawing.Size(701, 58);
            this.grp_TieuDe.TabIndex = 3;
            this.grp_TieuDe.TabStop = false;
            this.grp_TieuDe.Text = "Tiêu Đề";
            // 
            // lbl_NgayDang
            // 
            this.lbl_NgayDang.AutoSize = true;
            this.lbl_NgayDang.Location = new System.Drawing.Point(8, 17);
            this.lbl_NgayDang.Name = "lbl_NgayDang";
            this.lbl_NgayDang.Size = new System.Drawing.Size(75, 16);
            this.lbl_NgayDang.TabIndex = 4;
            this.lbl_NgayDang.Text = "Ngày Đăng";
            // 
            // lbl_HanBT
            // 
            this.lbl_HanBT.AutoSize = true;
            this.lbl_HanBT.Location = new System.Drawing.Point(354, 17);
            this.lbl_HanBT.Name = "lbl_HanBT";
            this.lbl_HanBT.Size = new System.Drawing.Size(110, 16);
            this.lbl_HanBT.TabIndex = 5;
            this.lbl_HanBT.Text = "Hạn Của Bài Tập";
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Location = new System.Drawing.Point(27, 135);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(46, 16);
            this.lbl_MoTa.TabIndex = 6;
            this.lbl_MoTa.Text = "Mô Tả";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_LoauTaiNguyen);
            this.panel1.Controls.Add(this.cbb_LoaiTaiNguyen);
            this.panel1.Controls.Add(this.dtp_NgayDang);
            this.panel1.Controls.Add(this.btn_XacNhanTaoBT);
            this.panel1.Controls.Add(this.txt_MoTa);
            this.panel1.Controls.Add(this.lbl_MoTa);
            this.panel1.Controls.Add(this.lbl_HanBT);
            this.panel1.Controls.Add(this.lbl_NgayDang);
            this.panel1.Controls.Add(this.dtp_HanBT);
            this.panel1.Location = new System.Drawing.Point(19, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 281);
            this.panel1.TabIndex = 7;
            // 
            // btn_XacNhanTaoBT
            // 
            this.btn_XacNhanTaoBT.Location = new System.Drawing.Point(581, 227);
            this.btn_XacNhanTaoBT.Name = "btn_XacNhanTaoBT";
            this.btn_XacNhanTaoBT.Size = new System.Drawing.Size(75, 37);
            this.btn_XacNhanTaoBT.TabIndex = 8;
            this.btn_XacNhanTaoBT.Text = "Xác nhận";
            this.btn_XacNhanTaoBT.UseVisualStyleBackColor = true;
            this.btn_XacNhanTaoBT.Click += new System.EventHandler(this.btn_XacNhanTaoBT_Click);
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(30, 163);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(530, 101);
            this.txt_MoTa.TabIndex = 7;
            // 
            // dtp_NgayDang
            // 
            this.dtp_NgayDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayDang.Location = new System.Drawing.Point(11, 36);
            this.dtp_NgayDang.Name = "dtp_NgayDang";
            this.dtp_NgayDang.Size = new System.Drawing.Size(299, 27);
            this.dtp_NgayDang.TabIndex = 9;
            // 
            // cbb_LoaiTaiNguyen
            // 
            this.cbb_LoaiTaiNguyen.FormattingEnabled = true;
            this.cbb_LoaiTaiNguyen.Location = new System.Drawing.Point(357, 109);
            this.cbb_LoaiTaiNguyen.Name = "cbb_LoaiTaiNguyen";
            this.cbb_LoaiTaiNguyen.Size = new System.Drawing.Size(121, 24);
            this.cbb_LoaiTaiNguyen.TabIndex = 10;
            // 
            // lbl_LoauTaiNguyen
            // 
            this.lbl_LoauTaiNguyen.AutoSize = true;
            this.lbl_LoauTaiNguyen.Location = new System.Drawing.Point(354, 90);
            this.lbl_LoauTaiNguyen.Name = "lbl_LoauTaiNguyen";
            this.lbl_LoauTaiNguyen.Size = new System.Drawing.Size(97, 16);
            this.lbl_LoauTaiNguyen.TabIndex = 11;
            this.lbl_LoauTaiNguyen.Text = "Loại tài nguyên";
            // 
            // FormCTTaoBaiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 356);
            this.Controls.Add(this.grp_TieuDe);
            this.Controls.Add(this.panel1);
            this.Name = "FormCTTaoBaiTap";
            this.Text = "FormCTTaoBaiTap";
            this.grp_TieuDe.ResumeLayout(false);
            this.grp_TieuDe.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TieuDe;
        private System.Windows.Forms.DateTimePicker dtp_HanBT;
        private System.Windows.Forms.GroupBox grp_TieuDe;
        private System.Windows.Forms.Label lbl_NgayDang;
        private System.Windows.Forms.Label lbl_HanBT;
        private System.Windows.Forms.Label lbl_MoTa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.Button btn_XacNhanTaoBT;
        private System.Windows.Forms.DateTimePicker dtp_NgayDang;
        private System.Windows.Forms.Label lbl_LoauTaiNguyen;
        private System.Windows.Forms.ComboBox cbb_LoaiTaiNguyen;
    }
}