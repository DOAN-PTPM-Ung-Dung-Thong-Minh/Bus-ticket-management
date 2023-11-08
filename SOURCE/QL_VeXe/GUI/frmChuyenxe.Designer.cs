
namespace WindowsFormsApp1
{
    partial class frmChuyenxe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCX = new System.Windows.Forms.DataGridView();
            this.MaChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioXp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboTX = new System.Windows.Forms.ComboBox();
            this.btnDongCX = new System.Windows.Forms.Button();
            this.btnXoaCX = new System.Windows.Forms.Button();
            this.btnThemCX = new System.Windows.Forms.Button();
            this.txtMACH = new System.Windows.Forms.TextBox();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.cboXe = new System.Windows.Forms.ComboBox();
            this.cboGioXP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCX);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(741, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Chuyến xe";
            // 
            // dgvCX
            // 
            this.dgvCX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyen,
            this.TenChuyen,
            this.TTXe,
            this.GioXp});
            this.dgvCX.Location = new System.Drawing.Point(0, 21);
            this.dgvCX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvCX.Name = "dgvCX";
            this.dgvCX.RowHeadersWidth = 51;
            this.dgvCX.RowTemplate.Height = 24;
            this.dgvCX.Size = new System.Drawing.Size(737, 177);
            this.dgvCX.TabIndex = 0;
            this.dgvCX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCX_CellClick);
            // 
            // MaChuyen
            // 
            this.MaChuyen.DataPropertyName = "MACH";
            this.MaChuyen.HeaderText = "Mã Chuyến";
            this.MaChuyen.MinimumWidth = 6;
            this.MaChuyen.Name = "MaChuyen";
            // 
            // TenChuyen
            // 
            this.TenChuyen.DataPropertyName = "TENCH";
            this.TenChuyen.HeaderText = "Tên Chuyến";
            this.TenChuyen.MinimumWidth = 6;
            this.TenChuyen.Name = "TenChuyen";
            // 
            // TTXe
            // 
            this.TTXe.DataPropertyName = "TTXE";
            this.TTXe.HeaderText = "Thông Tin Xe";
            this.TTXe.MinimumWidth = 6;
            this.TTXe.Name = "TTXe";
            // 
            // GioXp
            // 
            this.GioXp.DataPropertyName = "GIOXP";
            this.GioXp.HeaderText = "Giờ Xuất Phát";
            this.GioXp.MinimumWidth = 6;
            this.GioXp.Name = "GioXp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboTX);
            this.groupBox2.Controls.Add(this.btnDongCX);
            this.groupBox2.Controls.Add(this.btnXoaCX);
            this.groupBox2.Controls.Add(this.btnThemCX);
            this.groupBox2.Controls.Add(this.txtMACH);
            this.groupBox2.Controls.Add(this.txtTenCH);
            this.groupBox2.Controls.Add(this.cboXe);
            this.groupBox2.Controls.Add(this.cboGioXP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(737, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Chuyến xe";
            // 
            // cboTX
            // 
            this.cboTX.FormattingEnabled = true;
            this.cboTX.Location = new System.Drawing.Point(94, 34);
            this.cboTX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboTX.Name = "cboTX";
            this.cboTX.Size = new System.Drawing.Size(263, 25);
            this.cboTX.TabIndex = 4;
            this.cboTX.SelectedIndexChanged += new System.EventHandler(this.cboTX_SelectedIndexChanged);
            // 
            // btnDongCX
            // 
            this.btnDongCX.Location = new System.Drawing.Point(615, 162);
            this.btnDongCX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDongCX.Name = "btnDongCX";
            this.btnDongCX.Size = new System.Drawing.Size(113, 25);
            this.btnDongCX.TabIndex = 3;
            this.btnDongCX.Text = "Đóng";
            this.btnDongCX.UseVisualStyleBackColor = true;
            this.btnDongCX.Click += new System.EventHandler(this.btnDongCX_Click);
            // 
            // btnXoaCX
            // 
            this.btnXoaCX.Location = new System.Drawing.Point(161, 162);
            this.btnXoaCX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXoaCX.Name = "btnXoaCX";
            this.btnXoaCX.Size = new System.Drawing.Size(113, 25);
            this.btnXoaCX.TabIndex = 3;
            this.btnXoaCX.Text = "Xóa";
            this.btnXoaCX.UseVisualStyleBackColor = true;
            this.btnXoaCX.Click += new System.EventHandler(this.btnXoaCX_Click);
            // 
            // btnThemCX
            // 
            this.btnThemCX.Location = new System.Drawing.Point(11, 162);
            this.btnThemCX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThemCX.Name = "btnThemCX";
            this.btnThemCX.Size = new System.Drawing.Size(113, 25);
            this.btnThemCX.TabIndex = 3;
            this.btnThemCX.Text = "Thêm";
            this.btnThemCX.UseVisualStyleBackColor = true;
            this.btnThemCX.Click += new System.EventHandler(this.btnThemCX_Click);
            // 
            // txtMACH
            // 
            this.txtMACH.Location = new System.Drawing.Point(94, 69);
            this.txtMACH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMACH.Name = "txtMACH";
            this.txtMACH.Size = new System.Drawing.Size(263, 23);
            this.txtMACH.TabIndex = 2;
            // 
            // txtTenCH
            // 
            this.txtTenCH.Location = new System.Drawing.Point(94, 105);
            this.txtTenCH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(263, 23);
            this.txtTenCH.TabIndex = 2;
            // 
            // cboXe
            // 
            this.cboXe.FormattingEnabled = true;
            this.cboXe.Location = new System.Drawing.Point(521, 66);
            this.cboXe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboXe.Name = "cboXe";
            this.cboXe.Size = new System.Drawing.Size(207, 25);
            this.cboXe.TabIndex = 1;
            // 
            // cboGioXP
            // 
            this.cboGioXP.FormattingEnabled = true;
            this.cboGioXP.Location = new System.Drawing.Point(521, 105);
            this.cboGioXP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboGioXP.Name = "cboGioXP";
            this.cboGioXP.Size = new System.Drawing.Size(207, 25);
            this.cboGioXP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Chuyến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Chuyến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Xe";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(397, 110);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Giờ xuất phát";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tuyến xe";
            // 
            // frmChuyenxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmChuyenxe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuyenxe";
            this.Load += new System.EventHandler(this.frmChuyenxe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMACH;
        private System.Windows.Forms.TextBox txtTenCH;
        private System.Windows.Forms.ComboBox cboGioXP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemCX;
        private System.Windows.Forms.Button btnDongCX;
        private System.Windows.Forms.Button btnXoaCX;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cboXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioXp;
    }
}