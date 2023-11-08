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
    public partial class frmNhanvien : Form
    {
        NhanVienDAL nhanVienDAL = new NhanVienDAL();
        ChucVuDAL chucVuDAL = new ChucVuDAL();
        XeDAL xeDAL = new XeDAL();
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            load_CBOCV();
            load_DataNV();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            if (txtIDNV.Text != "")
            {
                var timnv = nhanVienDAL.timNVTheoMa(txtIDNV.Text);
                dgvNV.DataSource = timnv;


            }
            else
            {
                var timnv1 = nhanVienDAL.timNVTheoTen(txtTenNV.Text);
                dgvNV.DataSource = timnv1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime ngayHienTai = DateTime.Today;
            bool existsNV = nhanVienDAL.existsNV(txtIDNV.Text);
            if (txtIDNV.Text == "" || txtTenNV.Text == "" || txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
                return;
            }
            if (existsNV)
            {
                MessageBox.Show("Mã này đã tồn tại");
                return;
            }else if(txt_SDT.TextLength <10 || txt_SDT.TextLength >11)
            {
                MessageBox.Show("Vui lòng nhập lại SDT chỉ có 10 số hoặc 11 số ^^ ");
                txt_SDT.Text = "";
                return;
            }else if (dtpNgaysinh.Value.Date >= DateTime.Now)
            {
                MessageBox.Show("Không được nhập số ngày lớn hơn ngày hiện tại vì chưa ra đời hoặc ngày hiện tại  vì mới ra đời làm gì biết đếm tiền mà mua vé !!!");
                return;
            }
            else
            {
                Nhanvien newNV = new Nhanvien();
                newNV.MaNV = txtIDNV.Text;
                newNV.TenNV = txtTenNV.Text;
                newNV.SDT = txt_SDT.Text;
                newNV.DiaChiNV = txtDiachi.Text;
                newNV.NgaySinhNV = dtpNgaysinh.Value.Date;
                newNV.MaCV = cboCV.SelectedValue.ToString();
                nhanVienDAL.themNhanVien(newNV);
                load_DataNV();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Nhanvien existsNV = nhanVienDAL.tim1NV(txtIDNV.Text);
            bool ktnv = nhanVienDAL.ktNV(txtIDNV.Text);
            bool kttx = nhanVienDAL.kttx(txtIDNV.Text);
            bool ktadmin = nhanVienDAL.ktAdmin(txtIDNV.Text);
            if(existsNV == null)
            {
                MessageBox.Show("Nhân viên này không tồn tại");
                return;
            }
            else
            {
                if(ktnv)
                {
                    nhanVienDAL.xoaNhanVien(txtIDNV.Text);
                }
                if(kttx)
                {
                    bool ktTX = xeDAL.kiemTraTX(txtIDNV.Text);
                    if(ktTX)
                    {
                        MessageBox.Show("Bạn không thể xóa tài xế này!");
                        return;
                    }
                    else
                    {
                        nhanVienDAL.xoaNhanVien(txtIDNV.Text);
                    }
                }
                if(ktadmin)
                {
                    int ktAdmin = nhanVienDAL.ktSLAdmin();
                    if(ktAdmin == 1)
                    {
                        MessageBox.Show("Bạn không thể xóa tất cả ADMIN");
                        return;
                    }
                    else
                    {
                        nhanVienDAL.xoaNhanVien(txtIDNV.Text);

                    }
                }
                load_DataNV();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtIDNV.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên");
                return;
            }else if(txt_SDT.TextLength <10 && txt_SDT.TextLength > 11)
            {
                MessageBox.Show("Chỉ có số điện thoại 10 hoặc 11 số mời nhập lại");
                txt_SDT.Text = "";
                return;
            }
            else if (dtpNgaysinh.Value.Date >= DateTime.Now)
            {
                MessageBox.Show("Không được nhập số ngày lớn hơn ngày hiện tại vì chưa ra đời hoặc ngày hiện tại  vì mới ra đời làm gì biết đếm tiền mà mua vé !!!");
                return;
            }
            else
            {
                Nhanvien capnhatNV = new Nhanvien();
                capnhatNV.MaNV = txtIDNV.Text;
                capnhatNV.TenNV = txtTenNV.Text;
                capnhatNV.SDT = txt_SDT.Text;
                capnhatNV.DiaChiNV = txtDiachi.Text;
                capnhatNV.NgaySinhNV = dtpNgaysinh.Value.Date;
                capnhatNV.MaCV = cboCV.SelectedValue.ToString();
                nhanVienDAL.suaNhanVien(capnhatNV);
                load_DataNV();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }

        private void load_CBOCV()
        {
            var data = chucVuDAL.loadChucVu();
            cboCV.DataSource = data;
            cboCV.DisplayMember = "TenCV";
            cboCV.ValueMember = "MaCV";
        }
        private void load_DataNV()
        {
            var data = nhanVienDAL.loadNV(cboCV.SelectedValue.ToString());
            dgvNV.DataSource = data;

        }
        private void cboCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_DataNV();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtIDNV.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên");
                return;
            }
            else
            {
                bool ktadmin = nhanVienDAL.ktAdmin(txtIDNV.Text);
                bool ktnv = nhanVienDAL.ktNV(txtIDNV.Text);
                if (ktadmin || ktnv)
                {
                    if (txtMK.Text != txtNLMK.Text)
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp");
                        return;
                    }
                    else
                    {
                        Nhanvien capnhatMK = new Nhanvien();
                        capnhatMK.MaNV = txtIDNV.Text;
                        capnhatMK.MatKhau = txtNLMK.Text;
                        nhanVienDAL.doiMatKhau(capnhatMK, txtMK.Text);
                        load_DataNV();
                    }
                }
                else
                {
                    MessageBox.Show("Tài xế không có tài khoản");
                    return;
                }

            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvNV.SelectedCells[0].OwningRow.Cells["Username"].Value;
            var data1 = dgvNV.SelectedCells[0].OwningRow.Cells["TenNV"].Value;
            var data2 = dgvNV.SelectedCells[0].OwningRow.Cells["SODT"].Value;
            var data3 = dgvNV.SelectedCells[0].OwningRow.Cells["NgaySinh"].Value;
            var data4 = dgvNV.SelectedCells[0].OwningRow.Cells["DiaChi"].Value;
            txtIDNV.Text = data.ToString();
            txtTenNV.Text = data1.ToString();
            txt_SDT.Text = data2.ToString();
            dtpNgaysinh.Text = data3.ToString();
            txtDiachi.Text = data4.ToString();
        }

    }
}
