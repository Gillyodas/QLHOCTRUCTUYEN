namespace QLHOCTRUCTUYEN
{
    partial class FormDangKy
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReEnterPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnChuyenSangFormDN = new System.Windows.Forms.Button();
            this.lblUnvalidEmail = new System.Windows.Forms.Label();
            this.lblUnvalidPass = new System.Windows.Forms.Label();
            this.lblUnvalidReEnterPass = new System.Windows.Forms.Label();
            this.lblBatBuocHoTen = new System.Windows.Forms.Label();
            this.lblQuenMK = new System.Windows.Forms.Label();
            this.panDangKy = new System.Windows.Forms.Panel();
            this.panDangNhap = new System.Windows.Forms.Panel();
            this.lblUnvalidPassDN = new System.Windows.Forms.Label();
            this.lblUnvalidEmailDN = new System.Windows.Forms.Label();
            this.lblQuenMatKhauDN = new System.Windows.Forms.Label();
            this.btnDangNhapDN = new System.Windows.Forms.Button();
            this.btnChuyenSangFormDK = new System.Windows.Forms.Button();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.txtPassDN = new System.Windows.Forms.TextBox();
            this.lblMatKhauDN = new System.Windows.Forms.Label();
            this.txtEmailDN = new System.Windows.Forms.TextBox();
            this.lblEmailDN = new System.Windows.Forms.Label();
            this.panDangKy.SuspendLayout();
            this.panDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(113, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Đăng ký";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(141, 55);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(129, 22);
            this.txtHoTen.TabIndex = 5;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTenIsValid);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 22);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmailIsValid);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(141, 139);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(129, 22);
            this.txtPass.TabIndex = 9;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPassIsValid);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu";
            // 
            // txtReEnterPass
            // 
            this.txtReEnterPass.Location = new System.Drawing.Point(141, 185);
            this.txtReEnterPass.Name = "txtReEnterPass";
            this.txtReEnterPass.PasswordChar = '*';
            this.txtReEnterPass.Size = new System.Drawing.Size(129, 22);
            this.txtReEnterPass.TabIndex = 11;
            this.txtReEnterPass.TextChanged += new System.EventHandler(this.txtReEnterPassIsValid);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhập lại";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(187, 241);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(101, 39);
            this.btnDangKy.TabIndex = 12;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnChuyenSangFormDN
            // 
            this.btnChuyenSangFormDN.Location = new System.Drawing.Point(81, 241);
            this.btnChuyenSangFormDN.Name = "btnChuyenSangFormDN";
            this.btnChuyenSangFormDN.Size = new System.Drawing.Size(92, 39);
            this.btnChuyenSangFormDN.TabIndex = 13;
            this.btnChuyenSangFormDN.Text = "Đăng nhập";
            this.btnChuyenSangFormDN.UseVisualStyleBackColor = true;
            this.btnChuyenSangFormDN.Click += new System.EventHandler(this.btnChuyenSangFormDN_Click);
            // 
            // lblUnvalidEmail
            // 
            this.lblUnvalidEmail.AutoSize = true;
            this.lblUnvalidEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnvalidEmail.Location = new System.Drawing.Point(277, 100);
            this.lblUnvalidEmail.Name = "lblUnvalidEmail";
            this.lblUnvalidEmail.Size = new System.Drawing.Size(12, 16);
            this.lblUnvalidEmail.TabIndex = 14;
            this.lblUnvalidEmail.Text = "*";
            // 
            // lblUnvalidPass
            // 
            this.lblUnvalidPass.AutoSize = true;
            this.lblUnvalidPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnvalidPass.Location = new System.Drawing.Point(276, 145);
            this.lblUnvalidPass.Name = "lblUnvalidPass";
            this.lblUnvalidPass.Size = new System.Drawing.Size(12, 16);
            this.lblUnvalidPass.TabIndex = 15;
            this.lblUnvalidPass.Text = "*";
            // 
            // lblUnvalidReEnterPass
            // 
            this.lblUnvalidReEnterPass.AutoSize = true;
            this.lblUnvalidReEnterPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnvalidReEnterPass.Location = new System.Drawing.Point(277, 191);
            this.lblUnvalidReEnterPass.Name = "lblUnvalidReEnterPass";
            this.lblUnvalidReEnterPass.Size = new System.Drawing.Size(12, 16);
            this.lblUnvalidReEnterPass.TabIndex = 16;
            this.lblUnvalidReEnterPass.Text = "*";
            // 
            // lblBatBuocHoTen
            // 
            this.lblBatBuocHoTen.AutoSize = true;
            this.lblBatBuocHoTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBatBuocHoTen.Location = new System.Drawing.Point(277, 61);
            this.lblBatBuocHoTen.Name = "lblBatBuocHoTen";
            this.lblBatBuocHoTen.Size = new System.Drawing.Size(12, 16);
            this.lblBatBuocHoTen.TabIndex = 17;
            this.lblBatBuocHoTen.Text = "*";
            // 
            // lblQuenMK
            // 
            this.lblQuenMK.AutoSize = true;
            this.lblQuenMK.Location = new System.Drawing.Point(193, 222);
            this.lblQuenMK.Name = "lblQuenMK";
            this.lblQuenMK.Size = new System.Drawing.Size(96, 16);
            this.lblQuenMK.TabIndex = 18;
            this.lblQuenMK.Text = "Quên mật khẩu";
            this.lblQuenMK.Click += new System.EventHandler(this.lblQuenMK_Click);
            // 
            // panDangKy
            // 
            this.panDangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDangKy.Controls.Add(this.lblTitle);
            this.panDangKy.Controls.Add(this.lblQuenMK);
            this.panDangKy.Controls.Add(this.label3);
            this.panDangKy.Controls.Add(this.lblBatBuocHoTen);
            this.panDangKy.Controls.Add(this.txtHoTen);
            this.panDangKy.Controls.Add(this.lblUnvalidReEnterPass);
            this.panDangKy.Controls.Add(this.label1);
            this.panDangKy.Controls.Add(this.lblUnvalidPass);
            this.panDangKy.Controls.Add(this.txtEmail);
            this.panDangKy.Controls.Add(this.lblUnvalidEmail);
            this.panDangKy.Controls.Add(this.label4);
            this.panDangKy.Controls.Add(this.btnChuyenSangFormDN);
            this.panDangKy.Controls.Add(this.txtPass);
            this.panDangKy.Controls.Add(this.btnDangKy);
            this.panDangKy.Controls.Add(this.label5);
            this.panDangKy.Controls.Add(this.txtReEnterPass);
            this.panDangKy.Location = new System.Drawing.Point(12, 12);
            this.panDangKy.Name = "panDangKy";
            this.panDangKy.Size = new System.Drawing.Size(365, 379);
            this.panDangKy.TabIndex = 19;
            // 
            // panDangNhap
            // 
            this.panDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDangNhap.Controls.Add(this.lblUnvalidPassDN);
            this.panDangNhap.Controls.Add(this.lblUnvalidEmailDN);
            this.panDangNhap.Controls.Add(this.lblQuenMatKhauDN);
            this.panDangNhap.Controls.Add(this.btnDangNhapDN);
            this.panDangNhap.Controls.Add(this.btnChuyenSangFormDK);
            this.panDangNhap.Controls.Add(this.lblDangNhap);
            this.panDangNhap.Controls.Add(this.txtPassDN);
            this.panDangNhap.Controls.Add(this.lblMatKhauDN);
            this.panDangNhap.Controls.Add(this.txtEmailDN);
            this.panDangNhap.Controls.Add(this.lblEmailDN);
            this.panDangNhap.Location = new System.Drawing.Point(12, 12);
            this.panDangNhap.Name = "panDangNhap";
            this.panDangNhap.Size = new System.Drawing.Size(365, 379);
            this.panDangNhap.TabIndex = 20;
            // 
            // lblUnvalidPassDN
            // 
            this.lblUnvalidPassDN.AutoSize = true;
            this.lblUnvalidPassDN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnvalidPassDN.Location = new System.Drawing.Point(289, 118);
            this.lblUnvalidPassDN.Name = "lblUnvalidPassDN";
            this.lblUnvalidPassDN.Size = new System.Drawing.Size(12, 16);
            this.lblUnvalidPassDN.TabIndex = 27;
            this.lblUnvalidPassDN.Text = "*";
            // 
            // lblUnvalidEmailDN
            // 
            this.lblUnvalidEmailDN.AutoSize = true;
            this.lblUnvalidEmailDN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnvalidEmailDN.Location = new System.Drawing.Point(289, 74);
            this.lblUnvalidEmailDN.Name = "lblUnvalidEmailDN";
            this.lblUnvalidEmailDN.Size = new System.Drawing.Size(12, 16);
            this.lblUnvalidEmailDN.TabIndex = 26;
            this.lblUnvalidEmailDN.Text = "*";
            // 
            // lblQuenMatKhauDN
            // 
            this.lblQuenMatKhauDN.AutoSize = true;
            this.lblQuenMatKhauDN.Location = new System.Drawing.Point(178, 206);
            this.lblQuenMatKhauDN.Name = "lblQuenMatKhauDN";
            this.lblQuenMatKhauDN.Size = new System.Drawing.Size(96, 16);
            this.lblQuenMatKhauDN.TabIndex = 25;
            this.lblQuenMatKhauDN.Text = "Quên mật khẩu";
            // 
            // btnDangNhapDN
            // 
            this.btnDangNhapDN.Location = new System.Drawing.Point(85, 241);
            this.btnDangNhapDN.Name = "btnDangNhapDN";
            this.btnDangNhapDN.Size = new System.Drawing.Size(90, 39);
            this.btnDangNhapDN.TabIndex = 24;
            this.btnDangNhapDN.Text = "Đăng nhập";
            this.btnDangNhapDN.UseVisualStyleBackColor = true;
            this.btnDangNhapDN.Click += new System.EventHandler(this.btnDangNhapDN_Click);
            // 
            // btnChuyenSangFormDK
            // 
            this.btnChuyenSangFormDK.Location = new System.Drawing.Point(181, 241);
            this.btnChuyenSangFormDK.Name = "btnChuyenSangFormDK";
            this.btnChuyenSangFormDK.Size = new System.Drawing.Size(93, 39);
            this.btnChuyenSangFormDK.TabIndex = 23;
            this.btnChuyenSangFormDK.Text = "Đăng ký";
            this.btnChuyenSangFormDK.UseVisualStyleBackColor = true;
            this.btnChuyenSangFormDK.Click += new System.EventHandler(this.btnChuyenSangFormDK_Click);
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.Location = new System.Drawing.Point(114, 17);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(132, 29);
            this.lblDangNhap.TabIndex = 22;
            this.lblDangNhap.Text = "Đăng nhập";
            this.lblDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassDN
            // 
            this.txtPassDN.Location = new System.Drawing.Point(145, 112);
            this.txtPassDN.Name = "txtPassDN";
            this.txtPassDN.PasswordChar = '*';
            this.txtPassDN.Size = new System.Drawing.Size(129, 22);
            this.txtPassDN.TabIndex = 21;
            this.txtPassDN.TextChanged += new System.EventHandler(this.txtPassDN_TextChanged);
            // 
            // lblMatKhauDN
            // 
            this.lblMatKhauDN.AutoSize = true;
            this.lblMatKhauDN.Location = new System.Drawing.Point(82, 118);
            this.lblMatKhauDN.Name = "lblMatKhauDN";
            this.lblMatKhauDN.Size = new System.Drawing.Size(61, 16);
            this.lblMatKhauDN.TabIndex = 20;
            this.lblMatKhauDN.Text = "Mật khẩu";
            // 
            // txtEmailDN
            // 
            this.txtEmailDN.Location = new System.Drawing.Point(145, 68);
            this.txtEmailDN.Name = "txtEmailDN";
            this.txtEmailDN.Size = new System.Drawing.Size(129, 22);
            this.txtEmailDN.TabIndex = 19;
            this.txtEmailDN.TextChanged += new System.EventHandler(this.txtEmailDN_TextChanged);
            // 
            // lblEmailDN
            // 
            this.lblEmailDN.AutoSize = true;
            this.lblEmailDN.Location = new System.Drawing.Point(82, 74);
            this.lblEmailDN.Name = "lblEmailDN";
            this.lblEmailDN.Size = new System.Drawing.Size(41, 16);
            this.lblEmailDN.TabIndex = 18;
            this.lblEmailDN.Text = "Email";
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 913);
            this.Controls.Add(this.panDangNhap);
            this.Controls.Add(this.panDangKy);
            this.Name = "FormDangKy";
            this.Text = "FormDangKy";
            this.panDangKy.ResumeLayout(false);
            this.panDangKy.PerformLayout();
            this.panDangNhap.ResumeLayout(false);
            this.panDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReEnterPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnChuyenSangFormDN;
        private System.Windows.Forms.Label lblUnvalidEmail;
        private System.Windows.Forms.Label lblUnvalidPass;
        private System.Windows.Forms.Label lblUnvalidReEnterPass;
        private System.Windows.Forms.Label lblBatBuocHoTen;
        private System.Windows.Forms.Label lblQuenMK;
        private System.Windows.Forms.Panel panDangKy;
        private System.Windows.Forms.Panel panDangNhap;
        private System.Windows.Forms.Label lblUnvalidPassDN;
        private System.Windows.Forms.Label lblUnvalidEmailDN;
        private System.Windows.Forms.Label lblQuenMatKhauDN;
        private System.Windows.Forms.Button btnDangNhapDN;
        private System.Windows.Forms.Button btnChuyenSangFormDK;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.TextBox txtPassDN;
        private System.Windows.Forms.Label lblMatKhauDN;
        private System.Windows.Forms.TextBox txtEmailDN;
        private System.Windows.Forms.Label lblEmailDN;
    }
}