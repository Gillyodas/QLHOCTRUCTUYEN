namespace QLHOCTRUCTUYEN.View
{
    partial class QL_Role
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
            this.lbl_DsRoles = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lbl_NhapRole = new System.Windows.Forms.Label();
            this.txt_Them = new System.Windows.Forms.TextBox();
            this.dgv_DsRoles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DsRoles
            // 
            this.lbl_DsRoles.AutoSize = true;
            this.lbl_DsRoles.Location = new System.Drawing.Point(21, 75);
            this.lbl_DsRoles.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_DsRoles.Name = "lbl_DsRoles";
            this.lbl_DsRoles.Size = new System.Drawing.Size(215, 31);
            this.lbl_DsRoles.TabIndex = 1;
            this.lbl_DsRoles.Text = "Danh sách vai trò";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(14, 241);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(119, 46);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(264, 241);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 46);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(139, 241);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(119, 46);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(713, 138);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(69, 37);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "LƯU";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lbl_NhapRole
            // 
            this.lbl_NhapRole.AutoSize = true;
            this.lbl_NhapRole.Location = new System.Drawing.Point(479, 75);
            this.lbl_NhapRole.Name = "lbl_NhapRole";
            this.lbl_NhapRole.Size = new System.Drawing.Size(303, 31);
            this.lbl_NhapRole.TabIndex = 6;
            this.lbl_NhapRole.Text = "Nhập vai trò muốn thêm";
            this.lbl_NhapRole.Visible = false;
            // 
            // txt_Them
            // 
            this.txt_Them.Location = new System.Drawing.Point(485, 138);
            this.txt_Them.Name = "txt_Them";
            this.txt_Them.Size = new System.Drawing.Size(222, 37);
            this.txt_Them.TabIndex = 7;
            this.txt_Them.Visible = false;
            // 
            // dgv_DsRoles
            // 
            this.dgv_DsRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DsRoles.Location = new System.Drawing.Point(27, 109);
            this.dgv_DsRoles.Name = "dgv_DsRoles";
            this.dgv_DsRoles.RowHeadersWidth = 51;
            this.dgv_DsRoles.RowTemplate.Height = 24;
            this.dgv_DsRoles.Size = new System.Drawing.Size(240, 126);
            this.dgv_DsRoles.TabIndex = 8;
            // 
            // QL_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 304);
            this.Controls.Add(this.dgv_DsRoles);
            this.Controls.Add(this.txt_Them);
            this.Controls.Add(this.lbl_NhapRole);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lbl_DsRoles);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "QL_Role";
            this.Text = "QL_Role";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_DsRoles;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lbl_NhapRole;
        private System.Windows.Forms.TextBox txt_Them;
        private System.Windows.Forms.DataGridView dgv_DsRoles;
    }
}