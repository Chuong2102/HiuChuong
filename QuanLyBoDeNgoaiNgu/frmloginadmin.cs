using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBoDeNgoaiNgu.Infrastructure;
using QuanLyBoDeNgoaiNgu.Entities;

namespace QuanLyBoDeNgoaiNgu
{
    public partial class frmloginadmin : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;

        public frmloginadmin()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
        }

        private void lblMaDangNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var account = model.Accounts.Single(c => c.Username == textBox1.Text && c.Password == textBox2.Text && c.Role.RoleName == "Admin");

                if (account != null)
                {
                    // Show dialog
                    MessageBox.Show("Dang nhap thanh cong");

                    // Ẩn form hiện tại
                    this.Hide();
                    // Tạo mới form Admin
                    frmAdmin loginadmin = new frmAdmin(account);
                    // Close()
                    loginadmin.Closed += (s, args) => this.Close();
                    // Hiện form mới
                    loginadmin.Show();
                }
                else
                {
                    MessageBox.Show("Dang nhap ko thanh cong");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Dang nhap ko thanh cong");
            } 
            
            
        }
    }
}
