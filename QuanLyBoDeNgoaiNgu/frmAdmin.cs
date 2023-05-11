using QuanLyBoDeNgoaiNgu.Entities;
using QuanLyBoDeNgoaiNgu.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBoDeNgoaiNgu
{
    public partial class frmAdmin : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;
        User userModel;
        Level levelModel;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            frmQuanLy frmQuanLy = new frmQuanLy(userModel);
            frmQuanLy.Show();
        }

        public frmAdmin(Account account)
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();

            btnTiengAnh.Click += Btn_Click;
            //btnTiengHan.Click += Btn_Click;
            btnTiengNhat.Click += Btn_Click;

            // Lấy user dựa trên account 
            var userModel = model.Users.FirstOrDefault(u => u.UserID == account.AccountID);

            lbName.Text = userModel.FullName;
        }
    }
}
