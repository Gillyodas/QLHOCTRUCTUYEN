namespace QLHOCTRUCTUYEN.View
{
    partial class FormCTBaiTap
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
            this.lbl_NgayDang = new System.Windows.Forms.Label();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_NgayDang = new System.Windows.Forms.DateTimePicker();
            this.dtp_ThoiHan = new System.Windows.Forms.DateTimePicker();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NgayDang
            // 
            this.lbl_NgayDang.AutoSize = true;
            this.lbl_NgayDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayDang.Location = new System.Drawing.Point(18, 73);
            this.lbl_NgayDang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayDang.Name = "lbl_NgayDang";
            this.lbl_NgayDang.Size = new System.Drawing.Size(107, 20);
            this.lbl_NgayDang.TabIndex = 0;
            this.lbl_NgayDang.Text = "Đã đăng vào:";
            // 
            // pnl_Main
            // 
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Main.Controls.Add(this.label2);
            this.pnl_Main.Controls.Add(this.txt_MoTa);
            this.pnl_Main.Controls.Add(this.lbl_TieuDe);
            this.pnl_Main.Controls.Add(this.dtp_ThoiHan);
            this.pnl_Main.Controls.Add(this.dtp_NgayDang);
            this.pnl_Main.Controls.Add(this.label1);
            this.pnl_Main.Controls.Add(this.lbl_NgayDang);
            this.pnl_Main.Location = new System.Drawing.Point(19, 13);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(375, 276);
            this.pnl_Main.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thời hạn:";
            // 
            // dtp_NgayDang
            // 
            this.dtp_NgayDang.Location = new System.Drawing.Point(132, 66);
            this.dtp_NgayDang.Name = "dtp_NgayDang";
            this.dtp_NgayDang.Size = new System.Drawing.Size(200, 27);
            this.dtp_NgayDang.TabIndex = 6;
            // 
            // dtp_ThoiHan
            // 
            this.dtp_ThoiHan.Location = new System.Drawing.Point(131, 105);
            this.dtp_ThoiHan.Name = "dtp_ThoiHan";
            this.dtp_ThoiHan.Size = new System.Drawing.Size(200, 27);
            this.dtp_ThoiHan.TabIndex = 7;
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.AutoSize = true;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.Location = new System.Drawing.Point(206, 13);
            this.lbl_TieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(62, 20);
            this.lbl_TieuDe.TabIndex = 8;
            this.lbl_TieuDe.Text = "Đã nộp";
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(131, 152);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(201, 27);
            this.txt_MoTa.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mô tả";
            // 
            // FormCTBaiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 301);
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCTBaiTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCTBaiTap";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_NgayDang;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.DateTimePicker dtp_ThoiHan;
        private System.Windows.Forms.DateTimePicker dtp_NgayDang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MoTa;
    }
}