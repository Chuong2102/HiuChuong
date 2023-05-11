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
    public partial class BocDe : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;

        User userModel;
        Subject subject;

        public BocDe()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThiSinhVien formThi = new frmThiSinhVien();

            // Bốc đề
            Exam baiThi = new Exam();
            // 



            formThi.Show();
        }
    }
}
