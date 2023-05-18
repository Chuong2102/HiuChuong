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
        Subject subjectModel;

        public frmQuanLy()
        {
            InitializeComponent();
        }

        public frmQuanLy(User user)
        {
            InitializeComponent();

            userModel = user;
        }
        public frmQuanLy(User user, Subject subject)
        {
            InitializeComponent();

            userModel = user;
            subjectModel = subject;

            //
            lbName.Text = userModel.FullName;
        }

        private void mnsQlCauHoi_Click(object sender, EventArgs e)
        {
            QuanLyCauHoi frmQlCauHoi = new QuanLyCauHoi(userModel, subjectModel);
            frmQlCauHoi.Show();
        }

        private void tsmQuanLySuatThi_Click(object sender, EventArgs e)
        {
            QuanLySuatThi frmQuanLySuatThi = new QuanLySuatThi(userModel, subjectModel);
            frmQuanLySuatThi.Show();
        }
    }
}
