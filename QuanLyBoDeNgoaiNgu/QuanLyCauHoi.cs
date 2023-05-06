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
    public partial class QuanLyCauHoi : Form
    {
        QuanLyBoDeNgoaiNguModel1 model = new QuanLyBoDeNgoaiNguModel1();
        public QuanLyCauHoi()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ThemCauHoi themCauHoi = new ThemCauHoi();
            themCauHoi.Show();
        }

        private void QuanLyCauHoi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBoDeNgoaiNguDataSet.Questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.quanLyBoDeNgoaiNguDataSet.Questions);
            dataGridView1.DataSource = model.Questions.ToString();

        }
    }
}
