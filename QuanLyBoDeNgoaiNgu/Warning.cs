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
    public partial class Warning : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;
        QuanLySuatThi quanLySuatThi;
        public Warning()
        {
            InitializeComponent();
        }

        public Warning(QuanLySuatThi quanLySuatThi)
        {
            InitializeComponent();
            this.quanLySuatThi = quanLySuatThi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quanLySuatThi.Delete();
            quanLySuatThi.Refesh();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
