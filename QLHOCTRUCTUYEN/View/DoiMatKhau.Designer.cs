namespace QLHOCTRUCTUYEN.View
{
    partial class DoiMatKhau
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
            this.lbl_Matkhau = new System.Windows.Forms.Label();
            this.lbl_Matkhaumoi = new System.Windows.Forms.Label();
            this.lbl_XacnhanMK = new System.Windows.Forms.Label();
            this.txt_Matkhaumoi = new System.Windows.Forms.TextBox();
            this.txt_Matkhau = new System.Windows.Forms.TextBox();
            this.txt_XacnhanMK = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Matkhau
            // 
            this.lbl_Matkhau.AutoSize = true;
            this.lbl_Matkhau.Location = new System.Drawing.Point(25, 18);
            this.lbl_Matkhau.Name = "lbl_Matkhau";
            this.lbl_Matkhau.Size = new System.Drawing.Size(61, 16);
            this.lbl_Matkhau.TabIndex = 1;
            this.lbl_Matkhau.Text = "Mật khẩu";
            // 
            // lbl_Matkhaumoi
            // 
            this.lbl_Matkhaumoi.AutoSize = true;
            this.lbl_Matkhaumoi.Location = new System.Drawing.Point(25, 64);
            this.lbl_Matkhaumoi.Name = "lbl_Matkhaumoi";
            this.lbl_Matkhaumoi.Size = new System.Drawing.Size(86, 16);
            this.lbl_Matkhaumoi.TabIndex = 2;
            this.lbl_Matkhaumoi.Text = "Mật khẩu mới";
            // 
            // lbl_XacnhanMK
            // 
            this.lbl_XacnhanMK.AutoSize = true;
            this.lbl_XacnhanMK.Location = new System.Drawing.Point(25, 112);
            this.lbl_XacnhanMK.Name = "lbl_XacnhanMK";
            this.lbl_XacnhanMK.Size = new System.Drawing.Size(144, 16);
            this.lbl_XacnhanMK.TabIndex = 3;
            this.lbl_XacnhanMK.Text = "Xác nhận mật khẩu mới";
            // 
            // txt_Matkhaumoi
            // 
            this.txt_Matkhaumoi.Location = new System.Drawing.Point(196, 64);
            this.txt_Matkhaumoi.Name = "txt_Matkhaumoi";
            this.txt_Matkhaumoi.PasswordChar = '*';
            this.txt_Matkhaumoi.Size = new System.Drawing.Size(175, 22);
            this.txt_Matkhaumoi.TabIndex = 4;
            // 
            // txt_Matkhau
            // 
            this.txt_Matkhau.Location = new System.Drawing.Point(196, 12);
            this.txt_Matkhau.Name = "txt_Matkhau";
            this.txt_Matkhau.PasswordChar = '*';
            this.txt_Matkhau.Size = new System.Drawing.Size(175, 22);
            this.txt_Matkhau.TabIndex = 6;
            // 
            // txt_XacnhanMK
            // 
            this.txt_XacnhanMK.Location = new System.Drawing.Point(196, 106);
            this.txt_XacnhanMK.Name = "txt_XacnhanMK";
            this.txt_XacnhanMK.PasswordChar = '*';
            this.txt_XacnhanMK.Size = new System.Drawing.Size(175, 22);
            this.txt_XacnhanMK.TabIndex = 7;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(245, 149);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(126, 45);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 209);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_XacnhanMK);
            this.Controls.Add(this.txt_Matkhau);
            this.Controls.Add(this.txt_Matkhaumoi);
            this.Controls.Add(this.lbl_XacnhanMK);
            this.Controls.Add(this.lbl_Matkhaumoi);
            this.Controls.Add(this.lbl_Matkhau);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Matkhau;
        private System.Windows.Forms.Label lbl_Matkhaumoi;
        private System.Windows.Forms.Label lbl_XacnhanMK;
        private System.Windows.Forms.TextBox txt_Matkhaumoi;
        private System.Windows.Forms.TextBox txt_Matkhau;
        private System.Windows.Forms.TextBox txt_XacnhanMK;
        private System.Windows.Forms.Button btn_Luu;
    }
}