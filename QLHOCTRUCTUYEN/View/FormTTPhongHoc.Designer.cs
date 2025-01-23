namespace QLHOCTRUCTUYEN.View
{
    partial class FormTTPhongHoc
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
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Main.Controls.Add(this.txt_MoTa);
            this.pnl_Main.Controls.Add(this.txt_TenLop);
            this.pnl_Main.Controls.Add(this.label3);
            this.pnl_Main.Controls.Add(this.label2);
            this.pnl_Main.Controls.Add(this.label1);
            this.pnl_Main.Controls.Add(this.txt_MaPhong);
            this.pnl_Main.ForeColor = System.Drawing.Color.Gray;
            this.pnl_Main.Location = new System.Drawing.Point(24, 23);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(559, 403);
            this.pnl_Main.TabIndex = 0;
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaPhong.Location = new System.Drawing.Point(203, 83);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.ReadOnly = true;
            this.txt_MaPhong.Size = new System.Drawing.Size(215, 30);
            this.txt_MaPhong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÃ PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "TÊN LỚP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "MÔ TẢ";
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(203, 144);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.ReadOnly = true;
            this.txt_TenLop.Size = new System.Drawing.Size(215, 22);
            this.txt_TenLop.TabIndex = 4;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(203, 217);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.ReadOnly = true;
            this.txt_MoTa.Size = new System.Drawing.Size(215, 149);
            this.txt_MoTa.TabIndex = 5;
            // 
            // FormTTPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.pnl_Main);
            this.Name = "FormTTPhongHoc";
            this.Text = "FormTTPhongHoc";
            this.Load += new System.EventHandler(this.FormTTPhongHoc_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaPhong;
    }
}