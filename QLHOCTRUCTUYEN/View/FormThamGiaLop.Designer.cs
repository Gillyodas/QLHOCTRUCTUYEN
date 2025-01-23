namespace QLHOCTRUCTUYEN.View
{
    partial class FormThamGiaLop
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
            this.panel_ThamGiaLop = new System.Windows.Forms.Panel();
            this.btn_tg_Huy = new System.Windows.Forms.Button();
            this.btn_XMaLop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Ma = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.panel_ThamGiaLop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ThamGiaLop
            // 
            this.panel_ThamGiaLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_ThamGiaLop.Controls.Add(this.btn_tg_Huy);
            this.panel_ThamGiaLop.Controls.Add(this.btn_XMaLop);
            this.panel_ThamGiaLop.Controls.Add(this.groupBox1);
            this.panel_ThamGiaLop.Location = new System.Drawing.Point(21, 12);
            this.panel_ThamGiaLop.Name = "panel_ThamGiaLop";
            this.panel_ThamGiaLop.Size = new System.Drawing.Size(342, 349);
            this.panel_ThamGiaLop.TabIndex = 0;
            // 
            // btn_tg_Huy
            // 
            this.btn_tg_Huy.Location = new System.Drawing.Point(68, 224);
            this.btn_tg_Huy.Name = "btn_tg_Huy";
            this.btn_tg_Huy.Size = new System.Drawing.Size(93, 33);
            this.btn_tg_Huy.TabIndex = 3;
            this.btn_tg_Huy.Text = "Huy";
            this.btn_tg_Huy.UseVisualStyleBackColor = true;
            this.btn_tg_Huy.Click += new System.EventHandler(this.btn_tg_Huy_Click);
            // 
            // btn_XMaLop
            // 
            this.btn_XMaLop.Location = new System.Drawing.Point(184, 224);
            this.btn_XMaLop.Name = "btn_XMaLop";
            this.btn_XMaLop.Size = new System.Drawing.Size(93, 33);
            this.btn_XMaLop.TabIndex = 2;
            this.btn_XMaLop.Text = "Xác Nhận";
            this.btn_XMaLop.UseVisualStyleBackColor = true;
            this.btn_XMaLop.Click += new System.EventHandler(this.btn_XMaLop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Ma);
            this.groupBox1.Controls.Add(this.txt_MaLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã Lớp";
            // 
            // lb_Ma
            // 
            this.lb_Ma.AutoSize = true;
            this.lb_Ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ma.Location = new System.Drawing.Point(23, 25);
            this.lb_Ma.Name = "lb_Ma";
            this.lb_Ma.Size = new System.Drawing.Size(162, 13);
            this.lb_Ma.TabIndex = 1;
            this.lb_Ma.Text = "vui lòng nhập mã lớp học của lớp";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLop.Location = new System.Drawing.Point(23, 66);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(208, 30);
            this.txt_MaLop.TabIndex = 0;
            // 
            // FormThamGiaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 389);
            this.Controls.Add(this.panel_ThamGiaLop);
            this.Name = "FormThamGiaLop";
            this.Text = "FormThamGiaLop";
            this.panel_ThamGiaLop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ThamGiaLop;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Ma;
        private System.Windows.Forms.Button btn_tg_Huy;
        private System.Windows.Forms.Button btn_XMaLop;
    }
}