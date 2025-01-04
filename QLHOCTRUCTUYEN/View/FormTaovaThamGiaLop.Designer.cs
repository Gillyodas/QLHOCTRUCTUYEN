namespace QLHOCTRUCTUYEN.View
{
    partial class FormTaovaThamGiaLop
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
            this.lb_ThamGiaLop = new System.Windows.Forms.Label();
            this.panel_TaoLop = new System.Windows.Forms.Panel();
            this.lb_TaoLop = new System.Windows.Forms.Label();
            this.panel_ThamGiaLop.SuspendLayout();
            this.panel_TaoLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ThamGiaLop
            // 
            this.panel_ThamGiaLop.Controls.Add(this.lb_ThamGiaLop);
            this.panel_ThamGiaLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ThamGiaLop.Location = new System.Drawing.Point(0, 0);
            this.panel_ThamGiaLop.Name = "panel_ThamGiaLop";
            this.panel_ThamGiaLop.Size = new System.Drawing.Size(246, 92);
            this.panel_ThamGiaLop.TabIndex = 0;
            this.panel_ThamGiaLop.MouseLeave += new System.EventHandler(this.panel_ThamGiaLop_MouseLeave);
            this.panel_ThamGiaLop.MouseHover += new System.EventHandler(this.panel_ThamGiaLop_MouseHover);
            // 
            // lb_ThamGiaLop
            // 
            this.lb_ThamGiaLop.AutoSize = true;
            this.lb_ThamGiaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThamGiaLop.Location = new System.Drawing.Point(31, 36);
            this.lb_ThamGiaLop.Name = "lb_ThamGiaLop";
            this.lb_ThamGiaLop.Size = new System.Drawing.Size(153, 20);
            this.lb_ThamGiaLop.TabIndex = 0;
            this.lb_ThamGiaLop.Text = "Tham gia lớp học";
            this.lb_ThamGiaLop.MouseLeave += new System.EventHandler(this.lb_ThamGiaLop_MouseLeave);
            this.lb_ThamGiaLop.MouseHover += new System.EventHandler(this.lb_ThamGiaLop_MouseHover);
            // 
            // panel_TaoLop
            // 
            this.panel_TaoLop.Controls.Add(this.lb_TaoLop);
            this.panel_TaoLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TaoLop.Location = new System.Drawing.Point(0, 92);
            this.panel_TaoLop.Name = "panel_TaoLop";
            this.panel_TaoLop.Size = new System.Drawing.Size(246, 87);
            this.panel_TaoLop.TabIndex = 1;
            this.panel_TaoLop.MouseLeave += new System.EventHandler(this.panel_TaoLop_MouseLeave);
            this.panel_TaoLop.MouseHover += new System.EventHandler(this.panel_TaoLop_MouseHover);
            // 
            // lb_TaoLop
            // 
            this.lb_TaoLop.AutoSize = true;
            this.lb_TaoLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TaoLop.Location = new System.Drawing.Point(31, 33);
            this.lb_TaoLop.Name = "lb_TaoLop";
            this.lb_TaoLop.Size = new System.Drawing.Size(113, 20);
            this.lb_TaoLop.TabIndex = 0;
            this.lb_TaoLop.Text = "Tạo Lớp học";
            this.lb_TaoLop.MouseLeave += new System.EventHandler(this.lb_TaoLop_MouseLeave);
            this.lb_TaoLop.MouseHover += new System.EventHandler(this.lb_TaoLop_MouseHover);
            // 
            // FormTaovaThamGiaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 179);
            this.Controls.Add(this.panel_TaoLop);
            this.Controls.Add(this.panel_ThamGiaLop);
            this.Name = "FormTaovaThamGiaLop";
            this.Text = "FormTaovaThamGiaLop";
            this.Load += new System.EventHandler(this.FormTaovaThamGiaLop_Load);
            this.panel_ThamGiaLop.ResumeLayout(false);
            this.panel_ThamGiaLop.PerformLayout();
            this.panel_TaoLop.ResumeLayout(false);
            this.panel_TaoLop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ThamGiaLop;
        private System.Windows.Forms.Panel panel_TaoLop;
        private System.Windows.Forms.Label lb_ThamGiaLop;
        private System.Windows.Forms.Label lb_TaoLop;
    }
}