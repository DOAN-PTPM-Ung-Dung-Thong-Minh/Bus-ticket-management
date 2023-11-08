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
    public partial class frmXe : Form
    {
        XeDAL xeDAL = new XeDAL();
        ChuyenXeDAL chuyenXeDAL = new ChuyenXeDAL();
        NhanVienDAL nhanVienDAL = new NhanVienDAL();
        public frmXe()
        {
            InitializeComponent();
        }

        private void frmXe_Load(object sender, EventArgs e)
        {
            load_CBOTX();
            load_DataXe();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //using (BanVeXeDataContext db= new BanVeXeDataContext())
            //{
            //    bool existsXe = db.Xes.Where(x => x.MaXe.Equals(txtMAXE.Text)).Count() > 0;
            //    bool ktTaixe = db.Xes.Where(x => x.MaTX.Equals(cboTAIXE.SelectedValue)).Count() == 1;
            //    if(existsXe)
            //    {
            //        MessageBox.Show("Mã xe này đã tồn tại");
            //        return;
            //    }
            //    else
            //    {
            //        Xe newXe = new Xe();
            //        newXe.MaXe = txtMAXE.Text;
            //        newXe.TTXe = txtTTXE.Text;
            //        if(!ktTaixe)
            //        {
            //            newXe.MaTX = cboTAIXE.SelectedValue.ToString();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Tài xế này đã nhận xe");
            //            return;                        
            //        }
            //        db.Xes.InsertOnSubmit(newXe);
            //        db.SubmitChanges();
            //    }

            //    load_DataXe();
            //}
            //
            if (txtTTXE.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin xe");
                return;
            }
            else
            {
                if (xeDAL.kiemTraXe(txtTTXE.Text))
                {
                    MessageBox.Show("Mã xe này đã tồn tại");
                    return;
                }
                else
                {
                    if (xeDAL.kiemTraTX(cboTAIXE.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Tài xế này đã nhận xe");
                        return;
                    }
                    else
                    {
                        Xe xe = new Xe();
                        xe.TTXe = txtTTXE.Text;
                        xe.MaNV = cboTAIXE.SelectedValue.ToString();
                        xeDAL.themXe(xe);
                        load_DataXe();
                    }
                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            //using (BanVeXeDataContext db = new BanVeXeDataContext())
            //{
            //    bool ktTaixe = db.Xes.Where(x => x.MaTX.Equals(cboTAIXE.SelectedValue)).Count() == 1;
            //    if (txtMAXE.Text==null)
            //    {
            //        MessageBox.Show("Bạn chưa nhập mã xe");
            //        return;
            //    }
            //    else
            //    {
            //        Xe capnhatXe = db.Xes.Single(x => x.MaXe.Equals(txtMAXE.Text));
            //        capnhatXe.TTXe = txtTTXE.Text;  
            //        if(!ktTaixe)
            //        {
            //            capnhatXe.MaTX = cboTAIXE.SelectedValue.ToString();
            //        }
            //        else {
            //            MessageBox.Show("Tài xế này đã nhận xe");
            //                }
            //    }
            //    db.SubmitChanges();
            //    load_DataXe();
            //}

            bool ktTaixe = xeDAL.kiemTraTX(cboTAIXE.SelectedValue.ToString());
            if (txtTTXE.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin xe");
                return;
            }
            else
            {
                if (ktTaixe)
                {
                    MessageBox.Show("Tài xế này đã nhận xe");
                    return;
                }
                else
                {
                    Xe xe = new Xe();
                    xe.TTXe = txtTTXE.Text;
                    xe.MaNV = cboTAIXE.SelectedValue.ToString();
                    xeDAL.capNhatXe(xe);
                    load_DataXe();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //string maxe = txtMAXE.Text;
            //using (BanVeXeDataContext db = new BanVeXeDataContext())
            //{
            //    Xe existXe = db.Xes.Where(x => x.MaXe.Equals(maxe)).FirstOrDefault();
            //    if (existXe == null)
            //    {
            //        MessageBox.Show("Không có chuyến xe này");
            //        return;
            //    }
            //    else
            //    {
            //        ChuyenXe cx = db.ChuyenXes.Where(c => c.MaXe.Equals(maxe)).FirstOrDefault();
            //        if(cx!=null)
            //        {
            //            MessageBox.Show("Xe này đang chạy trong 1 chuyến xe\nBạn không thể xóa",
            //                                "Thông báo");
            //            return;
            //        }
            //        else
            //        {
            //            db.Xes.DeleteOnSubmit(existXe);
            //            db.SubmitChanges();
            //        }
            //        load_DataXe();
            //    }
            //}

            string maxe = txtTTXE.Text;
            bool existXe = xeDAL.kiemTraXe(maxe);
            if (!existXe)
            {
                MessageBox.Show("Không có chuyến xe này");
                return;
            }
            else
            {
                bool chuyenXe = chuyenXeDAL.ktCXBangMaXe(maxe);
                if (chuyenXe)
                {
                    MessageBox.Show("Xe này đang chạy trong 1 chuyến xe\nBạn không thể xóa",
                                                               "Thông báo");
                    return;
                }
                else
                {
                    xeDAL.xoaXe(maxe);
                    load_DataXe();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();

        }
        private void load_CBOTX()
        {
            cboTAIXE.DataSource = nhanVienDAL.loadTaiXe();
            cboTAIXE.DisplayMember = "TenNV";
            cboTAIXE.ValueMember = "MaNV";
        }
       
            
        
        private void load_DataXe()
        {
            //using (BanVeXeDataContext db = new BanVeXeDataContext())
            //{
            //    var data = db.Xes.Select(x => new { 
            //        MAXE= x.MaXe,
            //        TTXE= x.TTXe,
            //        TENTX= x.Nhanvien.TenNV
            //    });
            //    dgvXe.DataSource= data;
            //}    
            dgvXe.DataSource = xeDAL.loadDataXe();
        }
        
        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data1 = dgvXe.SelectedCells[0].OwningRow.Cells["ThongtinXe"].Value;
            var data2 = dgvXe.SelectedCells[0].OwningRow.Cells["TenTX"].Value;
            var data3 = dgvXe.SelectedCells[0].OwningRow.Cells["MATX"].Value;
            txtTTXE.Text = data1.ToString();
            cboTAIXE.Text = data2.ToString();
            txtMaNV.Text = data3.ToString();
        }

    }
}
