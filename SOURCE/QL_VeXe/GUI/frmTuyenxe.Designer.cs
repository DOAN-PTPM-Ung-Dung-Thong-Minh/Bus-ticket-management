
namespace WindowsFormsApp1
{
    partial class frmTuyenxe
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
            this.dgvTX = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimTX = new System.Windows.Forms.Button();
            this.btnCapnhatTX = new System.Windows.Forms.Button();
            this.btnXoaTX = new System.Windows.Forms.Button();
            this.btnThemTX = new System.Windows.Forms.Button();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.txtTenTuyen = new System.Windows.Forms.TextBox();
            this.txtMaTuyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDongTX = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTX);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(829, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Tuyến xe";
            // 
            // dgvTX
            // 
            this.dgvTX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTX.Location = new System.Drawing.Point(0, 32);
            this.dgvTX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvTX.Name = "dgvTX";
            this.dgvTX.RowHeadersWidth = 51;
            this.dgvTX.RowTemplate.Height = 24;
            this.dgvTX.Size = new System.Drawing.Size(811, 289);
            this.dgvTX.TabIndex = 0;
            this.dgvTX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTX_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATUYEN";
            this.Column1.HeaderText = "Mã Tuyến";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimTX);
            this.groupBox2.Controls.Add(this.btnCapnhatTX);
            this.groupBox2.Controls.Add(this.btnXoaTX);
            this.groupBox2.Controls.Add(this.btnThemTX);
            this.groupBox2.Controls.Add(this.txtGiaVe);
            this.groupBox2.Controls.Add(this.txtTenTuyen);
            this.groupBox2.Controls.Add(this.txtMaTuyen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(1, 341);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(811, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Tuyến xe";
            // 
            // btnTimTX
            // 
            this.btnTimTX.Location = new System.Drawing.Point(17, 200);
            this.btnTimTX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTimTX.Name = "btnTimTX";
            this.btnTimTX.Size = new System.Drawing.Size(170, 39);
            this.btnTimTX.TabIndex = 2;
            this.btnTimTX.Text = "Tìm";
            this.btnTimTX.UseVisualStyleBackColor = true;
            this.btnTimTX.Click += new System.EventHandler(this.btnTimTX_Click);
            // 
            // btnCapnhatTX
            // 
            this.btnCapnhatTX.Location = new System.Drawing.Point(215, 200);
            this.btnCapnhatTX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCapnhatTX.Name = "btnCapnhatTX";
            this.btnCapnhatTX.Size = new System.Drawing.Size(170, 39);
            this.btnCapnhatTX.TabIndex = 2;
            this.btnCapnhatTX.Text = "Cập nhật";
            this.btnCapnhatTX.UseVisualStyleBackColor = true;
            this.btnCapnhatTX.Click += new System.EventHandler(this.btnCapnhatTX_Click);
            // 
            // btnXoaTX
            // 
            this.btnXoaTX.Location = new System.Drawing.Point(414, 200);
            this.btnXoaTX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnXoaTX.Name = "btnXoaTX";
            this.btnXoaTX.Size = new System.Drawing.Size(170, 39);
            this.btnXoaTX.TabIndex = 2;
            this.btnXoaTX.Text = "Xóa";
            this.btnXoaTX.UseVisualStyleBackColor = true;
            this.btnXoaTX.Click += new System.EventHandler(this.btnXoaTX_Click);
            // 
            // btnThemTX
            // 
            this.btnThemTX.Location = new System.Drawing.Point(620, 200);
            this.btnThemTX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnThemTX.Name = "btnThemTX";
            this.btnThemTX.Size = new System.Drawing.Size(170, 39);
            this.btnThemTX.TabIndex = 2;
            this.btnThemTX.Text = "Thêm";
            this.btnThemTX.UseVisualStyleBackColor = true;
            this.btnThemTX.Click += new System.EventHandler(this.btnThemTX_Click);
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(562, 40);
            this.txtGiaVe.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(224, 31);
            this.txtGiaVe.TabIndex = 1;
            this.txtGiaVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaVe_KeyPress);
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.Location = new System.Drawing.Point(129, 100);
            this.txtTenTuyen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(282, 31);
            this.txtTenTuyen.TabIndex = 1;
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.Location = new System.Drawing.Point(129, 39);
            this.txtMaTuyen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.Size = new System.Drawing.Size(282, 31);
            this.txtMaTuyen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Tuyến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tuyến";
            // 
            // btnDongTX
            // 
            this.btnDongTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDongTX.Location = new System.Drawing.Point(620, 625);
            this.btnDongTX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDongTX.Name = "btnDongTX";
            this.btnDongTX.Size = new System.Drawing.Size(170, 39);
            this.btnDongTX.TabIndex = 2;
            this.btnDongTX.Text = "Đóng";
            this.btnDongTX.UseVisualStyleBackColor = true;
            this.btnDongTX.Click += new System.EventHandler(this.btnDongTX_Click);
            // 
            // frmTuyenxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 691);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDongTX);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmTuyenxe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTuyenxe";
            this.Load += new System.EventHandler(this.frmTuyenxe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.TextBox txtTenTuyen;
        private System.Windows.Forms.TextBox txtMaTuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimTX;
        private System.Windows.Forms.Button btnCapnhatTX;
        private System.Windows.Forms.Button btnXoaTX;
        private System.Windows.Forms.Button btnThemTX;
        private System.Windows.Forms.Button btnDongTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}