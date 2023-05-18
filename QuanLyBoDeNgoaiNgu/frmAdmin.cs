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
        Subject subjectModel;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void Btn_ClickAnh(object sender, EventArgs e)
        {
            // Lấy level tiếng anh
            subjectModel = model.Subjects.FirstOrDefault(l => l.Name == "English");
            //
            frmQuanLy frmQuanLy = new frmQuanLy(userModel, subjectModel);
            frmQuanLy.Show();
        }

        private void Btn_ClickNhat(object sender, EventArgs e)
        {
            // Lấy level Tiếng Nhật
            subjectModel = model.Subjects.FirstOrDefault(l => l.Name == "Japanese");

            frmQuanLy frmQuanLy = new frmQuanLy(userModel, subjectModel);
            frmQuanLy.Show();
        }

        public frmAdmin(Account account)
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();

            btnTiengAnh.Click += Btn_ClickAnh;
            //btnTiengHan.Click += Btn_Click;
            btnTiengNhat.Click += Btn_ClickNhat;

            // Lấy user dựa trên account 
            userModel = model.Users.FirstOrDefault(u => u.UserID == account.AccountID);

            lbName.Text = userModel.FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
