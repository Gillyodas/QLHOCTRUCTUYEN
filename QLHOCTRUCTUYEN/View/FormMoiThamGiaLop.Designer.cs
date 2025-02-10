namespace QLHOCTRUCTUYEN.View
{
    partial class FormMoiThamGiaLop
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
            this.txt_MoiTG = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbn_MoiThamGiaPhongHoc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_MoiTG
            // 
            this.txt_MoiTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MoiTG.Location = new System.Drawing.Point(15, 28);
            this.txt_MoiTG.Name = "txt_MoiTG";
            this.txt_MoiTG.Size = new System.Drawing.Size(312, 27);
            this.txt_MoiTG.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbn_MoiThamGiaPhongHoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_MoiTG);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vui lòng nhập địa chỉ Email của người bạn muốn mời";
            // 
            // tbn_MoiThamGiaPhongHoc
            // 
            this.tbn_MoiThamGiaPhongHoc.Location = new System.Drawing.Point(333, 29);
            this.tbn_MoiThamGiaPhongHoc.Name = "tbn_MoiThamGiaPhongHoc";
            this.tbn_MoiThamGiaPhongHoc.Size = new System.Drawing.Size(66, 27);
            this.tbn_MoiThamGiaPhongHoc.TabIndex = 2;
            this.tbn_MoiThamGiaPhongHoc.Text = "Mời";
            this.tbn_MoiThamGiaPhongHoc.UseVisualStyleBackColor = true;
            this.tbn_MoiThamGiaPhongHoc.Click += new System.EventHandler(this.tbn_MoiThamGiaPhongHoc_Click);
            // 
            // FormMoiThamGiaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 148);
            this.Controls.Add(this.panel1);
            this.Name = "FormMoiThamGiaLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMoiThamGiaLop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MoiTG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbn_MoiThamGiaPhongHoc;
    }
}