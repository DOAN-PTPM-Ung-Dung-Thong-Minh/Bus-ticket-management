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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frmVexe : Form
    {
        VeXeDAL veXeDAL = new VeXeDAL();
        ChuyenXeDAL chuyenXeDAL = new ChuyenXeDAL();
        KhachHangDAL khachHangDAL = new KhachHangDAL();
        public frmVexe()
        {
            InitializeComponent();            
        }
           
        private void btnDongVX_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }       

        private void frmVexe_Load(object sender, EventArgs e)
        {
            load_cboCX();
            load_DataVX();            
        }
        private void load_DataVX()
        {
            dgvVexe.DataSource = veXeDAL.load_DataVeXe(cboCX.SelectedValue.ToString());
        }        

        private void load_cboCX()
        {
            cboCX.DataSource = chuyenXeDAL.load_CX();
            cboCX.DisplayMember = "TenChuyen";
            cboCX.ValueMember = "MaChuyen";
        }
        private void cboCX_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_DataVX();        
        }

        private void btnTimVX_Click(object sender, EventArgs e)
        {
           
                if (txtMAVE.Text == "" && txtMAKH.Text == "")
                {
                    dgvVexe.DataSource = veXeDAL.timVX1(dtpNgaydi.Value.Date, cboCX.SelectedValue.ToString());
                }
                if (txtMAVE.Text != "" && txtMAKH.Text=="")
                {
                    dgvVexe.DataSource = veXeDAL.timVX2(txtMAVE.Text);
                        
                }
                if (txtMAKH.Text != "" && txtMAVE.Text=="")
                {
                    dgvVexe.DataSource = veXeDAL.timVX3(txtMAKH.Text);
                }
                if (txtMAKH.Text != "" && txtMAVE.Text != "")
                {
                    dgvVexe.DataSource = veXeDAL.timVX4(txtMAVE.Text, txtMAKH.Text);
                }               
                
            
        }
        private void btnDatve_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDatve fdv = new frmDatve();
            fdv.ShowDialog();
        }
        private void btnXoaVX_Click(object sender, EventArgs e)
        {
            string mave = txtMAVE.Text;
            string makh = txtMAKH.Text;

            bool existVe = veXeDAL.existsVeXe(mave);
            bool existKH = veXeDAL.existKH(makh);
            if (!existVe)
            {
                MessageBox.Show("Không có vé này trên hệ thống");
                return;
            }
            if (!existKH)
            {
                MessageBox.Show("Khách hàng không có thông tin vé trên hệ thống");
                return;
            }
            veXeDAL.xoaVX(mave, makh);
            load_DataVX();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load_DataVX();
        }

        private void dgvVexe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvVexe.SelectedCells[0].OwningRow.Cells["MAVE"].Value;
            var data1 = dgvVexe.SelectedCells[0].OwningRow.Cells["MAKH"].Value;
            var data2 = dgvVexe.SelectedCells[0].OwningRow.Cells["NgayDi"].Value;
            txtMAVE.Text = data.ToString();
            txtMAKH.Text = data1.ToString();
            dtpNgaydi.Text = data2.ToString();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string data = dgvVexe.CurrentRow.Cells[0].Value.ToString();
            string data1 = dgvVexe.CurrentRow.Cells[1].Value.ToString();
            string data2 = dgvVexe.CurrentRow.Cells[2].Value.ToString();
            string data3 = dgvVexe.CurrentRow.Cells[3].Value.ToString();
            string data4 = dgvVexe.CurrentRow.Cells[4].Value.ToString();
            string data5 = dgvVexe.CurrentRow.Cells[5].Value.ToString();
            string data6 = dgvVexe.CurrentRow.Cells[6].Value.ToString();
            string data7 = dgvVexe.CurrentRow.Cells[7].Value.ToString();
            WordExport r = new WordExport();
            r.BanVeXe(data5,data,data1,data2,data3,data6,data7,data4);
        }
    }
}
