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
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblUnvalidEmail = new System.Windows.Forms.Label();
            this.lblUnvalidPass = new System.Windows.Forms.Label();
            this.lblUnvalidReEnterPass = new System.Windows.Forms.Label();
            this.lblBatBuocHoTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(80, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Đăng ký";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(108, 48);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(129, 22);
            this.txtHoTen.TabIndex = 5;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTenIsValid);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 22);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmailIsValid);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(108, 132);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(129, 22);
            this.txtPass.TabIndex = 9;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPassIsValid);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu";
            // 
            // txtReEnterPass
            // 
            this.txtReEnterPass.Location = new System.Drawing.Point(108, 178);
            this.txtReEnterPass.Name = "txtReEnterPass";
            this.txtReEnterPass.Size = new System.Drawing.Size(129, 22);
            this.txtReEnterPass.TabIndex = 11;
            this.txtReEnterPass.TextChanged += new System.EventHandler(this.txtReEnterPassIsValid);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhập lại";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(144, 234);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(93, 39);
            this.btnDangKy.TabIndex = 12;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(48, 234);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(90, 39);
            this.btnDangNhap.TabIndex = 13;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // lblUnvalidEmail
            // 
            this.lblUnvalidEmail.AutoSize = true;
            this.lblUnvalidEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnvalidEmail.Location = new System.Drawing.Point(244, 93);
            this.lblUnvalidEmail.Name = "lblUnvalidEmail";
            this.lblUnvalidEmail.Size = new System.Drawing.Size(12, 16);
            this.lblUnvalidEmail.TabIndex = 14;
            this.lblUnvalidEmail.Text = "*";
            // 
            // lblUnvalidPass
            // 
            this.lblUnvalidPass.AutoSize = true;
            this.lblUnvalidPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnvalidPass.Location = new System.Drawing.Point(243, 138);
            this.lblUnvalidPass.Name = "lblUnvalidPass";
            this.lblUnvalidPass.Size = new System.Drawing.Size(12, 16);
            this.lblUnvalidPass.TabIndex = 15;
            this.lblUnvalidPass.Text = "*";
            // 
            // lblUnvalidReEnterPass
            // 
            this.lblUnvalidReEnterPass.AutoSize = true;
            this.lblUnvalidReEnterPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnvalidReEnterPass.Location = new System.Drawing.Point(244, 184);
            this.lblUnvalidReEnterPass.Name = "lblUnvalidReEnterPass";
            this.lblUnvalidReEnterPass.Size = new System.Drawing.Size(12, 16);
            this.lblUnvalidReEnterPass.TabIndex = 16;
            this.lblUnvalidReEnterPass.Text = "*";
            // 
            // lblBatBuocHoTen
            // 
            this.lblBatBuocHoTen.AutoSize = true;
            this.lblBatBuocHoTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBatBuocHoTen.Location = new System.Drawing.Point(244, 54);
            this.lblBatBuocHoTen.Name = "lblBatBuocHoTen";
            this.lblBatBuocHoTen.Size = new System.Drawing.Size(12, 16);
            this.lblBatBuocHoTen.TabIndex = 17;
            this.lblBatBuocHoTen.Text = "*";
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 285);
            this.Controls.Add(this.lblBatBuocHoTen);
            this.Controls.Add(this.lblUnvalidReEnterPass);
            this.Controls.Add(this.lblUnvalidPass);
            this.Controls.Add(this.lblUnvalidEmail);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtReEnterPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormDangKy";
            this.Text = "FormDangKy";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblUnvalidEmail;
        private System.Windows.Forms.Label lblUnvalidPass;
        private System.Windows.Forms.Label lblUnvalidReEnterPass;
        private System.Windows.Forms.Label lblBatBuocHoTen;
    }
}