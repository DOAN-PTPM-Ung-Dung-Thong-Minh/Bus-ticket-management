using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmKhachhang : Form
    {
        KhachHangDAL khachHangDAL = new KhachHangDAL();
        VeXeDAL veXeDAL = new VeXeDAL();
        public frmKhachhang()
        {
            InitializeComponent();
            this.AutoSize = true;
        }

        
        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            load_DataKH();
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            if (txtMAKH.Text != "")
            {
                dgvTTKH.DataSource = khachHangDAL.timKiemKH(txtMAKH.Text);

            }
            else
            {
                dgvTTKH.DataSource = khachHangDAL.timKiemKHTheoTen(txtTENKH.Text);
            }
        }

        private void btnCapnhatKH_Click(object sender, EventArgs e)
        {
            if (txtMAKH.Text == "" || txtTENKH.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return;
            }

            if(txtMAKH.Text==null)
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!");
                return;
            }
            else if (txt_passwordkh.Text.Length >= 10 || txt_passwordkh.Text.Length <= 5)
            {
                MessageBox.Show("Độ dài mật khẩu phải lớn hơn 5 và không được lớn hơn 10");
                txt_passwordkh.Text = "";
                return;
            }
            else if (txtSDT.Text.Length <= 10 || txtSDT.Text.Length >= 11)
            {
                MessageBox.Show("Sô điện thoại chỉ có 10 hoặc 11 số");
                txtSDT.Text = "";
                return;
            }
            else
            {
                KhachHang kh = new KhachHang();
                kh.CCCD = txtMAKH.Text;
                kh.TenKH = txtTENKH.Text;
                kh.NgaySinh = dtpNgaysinh.Value.Date;
                kh.SDT = txtSDT.Text;
                kh.Password_kh = txt_passwordkh.Text;
                khachHangDAL.capNhatKH(kh);
                load_DataKH();
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            bool existKH = khachHangDAL.ktKH(txtMAKH.Text);
            bool exitstEmail = khachHangDAL.kiemTraTonTaiEmail(txt_email.Text);
            if (txtTENKH.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return;
            }
            else if (exitstEmail)
            {
                MessageBox.Show("Email này đã tồn tại!");
                return;
            }
            else if (txt_passwordkh.Text.Length >= 10 || txt_passwordkh.Text.Length <= 5)
            {
                MessageBox.Show("Độ dài mật khẩu phải lớn hơn 5 và không được lớn hơn 10");
                txt_passwordkh.Text = "";
                return;
            }
            else if (txtSDT.Text.Length <= 10 || txtSDT.Text.Length >= 11)
            {
                MessageBox.Show("Sô điện thoại chỉ có 10 hoặc 11 số");
                txtSDT.Text = "";
                return;
            }
            else
            {
                KhachHang kh = new KhachHang();
                kh.CCCD = txtMAKH.Text;
                kh.TenKH = txtTENKH.Text;
                kh.NgaySinh = dtpNgaysinh.Value.Date;
                kh.SDT = txtSDT.Text;
                kh.Email = txt_email.Text;
                kh.Password_kh = txt_passwordkh.Text;
                khachHangDAL.themKH(kh);
                load_DataKH();
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            bool existKH = khachHangDAL.ktKH(txtMAKH.Text);
            if(!existKH)
            {
                MessageBox.Show("Không có thông tin khách hàng này!");
                return;
            }
            else
            {
                bool veXe = veXeDAL.existsVeXeTheoKH(txtMAKH.Text);
                if(veXe)
                {
                    MessageBox.Show("Không thể xóa khách hàng này!");
                    return;
                }
                else
                {
                    khachHangDAL.xoaKH(txtMAKH.Text);
                    load_DataKH();
                }
            }

        }

        private void btnDongKH_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }
        private void load_DataKH()
        {
            dgvTTKH.DataSource = khachHangDAL.loadDataKH();
        }

        private void dgvTTKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvTTKH.SelectedCells[0].OwningRow.Cells["MAKH"].Value;
            var data1 = dgvTTKH.SelectedCells[0].OwningRow.Cells["TENKH"].Value;
            var data2 = dgvTTKH.SelectedCells[0].OwningRow.Cells["NGSINH"].Value;
            var data3 = dgvTTKH.SelectedCells[0].OwningRow.Cells["SDT"].Value;
            var data4 = dgvTTKH.SelectedCells[0].OwningRow.Cells["EMAIL"].Value;
            var data5 = dgvTTKH.SelectedCells[0].OwningRow.Cells["PASSWORD"].Value;
            txtMAKH.Text = data.ToString();
            txtTENKH.Text = data1.ToString();
            dtpNgaysinh.Text = data2.ToString();
            txtSDT.Text = data3.ToString();
            txt_email.Text = data4.ToString();
            txt_passwordkh.Text = data5.ToString(); 
        }

        private void txtMAKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        


    }
}
