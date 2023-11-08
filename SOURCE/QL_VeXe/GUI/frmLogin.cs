using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        NhanVienDAL db = new NhanVienDAL();
        public static string isadmin;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if(a==DialogResult.Yes)
            {
                Application.Exit();
            }    
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="" || txtUsername.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu!");
                return;
            }
            else
            {
                if(db.kiemTraDangNhap(txtUsername.Text, txtPassword.Text))
                {
                    this.Hide();
                    isadmin = txtUsername.Text;
                    frmMain fmain = new frmMain();
                    fmain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                    return;
                }    
            }
           
                
                                                   
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmLogin_KeyDown;
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDN_Click(sender, e);
            }
        }
    }
}
