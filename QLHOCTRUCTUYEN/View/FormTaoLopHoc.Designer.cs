namespace QLHOCTRUCTUYEN.View
{
    partial class FormTaoLopHoc
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
            this.panel_TaoLop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoLop_Huy = new System.Windows.Forms.Button();
            this.btn_TaoLop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_TenLopHoc = new System.Windows.Forms.TextBox();
            this.panel_TaoLop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TaoLop
            // 
            this.panel_TaoLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_TaoLop.Controls.Add(this.groupBox1);
            this.panel_TaoLop.Location = new System.Drawing.Point(21, 15);
            this.panel_TaoLop.Name = "panel_TaoLop";
            this.panel_TaoLop.Size = new System.Drawing.Size(503, 492);
            this.panel_TaoLop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoLop_Huy);
            this.groupBox1.Controls.Add(this.btn_TaoLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_MoTa);
            this.groupBox1.Controls.Add(this.txt_TenLopHoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(33, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo lớp";
            // 
            // btnTaoLop_Huy
            // 
            this.btnTaoLop_Huy.Location = new System.Drawing.Point(188, 367);
            this.btnTaoLop_Huy.Name = "btnTaoLop_Huy";
            this.btnTaoLop_Huy.Size = new System.Drawing.Size(75, 36);
            this.btnTaoLop_Huy.TabIndex = 9;
            this.btnTaoLop_Huy.Text = "Hủy";
            this.btnTaoLop_Huy.UseVisualStyleBackColor = true;
            this.btnTaoLop_Huy.Click += new System.EventHandler(this.btnTaoLop_Huy_Click_1);
            // 
            // btn_TaoLop
            // 
            this.btn_TaoLop.Location = new System.Drawing.Point(294, 367);
            this.btn_TaoLop.Name = "btn_TaoLop";
            this.btn_TaoLop.Size = new System.Drawing.Size(75, 36);
            this.btn_TaoLop.TabIndex = 8;
            this.btn_TaoLop.Text = "Tạo";
            this.btn_TaoLop.UseVisualStyleBackColor = true;
            this.btn_TaoLop.Click += new System.EventHandler(this.btn_TaoLop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mô Tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Lớp Học";
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MoTa.Location = new System.Drawing.Point(47, 158);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(322, 179);
            this.txt_MoTa.TabIndex = 1;
            // 
            // txt_TenLopHoc
            // 
            this.txt_TenLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLopHoc.Location = new System.Drawing.Point(47, 79);
            this.txt_TenLopHoc.Name = "txt_TenLopHoc";
            this.txt_TenLopHoc.Size = new System.Drawing.Size(322, 34);
            this.txt_TenLopHoc.TabIndex = 0;
            // 
            // FormTaoLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 519);
            this.Controls.Add(this.panel_TaoLop);
            this.Name = "FormTaoLopHoc";
            this.Text = "FormTaoLopHoc";
            this.panel_TaoLop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_TaoLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_TenLopHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoLop_Huy;
        private System.Windows.Forms.Button btn_TaoLop;
    }
}