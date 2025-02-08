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
            this.dgv_DsLTN = new System.Windows.Forms.DataGridView();
            this.cln_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_TenLTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_LoaiTaiNguyen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsLTN)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DsLTN
            // 
            this.lbl_DsLTN.AutoSize = true;
            this.lbl_DsLTN.Location = new System.Drawing.Point(47, 36);
            this.lbl_DsLTN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DsLTN.Name = "lbl_DsLTN";
            this.lbl_DsLTN.Size = new System.Drawing.Size(232, 24);
            this.lbl_DsLTN.TabIndex = 0;
            this.lbl_DsLTN.Text = "Danh sách loại tài nguyên";
            // 
            // dgv_DsLTN
            // 
            this.dgv_DsLTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DsLTN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_ID,
            this.cln_TenLTN});
            this.dgv_DsLTN.Location = new System.Drawing.Point(51, 78);
            this.dgv_DsLTN.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DsLTN.Name = "dgv_DsLTN";
            this.dgv_DsLTN.RowHeadersWidth = 51;
            this.dgv_DsLTN.RowTemplate.Height = 24;
            this.dgv_DsLTN.Size = new System.Drawing.Size(397, 146);
            this.dgv_DsLTN.TabIndex = 1;
            this.dgv_DsLTN.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DsLTN_CellValueChanged);
            // 
            // cln_ID
            // 
            this.cln_ID.HeaderText = "ID";
            this.cln_ID.MinimumWidth = 6;
            this.cln_ID.Name = "cln_ID";
            this.cln_ID.Width = 125;
            // 
            // cln_TenLTN
            // 
            this.cln_TenLTN.HeaderText = "Tên Loại Tài Nguyên";
            this.cln_TenLTN.MinimumWidth = 6;
            this.cln_TenLTN.Name = "cln_TenLTN";
            this.cln_TenLTN.Width = 225;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(51, 232);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(127, 37);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(186, 232);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(127, 37);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(321, 232);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(127, 37);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(685, 78);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 29);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "LƯU";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập loại tài nguyên muốn thêm";
            this.label1.Visible = false;
            // 
            // txt_LoaiTaiNguyen
            // 
            this.txt_LoaiTaiNguyen.Location = new System.Drawing.Point(466, 78);
            this.txt_LoaiTaiNguyen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoaiTaiNguyen.Name = "txt_LoaiTaiNguyen";
            this.txt_LoaiTaiNguyen.Size = new System.Drawing.Size(211, 29);
            this.txt_LoaiTaiNguyen.TabIndex = 7;
            this.txt_LoaiTaiNguyen.Visible = false;
            // 
            // QL_LoaiTaiNguyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 287);
            this.Controls.Add(this.txt_LoaiTaiNguyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_DsLTN);
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
        private System.Windows.Forms.DataGridView dgv_DsLTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_TenLTN;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LoaiTaiNguyen;
    }
}