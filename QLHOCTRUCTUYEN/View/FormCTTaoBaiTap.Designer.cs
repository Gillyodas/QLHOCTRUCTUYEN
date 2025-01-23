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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_NgayDang = new System.Windows.Forms.TextBox();
            this.dtp_HanBT = new System.Windows.Forms.DateTimePicker();
            this.grp_TieuDe = new System.Windows.Forms.GroupBox();
            this.lbl_NgayDang = new System.Windows.Forms.Label();
            this.lbl_HanBT = new System.Windows.Forms.Label();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.grp_TieuDe.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(695, 30);
            this.textBox1.TabIndex = 0;
            // 
            // txt_NgayDang
            // 
            this.txt_NgayDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayDang.Location = new System.Drawing.Point(30, 50);
            this.txt_NgayDang.Name = "txt_NgayDang";
            this.txt_NgayDang.ReadOnly = true;
            this.txt_NgayDang.Size = new System.Drawing.Size(186, 27);
            this.txt_NgayDang.TabIndex = 1;
            // 
            // dtp_HanBT
            // 
            this.dtp_HanBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_HanBT.Location = new System.Drawing.Point(316, 48);
            this.dtp_HanBT.Name = "dtp_HanBT";
            this.dtp_HanBT.Size = new System.Drawing.Size(299, 27);
            this.dtp_HanBT.TabIndex = 2;
            // 
            // grp_TieuDe
            // 
            this.grp_TieuDe.Controls.Add(this.textBox1);
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
            this.lbl_NgayDang.Location = new System.Drawing.Point(27, 17);
            this.lbl_NgayDang.Name = "lbl_NgayDang";
            this.lbl_NgayDang.Size = new System.Drawing.Size(75, 16);
            this.lbl_NgayDang.TabIndex = 4;
            this.lbl_NgayDang.Text = "Ngày Đăng";
            // 
            // lbl_HanBT
            // 
            this.lbl_HanBT.AutoSize = true;
            this.lbl_HanBT.Location = new System.Drawing.Point(313, 17);
            this.lbl_HanBT.Name = "lbl_HanBT";
            this.lbl_HanBT.Size = new System.Drawing.Size(110, 16);
            this.lbl_HanBT.TabIndex = 5;
            this.lbl_HanBT.Text = "Hạn Của Bài Tập";
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Location = new System.Drawing.Point(27, 117);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(46, 16);
            this.lbl_MoTa.TabIndex = 6;
            this.lbl_MoTa.Text = "Mô Tả";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_MoTa);
            this.panel1.Controls.Add(this.lbl_MoTa);
            this.panel1.Controls.Add(this.txt_NgayDang);
            this.panel1.Controls.Add(this.lbl_HanBT);
            this.panel1.Controls.Add(this.lbl_NgayDang);
            this.panel1.Controls.Add(this.dtp_HanBT);
            this.panel1.Location = new System.Drawing.Point(19, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 281);
            this.panel1.TabIndex = 7;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(30, 155);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(584, 109);
            this.txt_MoTa.TabIndex = 7;
            // 
            // FormCTTaoBaiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 357);
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

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_NgayDang;
        private System.Windows.Forms.DateTimePicker dtp_HanBT;
        private System.Windows.Forms.GroupBox grp_TieuDe;
        private System.Windows.Forms.Label lbl_NgayDang;
        private System.Windows.Forms.Label lbl_HanBT;
        private System.Windows.Forms.Label lbl_MoTa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_MoTa;
    }
}