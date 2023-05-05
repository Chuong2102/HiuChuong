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
    public partial class ThemBoDapAn : Form
    {
        public ThemBoDapAn()
        {
            InitializeComponent();
        }

        private void btnTiengAnh_Click(object sender, EventArgs e)
        {
            ThemBo themBo = new ThemBo();
            themBo.Show();
        }
    }
}
