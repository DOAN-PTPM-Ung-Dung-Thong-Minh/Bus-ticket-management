
namespace WindowsFormsApp1
{
    partial class frmVexe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVexe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVexe = new System.Windows.Forms.DataGridView();
            this.MAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboCX = new System.Windows.Forms.ComboBox();
            this.dtpNgaydi = new System.Windows.Forms.DateTimePicker();
            this.txtMAVE = new System.Windows.Forms.TextBox();
            this.txtMAKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDongVX = new System.Windows.Forms.Button();
            this.btnTimVX = new System.Windows.Forms.Button();
            this.btnXoaVX = new System.Windows.Forms.Button();
            this.btnDatve = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVexe)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVexe);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách vé xe";
            // 
            // dgvVexe
            // 
            this.dgvVexe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVexe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVexe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAVE,
            this.MAKH,
            this.TenKH,
            this.ChuyenXe,
            this.NgayDi,
            this.Xe,
            this.Vitri,
            this.Giave});
            this.dgvVexe.Location = new System.Drawing.Point(2, 33);
            this.dgvVexe.Name = "dgvVexe";
            this.dgvVexe.RowHeadersWidth = 51;
            this.dgvVexe.RowTemplate.Height = 24;
            this.dgvVexe.Size = new System.Drawing.Size(972, 250);
            this.dgvVexe.TabIndex = 0;
            this.dgvVexe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVexe_CellClick);
            // 
            // MAVE
            // 
            this.MAVE.DataPropertyName = "MAVE";
            this.MAVE.HeaderText = "Mã Vé";
            this.MAVE.MinimumWidth = 6;
            this.MAVE.Name = "MAVE";
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "CCCD";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TENKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            // 
            // ChuyenXe
            // 
            this.ChuyenXe.DataPropertyName = "CHUYENXE";
            this.ChuyenXe.HeaderText = "Chuyến Xe";
            this.ChuyenXe.MinimumWidth = 6;
            this.ChuyenXe.Name = "ChuyenXe";
            // 
            // NgayDi
            // 
            this.NgayDi.DataPropertyName = "NGAYDI";
            this.NgayDi.HeaderText = "Ngày Đi";
            this.NgayDi.MinimumWidth = 6;
            this.NgayDi.Name = "NgayDi";
            // 
            // Xe
            // 
            this.Xe.DataPropertyName = "SOXE";
            this.Xe.HeaderText = "Số Xe";
            this.Xe.MinimumWidth = 6;
            this.Xe.Name = "Xe";
            // 
            // Vitri
            // 
            this.Vitri.DataPropertyName = "VITRI";
            this.Vitri.HeaderText = "Vị Trí Ghế";
            this.Vitri.MinimumWidth = 6;
            this.Vitri.Name = "Vitri";
            // 
            // Giave
            // 
            this.Giave.DataPropertyName = "GIAVE";
            this.Giave.HeaderText = "Giá Vé";
            this.Giave.MinimumWidth = 6;
            this.Giave.Name = "Giave";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboCX);
            this.groupBox2.Controls.Add(this.dtpNgaydi);
            this.groupBox2.Controls.Add(this.txtMAVE);
            this.groupBox2.Controls.Add(this.txtMAKH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin vé xe";
            // 
            // cboCX
            // 
            this.cboCX.FormattingEnabled = true;
            this.cboCX.Location = new System.Drawing.Point(638, 85);
            this.cboCX.Name = "cboCX";
            this.cboCX.Size = new System.Drawing.Size(334, 25);
            this.cboCX.TabIndex = 7;
            this.cboCX.SelectedIndexChanged += new System.EventHandler(this.cboCX_SelectedIndexChanged);
            // 
            // dtpNgaydi
            // 
            this.dtpNgaydi.AllowDrop = true;
            this.dtpNgaydi.CustomFormat = "dd/mm/yyyy";
            this.dtpNgaydi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaydi.Location = new System.Drawing.Point(640, 37);
            this.dtpNgaydi.Name = "dtpNgaydi";
            this.dtpNgaydi.Size = new System.Drawing.Size(330, 23);
            this.dtpNgaydi.TabIndex = 3;
            // 
            // txtMAVE
            // 
            this.txtMAVE.Location = new System.Drawing.Point(105, 35);
            this.txtMAVE.Name = "txtMAVE";
            this.txtMAVE.Size = new System.Drawing.Size(330, 23);
            this.txtMAVE.TabIndex = 1;
            // 
            // txtMAKH
            // 
            this.txtMAKH.Location = new System.Drawing.Point(105, 85);
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(330, 23);
            this.txtMAKH.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chuyến xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã vé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày đi";
            // 
            // btnDongVX
            // 
            this.btnDongVX.Location = new System.Drawing.Point(806, 475);
            this.btnDongVX.Name = "btnDongVX";
            this.btnDongVX.Size = new System.Drawing.Size(150, 40);
            this.btnDongVX.TabIndex = 6;
            this.btnDongVX.Text = "Đóng";
            this.btnDongVX.UseVisualStyleBackColor = true;
            this.btnDongVX.Click += new System.EventHandler(this.btnDongVX_Click);
            // 
            // btnTimVX
            // 
            this.btnTimVX.Location = new System.Drawing.Point(12, 475);
            this.btnTimVX.Name = "btnTimVX";
            this.btnTimVX.Size = new System.Drawing.Size(150, 40);
            this.btnTimVX.TabIndex = 6;
            this.btnTimVX.Text = "Tìm ";
            this.btnTimVX.UseVisualStyleBackColor = true;
            this.btnTimVX.Click += new System.EventHandler(this.btnTimVX_Click);
            // 
            // btnXoaVX
            // 
            this.btnXoaVX.Location = new System.Drawing.Point(187, 475);
            this.btnXoaVX.Name = "btnXoaVX";
            this.btnXoaVX.Size = new System.Drawing.Size(150, 40);
            this.btnXoaVX.TabIndex = 6;
            this.btnXoaVX.Text = "Hủy vé";
            this.btnXoaVX.UseVisualStyleBackColor = true;
            this.btnXoaVX.Click += new System.EventHandler(this.btnXoaVX_Click);
            // 
            // btnDatve
            // 
            this.btnDatve.Location = new System.Drawing.Point(362, 475);
            this.btnDatve.Name = "btnDatve";
            this.btnDatve.Size = new System.Drawing.Size(150, 40);
            this.btnDatve.TabIndex = 6;
            this.btnDatve.Text = "Đặt vé/Sửa vé";
            this.btnDatve.UseVisualStyleBackColor = true;
            this.btnDatve.Click += new System.EventHandler(this.btnDatve_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(574, 461);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmVexe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDongVX);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTimVX);
            this.Controls.Add(this.btnDatve);
            this.Controls.Add(this.btnXoaVX);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVexe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vé xe";
            this.Load += new System.EventHandler(this.frmVexe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVexe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVexe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMAKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaydi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDongVX;
        private System.Windows.Forms.Button btnXoaVX;
        private System.Windows.Forms.Button btnTimVX;
        private System.Windows.Forms.TextBox txtMAVE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDatve;
        private System.Windows.Forms.ComboBox cboCX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vitri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giave;
    }
}