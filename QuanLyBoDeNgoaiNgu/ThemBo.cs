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
    public partial class ThemBo : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;
        public ThemBo()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
        }

        private void ThemBo_Load(object sender, EventArgs e)
        {
            Data.LoadData(dgvChuDe, model.GroupQuestions.ToList());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            model.GroupQuestions.Add(new GroupQuestion
            {
                Name = tbChuDe.Text
            });

            model.SaveChanges();

            Data.LoadData(dgvChuDe, model.GroupQuestions.ToList());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
