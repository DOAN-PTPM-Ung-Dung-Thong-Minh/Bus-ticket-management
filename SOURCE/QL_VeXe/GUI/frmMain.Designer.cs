
namespace WindowsFormsApp1
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBanve = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.btnXe = new System.Windows.Forms.Button();
            this.btnVX = new System.Windows.Forms.Button();
            this.btnCX = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnTX = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(240, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ỨNG DỤNG BÁN VÉ XE KHÁCH";
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Location = new System.Drawing.Point(45, 266);
            this.btnDangxuat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(113, 32);
            this.btnDangxuat.TabIndex = 2;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnDangxuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 415);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Beige;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(26, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnBanve
            // 
            this.btnBanve.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBanve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBanve.Image = global::WindowsFormsApp1.Properties.Resources.sales;
            this.btnBanve.Location = new System.Drawing.Point(685, 74);
            this.btnBanve.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBanve.Name = "btnBanve";
            this.btnBanve.Size = new System.Drawing.Size(195, 162);
            this.btnBanve.TabIndex = 4;
            this.btnBanve.Text = "Đặt vé";
            this.btnBanve.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBanve.UseVisualStyleBackColor = false;
            this.btnBanve.Click += new System.EventHandler(this.btnBanve_Click);
            // 
            // btnNV
            // 
            this.btnNV.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNV.Image = global::WindowsFormsApp1.Properties.Resources.staff;
            this.btnNV.Location = new System.Drawing.Point(461, 74);
            this.btnNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(187, 162);
            this.btnNV.TabIndex = 4;
            this.btnNV.Text = "Thông tin Nhân viên";
            this.btnNV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNV.UseVisualStyleBackColor = false;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnXe
            // 
            this.btnXe.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXe.Image = global::WindowsFormsApp1.Properties.Resources.bus;
            this.btnXe.Location = new System.Drawing.Point(221, 257);
            this.btnXe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXe.Name = "btnXe";
            this.btnXe.Size = new System.Drawing.Size(150, 203);
            this.btnXe.TabIndex = 4;
            this.btnXe.Text = "Quản lý Xe";
            this.btnXe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXe.UseVisualStyleBackColor = false;
            this.btnXe.Click += new System.EventHandler(this.btnXe_Click);
            // 
            // btnVX
            // 
            this.btnVX.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnVX.Image = global::WindowsFormsApp1.Properties.Resources.vexe;
            this.btnVX.Location = new System.Drawing.Point(731, 257);
            this.btnVX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVX.Name = "btnVX";
            this.btnVX.Size = new System.Drawing.Size(150, 203);
            this.btnVX.TabIndex = 0;
            this.btnVX.Text = "Thông tin Vé xe";
            this.btnVX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVX.UseVisualStyleBackColor = false;
            this.btnVX.Click += new System.EventHandler(this.btnVX_Click);
            // 
            // btnCX
            // 
            this.btnCX.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCX.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCX.Image = global::WindowsFormsApp1.Properties.Resources.icon_cxe;
            this.btnCX.Location = new System.Drawing.Point(565, 257);
            this.btnCX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCX.Name = "btnCX";
            this.btnCX.Size = new System.Drawing.Size(150, 203);
            this.btnCX.TabIndex = 0;
            this.btnCX.Text = "Thông tin chuyến xe";
            this.btnCX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCX.UseVisualStyleBackColor = false;
            this.btnCX.Click += new System.EventHandler(this.btnCX_Click);
            // 
            // btnKH
            // 
            this.btnKH.BackColor = System.Drawing.Color.SpringGreen;
            this.btnKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKH.Image = global::WindowsFormsApp1.Properties.Resources.account;
            this.btnKH.Location = new System.Drawing.Point(227, 74);
            this.btnKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(187, 162);
            this.btnKH.TabIndex = 0;
            this.btnKH.Text = "Thông tin khách hàng";
            this.btnKH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKH.UseVisualStyleBackColor = false;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // btnTX
            // 
            this.btnTX.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTX.Image = global::WindowsFormsApp1.Properties.Resources.icontx;
            this.btnTX.Location = new System.Drawing.Point(395, 257);
            this.btnTX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTX.Name = "btnTX";
            this.btnTX.Size = new System.Drawing.Size(150, 203);
            this.btnTX.TabIndex = 0;
            this.btnTX.Text = "Thông tin tuyến xe";
            this.btnTX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTX.UseVisualStyleBackColor = false;
            this.btnTX.Click += new System.EventHandler(this.btnTX_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(919, 474);
            this.Controls.Add(this.btnBanve);
            this.Controls.Add(this.btnNV);
            this.Controls.Add(this.btnXe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVX);
            this.Controls.Add(this.btnCX);
            this.Controls.Add(this.btnKH);
            this.Controls.Add(this.btnTX);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTX;
        private System.Windows.Forms.Button btnCX;
        private System.Windows.Forms.Button btnVX;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXe;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnBanve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

