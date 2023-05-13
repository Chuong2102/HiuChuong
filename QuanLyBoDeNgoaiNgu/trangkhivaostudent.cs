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
    public partial class trangkhivaostudent : Form
    {
        QuanLyBoDeNgoaiNguModel1 model = new QuanLyBoDeNgoaiNguModel1();
        User userModel;
        Subject subjectModel;

        public trangkhivaostudent()
        {
            InitializeComponent();
        }

        public trangkhivaostudent(User user)
        {
            InitializeComponent();

            userModel = user;
            //
            lbHoTen.Text = userModel.FullName;
            lbMaSV.Text = userModel.StudentID;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trangTiengAnh trangTiengAnh = new trangTiengAnh(userModel, subjectModel);
            trangTiengAnh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trangTiengNhat trangTiengNhat = new trangTiengNhat();
            trangTiengNhat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trangTiengTrung trangTiengTrung = new trangTiengTrung();
            trangTiengTrung.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            trangTiengHan trangTiengHan = new trangTiengHan();
            trangTiengHan.Show();
        }
    }
}
