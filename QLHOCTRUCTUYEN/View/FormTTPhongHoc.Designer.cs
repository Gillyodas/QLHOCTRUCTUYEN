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
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.btn_ThayDoi = new System.Windows.Forms.Button();
            this.btn_ThoatPhongHoc = new System.Windows.Forms.Button();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Main.Controls.Add(this.txt_MoTa);
            this.pnl_Main.Controls.Add(this.txt_Ten);
            this.pnl_Main.Controls.Add(this.label3);
            this.pnl_Main.Controls.Add(this.label2);
            this.pnl_Main.Controls.Add(this.label1);
            this.pnl_Main.Controls.Add(this.txt_MaPhong);
            this.pnl_Main.ForeColor = System.Drawing.Color.Gray;
            this.pnl_Main.Location = new System.Drawing.Point(24, 23);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(394, 263);
            this.pnl_Main.TabIndex = 0;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(145, 139);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(215, 22);
            this.txt_MoTa.TabIndex = 5;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(145, 72);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(215, 22);
            this.txt_Ten.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "MÔ TẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "TÊN LỚP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÃ PHÒNG";
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Enabled = false;
            this.txt_MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaPhong.Location = new System.Drawing.Point(145, 8);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.ReadOnly = true;
            this.txt_MaPhong.Size = new System.Drawing.Size(215, 30);
            this.txt_MaPhong.TabIndex = 0;
            // 
            // btn_ThayDoi
            // 
            this.btn_ThayDoi.Location = new System.Drawing.Point(283, 295);
            this.btn_ThayDoi.Name = "btn_ThayDoi";
            this.btn_ThayDoi.Size = new System.Drawing.Size(135, 38);
            this.btn_ThayDoi.TabIndex = 1;
            this.btn_ThayDoi.Text = "Thay đổi";
            this.btn_ThayDoi.UseVisualStyleBackColor = true;
            this.btn_ThayDoi.Click += new System.EventHandler(this.btn_ThayDoi_Click);
            // 
            // btn_ThoatPhongHoc
            // 
            this.btn_ThoatPhongHoc.Location = new System.Drawing.Point(142, 295);
            this.btn_ThoatPhongHoc.Name = "btn_ThoatPhongHoc";
            this.btn_ThoatPhongHoc.Size = new System.Drawing.Size(135, 38);
            this.btn_ThoatPhongHoc.TabIndex = 2;
            this.btn_ThoatPhongHoc.Text = "Thoát";
            this.btn_ThoatPhongHoc.UseVisualStyleBackColor = true;
            this.btn_ThoatPhongHoc.Click += new System.EventHandler(this.btn_ThoatPhongHoc_Click);
            // 
            // FormTTPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 345);
            this.Controls.Add(this.btn_ThoatPhongHoc);
            this.Controls.Add(this.btn_ThayDoi);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.Button btn_ThayDoi;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Button btn_ThoatPhongHoc;
    }
}