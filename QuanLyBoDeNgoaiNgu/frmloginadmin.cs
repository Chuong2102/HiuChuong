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
using System.Data.Entity;

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
            if(model.Accounts.Select(c => c.Username == textBox1.Text && c.Password == textBox2.Text).FirstOrDefault() == true)
            {
                MessageBox.Show("Dang nhap thanh cong");
            }
            else
            {
                MessageBox.Show("Dang nhap k thanh cong");
            }

            
        }
    }
}
