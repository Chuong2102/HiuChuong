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
        Answer answer;
        List<GroupQuestion> groupQuestions;
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

            // Lấy GroupQuestion
            groupQuestions = model.GroupQuestions.ToList();

            // lay database
            foreach (GroupQuestion groupQuestion in groupQuestions)
            {
                if (groupQuestion.Name != null)
                {
                    cmbChuDe.Items.Add(groupQuestion.Name);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            question.Answers = new List<Answer>();

            Answer a = new Answer();
            Answer b = new Answer();
            Answer c = new Answer();
            Answer d = new Answer();

            a.Text = tbA.Text;
            b.Text = tbB.Text;
            c.Text = tbC.Text;
            d.Text = tbD.Text;

            question.Text = tbCauHoi.Text;

            question.Answers.Add(a);
            question.Answers.Add(b);
            question.Answers.Add(c);
            question.Answers.Add(d);

            

            model.Answers.AddRange(question.Answers);

            if (rdbA.Checked )
            {
                question.CorrectAnswerID = a.AnswerID;
            }
            else
            if (rdbB.Checked)
            {
                question.CorrectAnswerID = b.AnswerID;
            }
            else
            if (rdbC.Checked)
            {
                question.CorrectAnswerID = c.AnswerID;
            }
            else
            if (rdbD.Checked)
            {
                question.CorrectAnswerID = d.AnswerID;
            }

            // Loi thang level ra

            var le = model.Levels.FirstOrDefault(l => l.LevelName == cmbLevel.SelectedItem.ToString()) ;
            //Them level
            question.Level = new Level
            {
                LevelID = le.LevelID
            };



            model.SaveChanges();

            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
