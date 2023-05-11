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
    public partial class ThemCauHoi : Form
    {
        List<Level> levels;
        QuanLyBoDeNgoaiNguModel1 model;
        public ThemCauHoi()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
            
        }

        private void ThemCauHoi_Load(object sender, EventArgs e)
        {
            // Lấy level
            levels = model.Levels.ToList();

            // lay database
            foreach (Level level in levels)
            {
                if (level.LevelName != null)
                {
                    cmbLevel.Items.Add(level.LevelName);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            question.Answers = new List<Answer>();

            question.Text = tbCauHoi.Text;
            question.Answers.Add(new Answer { Text = tbA.Text});
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
