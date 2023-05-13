using QuanLyBoDeNgoaiNgu.Entities;
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
    public partial class frmThiSinhVien : Form
    {
        Exam examModel;
        public frmThiSinhVien()
        {
            InitializeComponent();
        }

        public frmThiSinhVien(Exam exam)
        {
            this.examModel = exam;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmThiSinhVien_Load(object sender, EventArgs e)
        {

        }
    }
}
