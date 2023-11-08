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
    public partial class frmTuyenxe : Form
    {
        TuyenXeDAL tuyenXeDAL = new TuyenXeDAL();
        ChuyenXeDAL chuyenXeDAL = new ChuyenXeDAL();
        public frmTuyenxe()
        {
            InitializeComponent();
        }

        private void btnDongTX_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }

        private void frmTuyenxe_Load(object sender, EventArgs e)
        {
            load_DataTX();
        }
        private void btnTimTX_Click(object sender, EventArgs e)
        {
            //using (BanVeXeDataContext db = new BanVeXeDataContext())
            //{
            //    if (txtMaTuyen.Text != "")
            //    {
            //        var timkh = db.TuyenXes.Where(t=>t.MaTuyen == txtMaTuyen.Text)
            //                .Select(t => new
            //                {
            //                    MATUYEN = t.MaTuyen,
            //                    TENTUYEN = t.TenTuyen,
            //                    GIAVE = t.GiaVe
            //                });
            //        dgvTX.DataSource = timkh;
            //    }
            //    else
            //    {
            //        load_DataTX();
            //    }

            //}

            if (txtMaTuyen.Text != "")
            {
                dgvTX.DataSource = tuyenXeDAL.timTX(txtMaTuyen.Text);
            }
            else
            {
                load_DataTX();
            }
        }
        private void btnCapnhatTX_Click(object sender, EventArgs e)
        {
            //using (BanVeXeDataContext db = new BanVeXeDataContext())
            //{
            //    if (txtMaTuyen.Text == null)
            //    {
            //        MessageBox.Show("Bạn chưa nhập mã tuyến!");
            //        return;
            //    }
            //    else
            //    {
            //        TuyenXe capnhatTX = db.TuyenXes.Single(t=>t.MaTuyen == txtMaTuyen.Text);
            //        capnhatTX.TenTuyen = txtTenTuyen.Text;
            //        capnhatTX.GiaVe = int.Parse(txtGiaVe.Text);                    
            //    }
            //    db.SubmitChanges();
            //    load_DataTX();
            //}

            if (txtMaTuyen.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập mã tuyến!");
                return;
            }
            else
            {
                TuyenXe tuyenXe = new TuyenXe();
                tuyenXe.MaTuyen = txtMaTuyen.Text;
                tuyenXe.TenTuyen = txtTenTuyen.Text;
                tuyenXe.GiaVe = int.Parse(txtGiaVe.Text);
                tuyenXeDAL.suaTuyenXe(tuyenXe);
                load_DataTX();
            }
        }

        private void btnXoaTX_Click(object sender, EventArgs e)
        {
            //using (BanVeXeDataContext db = new BanVeXeDataContext())
            //{
            //    TuyenXe existTX = db.TuyenXes.Where(t=>t.MaTuyen.Equals(txtMaTuyen.Text)).FirstOrDefault();
            //    if (existTX == null)
            //    {
            //        MessageBox.Show("Không có thông tin chuyến xe này!");
            //        return;
            //    }
            //    else
            //    {
            //        ChuyenXe cx = db.ChuyenXes.Where(c => c.MaTuyen.Equals(txtMaTuyen.Text)).FirstOrDefault();
            //        if (cx != null)
            //        {
            //            MessageBox.Show("Không thể xóa tuyến xe này!");
            //            return;
            //        }
            //        else
            //        {
            //            db.TuyenXes.DeleteOnSubmit(existTX);
            //            db.SubmitChanges();
            //        }
            //    }
            //    load_DataTX();
            //}

            bool existTX = tuyenXeDAL.checkMaTuyen(txtMaTuyen.Text);
            if (!existTX)
            {
                MessageBox.Show("Không có thông tin chuyến xe này!");
                return;
            }
            else
            {
                bool chuyenXe = chuyenXeDAL.checkMaTuyen(txtMaTuyen.Text);
                if (chuyenXe)
                {
                    MessageBox.Show("Không thể xóa tuyến xe này!");
                    return;
                }
                else
                {
                    tuyenXeDAL.xoaTuyenXe(txtMaTuyen.Text);
                }
            }
            load_DataTX();
        }

        private void btnThemTX_Click(object sender, EventArgs e)
        {
            //using (BanVeXeDataContext db = new BanVeXeDataContext())
            //{
            //    bool existTX = db.TuyenXes.Where(k => k.MaTuyen == txtMaTuyen.Text).Count() > 0;
            //    if (existTX)
            //    {
            //        MessageBox.Show("Tuyến xe này đã tồn tại");
            //        return;
            //    }
            //    else
            //    {
            //        TuyenXe newTX = new TuyenXe();
            //        newTX.MaTuyen = txtMaTuyen.Text;
            //        newTX.TenTuyen = txtTenTuyen.Text;
            //        newTX.GiaVe = int.Parse(txtGiaVe.Text);
            //        db.TuyenXes.InsertOnSubmit(newTX);
            //        db.SubmitChanges();
            //    }
            //    load_DataTX();
            //}

            if (txtMaTuyen.Text == "" || txtTenTuyen.Text == "" || txtGiaVe.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return;
            }
            bool existTX = tuyenXeDAL.checkMaTuyen(txtMaTuyen.Text);
            //bool existGTX = tuyenXeDAL.checkGiaVe(txtGiaVe.Text);
            if (existTX)
            {
                MessageBox.Show("Tuyến xe này đã tồn tại");
                return;
            }
            else
            {
                TuyenXe tx = new TuyenXe();
                tx.MaTuyen = txtMaTuyen.Text;
                tx.TenTuyen = txtTenTuyen.Text;
                tx.GiaVe = int.Parse(txtGiaVe.Text);
                tuyenXeDAL.themTX(tx);
                load_DataTX();
            }
            
        }
        private void load_DataTX()
        {
            dgvTX.DataSource = tuyenXeDAL.load_DataTX();
        }

        private void dgvTX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvTX.SelectedCells[0].OwningRow.Cells["Column1"].Value;
            var data1 = dgvTX.SelectedCells[0].OwningRow.Cells["Column2"].Value;
            var data2 = dgvTX.SelectedCells[0].OwningRow.Cells["Column3"].Value;

            txtMaTuyen.Text = data.ToString();
            txtTenTuyen.Text = data1.ToString();
            txtGiaVe.Text = data2.ToString();

        }

        private void txtGiaVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
