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
    public partial class frmQuanLy : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;
        User userModel;
        public frmQuanLy()
        {
            InitializeComponent();
        }

        public frmQuanLy(User user)
        {
            InitializeComponent();
            userModel = user;


        }

        private void mnsQlCauHoi_Click(object sender, EventArgs e)
        {
            QuanLyCauHoi frmQlCauHoi = new QuanLyCauHoi();
            frmQlCauHoi.Show();
        }
    }
}
