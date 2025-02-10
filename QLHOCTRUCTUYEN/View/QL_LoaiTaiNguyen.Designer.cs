namespace QLHOCTRUCTUYEN.View
{
    partial class QL_LoaiTaiNguyen
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
            this.lbl_DsLTN = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lbl_TieuDeThem = new System.Windows.Forms.Label();
            this.txt_LoaiTaiNguyen = new System.Windows.Forms.TextBox();
            this.dgv_DsLTN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsLTN)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DsLTN
            // 
            this.lbl_DsLTN.AutoSize = true;
            this.lbl_DsLTN.Location = new System.Drawing.Point(8, 9);
            this.lbl_DsLTN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DsLTN.Name = "lbl_DsLTN";
            this.lbl_DsLTN.Size = new System.Drawing.Size(232, 24);
            this.lbl_DsLTN.TabIndex = 0;
            this.lbl_DsLTN.Text = "Danh sách loại tài nguyên";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(282, 198);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(127, 37);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(646, 51);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 29);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "LƯU";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Visible = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lbl_TieuDeThem
            // 
            this.lbl_TieuDeThem.AutoSize = true;
            this.lbl_TieuDeThem.Location = new System.Drawing.Point(423, 13);
            this.lbl_TieuDeThem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TieuDeThem.Name = "lbl_TieuDeThem";
            this.lbl_TieuDeThem.Size = new System.Drawing.Size(298, 24);
            this.lbl_TieuDeThem.TabIndex = 6;
            this.lbl_TieuDeThem.Text = "Nhập loại tài nguyên muốn thêm";
            this.lbl_TieuDeThem.Visible = false;
            // 
            // txt_LoaiTaiNguyen
            // 
            this.txt_LoaiTaiNguyen.Location = new System.Drawing.Point(427, 51);
            this.txt_LoaiTaiNguyen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoaiTaiNguyen.Name = "txt_LoaiTaiNguyen";
            this.txt_LoaiTaiNguyen.Size = new System.Drawing.Size(211, 29);
            this.txt_LoaiTaiNguyen.TabIndex = 7;
            this.txt_LoaiTaiNguyen.Visible = false;
            // 
            // dgv_DsLTN
            // 
            this.dgv_DsLTN.AllowUserToAddRows = false;
            this.dgv_DsLTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DsLTN.Location = new System.Drawing.Point(12, 36);
            this.dgv_DsLTN.Name = "dgv_DsLTN";
            this.dgv_DsLTN.RowHeadersWidth = 51;
            this.dgv_DsLTN.RowTemplate.Height = 24;
            this.dgv_DsLTN.Size = new System.Drawing.Size(397, 150);
            this.dgv_DsLTN.TabIndex = 8;
            this.dgv_DsLTN.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DsLTN_CellValueChanged);
            // 
            // QL_LoaiTaiNguyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 248);
            this.Controls.Add(this.dgv_DsLTN);
            this.Controls.Add(this.txt_LoaiTaiNguyen);
            this.Controls.Add(this.lbl_TieuDeThem);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lbl_DsLTN);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QL_LoaiTaiNguyen";
            this.Text = "QL_LoaiTaiNguyen";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsLTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DsLTN;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lbl_TieuDeThem;
        private System.Windows.Forms.TextBox txt_LoaiTaiNguyen;
        private System.Windows.Forms.DataGridView dgv_DsLTN;
    }
}