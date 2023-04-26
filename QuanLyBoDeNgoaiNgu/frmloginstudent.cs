using QuanLyBoDeNgoaiNgu.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBoDeNgoaiNgu
{
    public partial class frmloginstudent : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;
        public frmloginstudent()
        {
            model = new QuanLyBoDeNgoaiNguModel1();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (model.Accounts.Select(a => a.Username == textBox1.Text && a.Password == textBox2.Text).FirstOrDefault())
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
