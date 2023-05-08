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
    
    public partial class trangTiengAnh : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;
        public trangTiengAnh()
        {
            InitializeComponent();

            var comp = model.Compositions.FirstOrDefault(
                c => c.CompositionDate == DateTime.Now);
            if (comp != null)
            {
                button5.Enabled = true;
            }
            else { button5.Enabled = false; }
        }

        private void trangTiengAnh_Load(object sender, EventArgs e)
        {

        }
    }
}
