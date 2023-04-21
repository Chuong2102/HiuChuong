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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //
            //this.Size = new System.Drawing.Size(1089, 605);
        }

        private void btnDNadmin_Click(object sender, EventArgs e)
        {
            frmloginadmin frmloginadmin = new frmloginadmin();
            frmloginadmin.Show();
        }

        private void btnDNsinhvien_Click(object sender, EventArgs e)
        {
            frmloginstudent frmloginstudent = new frmloginstudent();
            frmloginstudent.Show();
        }
    }
}
