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
            //
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            Answer answer = new Answer();
            
            answer.Text = textBox2.Text;
            
            model.Answers.Add(answer);

            var levelId = model.Levels.FirstOrDefault(
                c => c.LevelName == cmbLevel.SelectedItem.ToString()).LevelID;

            question.Level = new Level();
            question.Level.LevelID = levelId;

            model.Questions.Add(question);

            model.SaveChanges();
        }
    }
}
