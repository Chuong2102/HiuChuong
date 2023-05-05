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
    public partial class trangTiengAnh : Form
    {
        public trangTiengAnh()
        {
            InitializeComponent();

            btnA1.Click += (sender, e) => ShowBocDeForm();
            btnA2.Click += (sender, e) => ShowBocDeForm();
            btnB1.Click += (sender, e) => ShowBocDeForm();
            btnB2.Click += (sender, e) => ShowBocDeForm();
            btnC1.Click += (sender, e) => ShowBocDeForm();
            btnC2.Click += (sender, e) => ShowBocDeForm();
        }

        private void trangTiengAnh_Load(object sender, EventArgs e)
        {

        }

        public void ShowBocDeForm()
        {
            BocDe de = new BocDe();
            de.Show();
        }
    }
}
