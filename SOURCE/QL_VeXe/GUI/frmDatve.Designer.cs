
namespace WindowsFormsApp1
{
    partial class frmDatve
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
            this.cboCX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_kh = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnVexe = new System.Windows.Forms.Button();
            this.btnSuave = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnKiemtra = new System.Windows.Forms.Button();
            this.btnDatve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVitri = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCX = new System.Windows.Forms.DataGridView();
            this.MaChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioXp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTX = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTX)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCX
            // 
            this.cboCX.FormattingEnabled = true;
            this.cboCX.Location = new System.Drawing.Point(146, 36);
            this.cboCX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCX.Name = "cboCX";
            this.cboCX.Size = new System.Drawing.Size(251, 28);
            this.cboCX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn chuyến ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_kh);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.btnVexe);
            this.groupBox2.Controls.Add(this.btnSuave);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.btnKiemtra);
            this.groupBox2.Controls.Add(this.btnDatve);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboVitri);
            this.groupBox2.Controls.Add(this.cboCX);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(701, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(430, 782);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bán vé xe";
            // 
            // cbb_kh
            // 
            this.cbb_kh.FormattingEnabled = true;
            this.cbb_kh.Location = new System.Drawing.Point(146, 255);
            this.cbb_kh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_kh.Name = "cbb_kh";
            this.cbb_kh.Size = new System.Drawing.Size(251, 28);
            this.cbb_kh.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 84);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnVexe
            // 
            this.btnVexe.Location = new System.Drawing.Point(34, 554);
            this.btnVexe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVexe.Name = "btnVexe";
            this.btnVexe.Size = new System.Drawing.Size(130, 39);
            this.btnVexe.TabIndex = 5;
            this.btnVexe.Text = "TT Vé xe";
            this.btnVexe.UseVisualStyleBackColor = true;
            this.btnVexe.Click += new System.EventHandler(this.btnVexe_Click);
            // 
            // btnSuave
            // 
            this.btnSuave.Location = new System.Drawing.Point(25, 410);
            this.btnSuave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuave.Name = "btnSuave";
            this.btnSuave.Size = new System.Drawing.Size(130, 39);
            this.btnSuave.TabIndex = 5;
            this.btnSuave.Text = "Sửa vé";
            this.btnSuave.UseVisualStyleBackColor = true;
            this.btnSuave.Click += new System.EventHandler(this.btnSuave_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(269, 554);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(130, 39);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnKiemtra
            // 
            this.btnKiemtra.Location = new System.Drawing.Point(267, 153);
            this.btnKiemtra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKiemtra.Name = "btnKiemtra";
            this.btnKiemtra.Size = new System.Drawing.Size(130, 39);
            this.btnKiemtra.TabIndex = 5;
            this.btnKiemtra.Text = "Kiểm tra";
            this.btnKiemtra.UseVisualStyleBackColor = true;
            this.btnKiemtra.Click += new System.EventHandler(this.btnKiemtra_Click);
            // 
            // btnDatve
            // 
            this.btnDatve.Location = new System.Drawing.Point(267, 410);
            this.btnDatve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDatve.Name = "btnDatve";
            this.btnDatve.Size = new System.Drawing.Size(130, 39);
            this.btnDatve.TabIndex = 5;
            this.btnDatve.Text = "Đặt vé";
            this.btnDatve.UseVisualStyleBackColor = true;
            this.btnDatve.Click += new System.EventHandler(this.btnDatve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chọn vị trí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khách hàng";
            // 
            // cboVitri
            // 
            this.cboVitri.FormattingEnabled = true;
            this.cboVitri.Location = new System.Drawing.Point(146, 312);
            this.cboVitri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboVitri.Name = "cboVitri";
            this.cboVitri.Size = new System.Drawing.Size(251, 28);
            this.cboVitri.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTX);
            this.groupBox1.Controls.Add(this.dgvCX);
            this.groupBox1.Controls.Add(this.dgvVe);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(684, 782);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vé xe";
            // 
            // dgvVe
            // 
            this.dgvVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.Chuyen,
            this.NgayDi,
            this.Column1});
            this.dgvVe.Location = new System.Drawing.Point(0, 26);
            this.dgvVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.RowHeadersWidth = 51;
            this.dgvVe.RowTemplate.Height = 24;
            this.dgvVe.Size = new System.Drawing.Size(679, 166);
            this.dgvVe.TabIndex = 0;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MAKH";
            this.MaKH.HeaderText = "CCCD";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // Chuyen
            // 
            this.Chuyen.DataPropertyName = "CH";
            this.Chuyen.HeaderText = "Chuyến";
            this.Chuyen.MinimumWidth = 6;
            this.Chuyen.Name = "Chuyen";
            // 
            // NgayDi
            // 
            this.NgayDi.DataPropertyName = "NGDI";
            this.NgayDi.HeaderText = "Ngày Đi";
            this.NgayDi.MinimumWidth = 6;
            this.NgayDi.Name = "NgayDi";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "VITRI";
            this.Column1.HeaderText = "Vị trí ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
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
            this.dgvCX.Location = new System.Drawing.Point(0, 218);
            this.dgvCX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCX.Name = "dgvCX";
            this.dgvCX.RowHeadersWidth = 51;
            this.dgvCX.RowTemplate.Height = 24;
            this.dgvCX.Size = new System.Drawing.Size(679, 288);
            this.dgvCX.TabIndex = 1;
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
            // dgvTX
            // 
            this.dgvTX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.Column3});
            this.dgvTX.Location = new System.Drawing.Point(0, 538);
            this.dgvTX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTX.Name = "dgvTX";
            this.dgvTX.RowHeadersWidth = 51;
            this.dgvTX.RowTemplate.Height = 24;
            this.dgvTX.Size = new System.Drawing.Size(685, 231);
            this.dgvTX.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MATUYEN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Tuyến";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTUYEN";
            this.Column2.HeaderText = "Tên Tuyến";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GIAVE";
            this.Column3.HeaderText = "Giá Vé";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // frmDatve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 782);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDatve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatve";
            this.Load += new System.EventHandler(this.frmDatve_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboCX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVexe;
        private System.Windows.Forms.Button btnSuave;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnKiemtra;
        private System.Windows.Forms.Button btnDatve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboVitri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.ComboBox cbb_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvCX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioXp;
        private System.Windows.Forms.DataGridView dgvTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}