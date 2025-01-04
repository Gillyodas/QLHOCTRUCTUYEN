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
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Ma = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_ThamGiaLop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ThamGiaLop
            // 
            this.panel_ThamGiaLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_ThamGiaLop.Controls.Add(this.button2);
            this.panel_ThamGiaLop.Controls.Add(this.button1);
            this.panel_ThamGiaLop.Controls.Add(this.groupBox1);
            this.panel_ThamGiaLop.Location = new System.Drawing.Point(43, 60);
            this.panel_ThamGiaLop.Name = "panel_ThamGiaLop";
            this.panel_ThamGiaLop.Size = new System.Drawing.Size(320, 273);
            this.panel_ThamGiaLop.TabIndex = 0;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLop.Location = new System.Drawing.Point(23, 66);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(208, 30);
            this.txt_MaLop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Ma);
            this.groupBox1.Controls.Add(this.txt_MaLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 61);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Huy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormThamGiaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}