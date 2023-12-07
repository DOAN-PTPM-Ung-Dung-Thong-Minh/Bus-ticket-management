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
    public partial class frmDatve : Form
    {
        VeXeDAL veXeDAL = new VeXeDAL();
        ChuyenXeDAL chuyenXeDAL = new ChuyenXeDAL();
        KhachHangDAL khachHangDAL = new KhachHangDAL();
        TuyenXeDAL tuyenXeDAL = new TuyenXeDAL();
        public frmDatve()
        {
            InitializeComponent();
        }
        String[] vitri = { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" };
        private void btnVexe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVexe fvx = new frmVexe();
            fvx.Show();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }

        private void frmDatve_Load(object sender, EventArgs e)
        {
            load_cboCX();
            loadCbKH();
            //load_cbo_Vitri();
            loadData_CX();
            load_DataTX();
        }
                
        private void btnKiemtra_Click(object sender, EventArgs e)
        {

            dgvVe.DataSource = veXeDAL.kiemTraTTVe(cboCX.SelectedValue.ToString(), dateTimePicker1.Value.Date);
            load_cbo_ViTriChuaDuocDat();
            if (dateTimePicker1.Value.Date >= DateTime.Now)
            {
                MessageBox.Show("Chỉ có thể đặt ngày hiện tại");
                return;
            }

        }
        private void btnDatve_Click(object sender, EventArgs e)
        {
            string cbovt = cboVitri.SelectedValue.ToString();
            string cbocx = cboCX.SelectedValue.ToString();
            if(cbb_kh.SelectedValue.ToString() =="")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng");
                return;
            }

            bool exitsVitri = veXeDAL.existsVitri(cbocx, dateTimePicker1.Value.Date, cbovt);


            if (exitsVitri)
            {
                MessageBox.Show("Vị trí này đã được mua");
                return;
            }
            else
            {
                bool existKH = veXeDAL.existKH(cbb_kh.SelectedValue.ToString());
                bool existKH_VE = veXeDAL.existsKH_VE(cbocx, dateTimePicker1.Value.Date, cbb_kh.SelectedValue.ToString());
                if (!existKH)
                {
                    MessageBox.Show("Khách hàng không tồn tại");
                    return;
                }
                else if (existKH_VE)
                {
                    MessageBox.Show("Khách hàng này đã mua vé rồi");
                    return;
                }
                else
                {
                    if (dateTimePicker1.Value.Date < DateTime.Today)
                    {
                        MessageBox.Show("Ngày đi không hợp lệ");
                        return;
                    }
                    else
                    {
                        var xacnhan = MessageBox.Show("Thông tin vé xe:\n" +
                                              cboCX.Text + "\n" +
                                                                dateTimePicker1.Value.Date.ToString() + "\n" +
                                                                                  cboVitri.Text,
                                                                                                    "Xác nhận thông tin vé", MessageBoxButtons.YesNo);
                        if (xacnhan == DialogResult.Yes)
                        {
                            VeXe newVe = new VeXe();
                            newVe.CCCD = cbb_kh.SelectedValue.ToString();
                            newVe.MaChuyen = cbocx;
                            newVe.NgayDi = dateTimePicker1.Value.Date;
                            newVe.ViTri = cbovt;
                            veXeDAL.themVX(newVe);
                        }
                    }

                }

            }
        }
        private void load_cboCX()
        {
            cboCX.DataSource = chuyenXeDAL.load_CX();
            cboCX.DisplayMember = "TenChuyen";
            cboCX.ValueMember = "MaChuyen";
        }


        private void load_cbo_Vitri()
        {            
            var data = vitri.ToArray();
            cboVitri.DataSource = data;
        }

        private void load_cbo_ViTriChuaDuocDat()
        {
            cboVitri.DataSource = veXeDAL.load_VitriChuaDuocDat(cboCX.SelectedValue.ToString(), dateTimePicker1.Value.Date);
        }

        private void loadCbKH()
        {
            cbb_kh.DataSource = khachHangDAL.loadKH();
            cbb_kh.DisplayMember = "TenKH";
            cbb_kh.ValueMember = "CCCD";
        }

        private void btnSuave_Click(object sender, EventArgs e)
        {
            string makh = cbb_kh.SelectedValue.ToString();
            string cbovt = cboVitri.SelectedValue.ToString();
            string cbocx = cboCX.SelectedValue.ToString();

            bool existKH = veXeDAL.existKH(cbb_kh.SelectedValue.ToString());
            bool existKH_VE = veXeDAL.existsKH_VE(cbocx, dateTimePicker1.Value.Date, cbb_kh.SelectedValue.ToString());
            if (makh == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng");
                return;
            }
            else if (!existKH)
            {
                MessageBox.Show("Khách hàng không tồn tại");
                return;
            }
            else if (!existKH_VE)
            {
                MessageBox.Show("Khách hàng chưa mua vé");
                return;
            }
            else if (dateTimePicker1.Value.Date >= DateTime.Now)
            {
                MessageBox.Show("Không được nhập số ngày lớn hơn ngày hiện tại vì chưa ra đời hoặc ngày hiện tại  vì mới ra đời làm gì biết đếm tiền mà mua vé !!!");
                return;
            }
            else
            {
                bool exitsVitri = veXeDAL.existsVitri(cbocx, dateTimePicker1.Value.Date, cbovt);
                if (exitsVitri)
                {
                    MessageBox.Show("Vị trí nãy đã được mua");
                    return;
                }
                else
                {
                    VeXe vx = new VeXe();
                    vx.CCCD = cbb_kh.SelectedValue.ToString();
                    vx.MaChuyen = cbocx;
                    vx.NgayDi = dateTimePicker1.Value.Date;
                    vx.ViTri = cbovt;
                    veXeDAL.suaVX(vx);
                    MessageBox.Show("Cập nhật vé thành công");
                }
            }
        }
        private void loadData_CX()
        {

            dgvCX.DataSource = chuyenXeDAL.loadChuyenXe_DatVe();

        }
        private void load_DataTX()
        {
            dgvTX.DataSource = tuyenXeDAL.load_DataTX();
        }

    }
        
}
