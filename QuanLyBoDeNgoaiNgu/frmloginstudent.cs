using QuanLyBoDeNgoaiNgu.Entities;
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
            Account account;
            account = model.Accounts.Single(a => a.Username == textBox1.Text && a.Password == textBox2.Text);

            if (account != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "lẹ lên vào mà thi");

                this.Hide();

                trangkhivaostudent trangkhivaostudent = new trangkhivaostudent();
                trangkhivaostudent.Closed += (s, args) => this.Close();
                // Lấy tên từ database ra
                User user;
                user = model.Users.Single(u => u.UserID == account.AccountID);
                trangkhivaostudent.label1.Text = user.StudentID;
                trangkhivaostudent.label2.Text = user.FullName;
                
                trangkhivaostudent.Show();
                
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
