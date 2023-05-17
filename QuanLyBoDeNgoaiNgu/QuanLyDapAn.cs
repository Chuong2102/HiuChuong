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
    public partial class QuanLyDapAn : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;
        public QuanLyDapAn()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Answer> answerList = new List<Answer>();

            var query = answerList.Where(c => c.Text.Contains(textBox1.Text)).ToList();
            if (textBox1.Text != null)
            {
                Data.LoadData(dgvDapAn, query);
            }
            else
            {

            }
        }
    }
}
