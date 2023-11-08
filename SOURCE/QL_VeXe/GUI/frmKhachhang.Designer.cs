
namespace WindowsFormsApp1
{
    partial class frmKhachhang
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
            this.dgvTTKH = new System.Windows.Forms.DataGridView();
            this.grbTTKH = new System.Windows.Forms.GroupBox();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnCapnhatKH = new System.Windows.Forms.Button();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtTENKH = new System.Windows.Forms.TextBox();
            this.txtMAKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDongKH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_passwordkh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKH)).BeginInit();
            this.grbTTKH.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTTKH
            // 
            this.dgvTTKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.NGSINH,
            this.DIACHI,
            this.email,
            this.password});
            this.dgvTTKH.Location = new System.Drawing.Point(5, 32);
            this.dgvTTKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvTTKH.Name = "dgvTTKH";
            this.dgvTTKH.RowHeadersWidth = 51;
            this.dgvTTKH.RowTemplate.Height = 24;
            this.dgvTTKH.Size = new System.Drawing.Size(749, 413);
            this.dgvTTKH.TabIndex = 0;
            this.dgvTTKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTKH_CellClick);
            // 
            // grbTTKH
            // 
            this.grbTTKH.Controls.Add(this.label7);
            this.grbTTKH.Controls.Add(this.label6);
            this.grbTTKH.Controls.Add(this.txt_passwordkh);
            this.grbTTKH.Controls.Add(this.txt_email);
            this.grbTTKH.Controls.Add(this.btnThemKH);
            this.grbTTKH.Controls.Add(this.btnTimKH);
            this.grbTTKH.Controls.Add(this.btnXoaKH);
            this.grbTTKH.Controls.Add(this.btnCapnhatKH);
            this.grbTTKH.Controls.Add(this.dtpNgaysinh);
            this.grbTTKH.Controls.Add(this.txtDIACHI);
            this.grbTTKH.Controls.Add(this.txtTENKH);
            this.grbTTKH.Controls.Add(this.txtMAKH);
            this.grbTTKH.Controls.Add(this.label3);
            this.grbTTKH.Controls.Add(this.label5);
            this.grbTTKH.Controls.Add(this.label4);
            this.grbTTKH.Controls.Add(this.label2);
            this.grbTTKH.Controls.Add(this.label1);
            this.grbTTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbTTKH.Location = new System.Drawing.Point(762, 12);
            this.grbTTKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grbTTKH.Name = "grbTTKH";
            this.grbTTKH.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grbTTKH.Size = new System.Drawing.Size(366, 371);
            this.grbTTKH.TabIndex = 1;
            this.grbTTKH.TabStop = false;
            this.grbTTKH.Text = "Thông tin KH";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(4, 325);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(102, 29);
            this.btnThemKH.TabIndex = 5;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnTimKH
            // 
            this.btnTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKH.Location = new System.Drawing.Point(245, 281);
            this.btnTimKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(102, 29);
            this.btnTimKH.TabIndex = 5;
            this.btnTimKH.Text = "Tìm";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(244, 325);
            this.btnXoaKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(102, 29);
            this.btnXoaKH.TabIndex = 5;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnCapnhatKH
            // 
            this.btnCapnhatKH.Location = new System.Drawing.Point(121, 325);
            this.btnCapnhatKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCapnhatKH.Name = "btnCapnhatKH";
            this.btnCapnhatKH.Size = new System.Drawing.Size(102, 29);
            this.btnCapnhatKH.TabIndex = 5;
            this.btnCapnhatKH.Text = "Cập nhật";
            this.btnCapnhatKH.UseVisualStyleBackColor = true;
            this.btnCapnhatKH.Click += new System.EventHandler(this.btnCapnhatKH_Click);
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(135, 114);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(212, 23);
            this.dtpNgaysinh.TabIndex = 4;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.Location = new System.Drawing.Point(135, 155);
            this.txtDIACHI.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(212, 23);
            this.txtDIACHI.TabIndex = 3;
            // 
            // txtTENKH
            // 
            this.txtTENKH.Location = new System.Drawing.Point(135, 73);
            this.txtTENKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTENKH.Name = "txtTENKH";
            this.txtTENKH.Size = new System.Drawing.Size(212, 23);
            this.txtTENKH.TabIndex = 3;
            // 
            // txtMAKH
            // 
            this.txtMAKH.Location = new System.Drawing.Point(135, 32);
            this.txtMAKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(212, 23);
            this.txtMAKH.TabIndex = 3;
            this.txtMAKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMAKH_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "CCCD:";
            // 
            // btnDongKH
            // 
            this.btnDongKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDongKH.Location = new System.Drawing.Point(1006, 416);
            this.btnDongKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDongKH.Name = "btnDongKH";
            this.btnDongKH.Size = new System.Drawing.Size(102, 29);
            this.btnDongKH.TabIndex = 5;
            this.btnDongKH.Text = "Đóng";
            this.btnDongKH.UseVisualStyleBackColor = true;
            this.btnDongKH.Click += new System.EventHandler(this.btnDongKH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTTKH);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(758, 462);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(135, 198);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(211, 23);
            this.txt_email.TabIndex = 6;
            // 
            // txt_passwordkh
            // 
            this.txt_passwordkh.Location = new System.Drawing.Point(135, 237);
            this.txt_passwordkh.Name = "txt_passwordkh";
            this.txt_passwordkh.Size = new System.Drawing.Size(212, 23);
            this.txt_passwordkh.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password:";
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "CCCD";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên KH";
            this.TENKH.MinimumWidth = 6;
            this.TENKH.Name = "TENKH";
            // 
            // NGSINH
            // 
            this.NGSINH.DataPropertyName = "NGSINH";
            this.NGSINH.HeaderText = "Ngày Sinh";
            this.NGSINH.MinimumWidth = 6;
            this.NGSINH.Name = "NGSINH";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // password
            // 
            this.password.DataPropertyName = "PASSWORD";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            // 
            // frmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDongKH);
            this.Controls.Add(this.grbTTKH);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmKhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhachhang";
            this.Load += new System.EventHandler(this.frmKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKH)).EndInit();
            this.grbTTKH.ResumeLayout(false);
            this.grbTTKH.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTTKH;
        private System.Windows.Forms.GroupBox grbTTKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMAKH;
        private System.Windows.Forms.TextBox txtTENKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnCapnhatKH;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDongKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_passwordkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}