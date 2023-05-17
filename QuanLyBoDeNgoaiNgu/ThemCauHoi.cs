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

        Subject subjectModel;
        public ThemCauHoi()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
            
        }

        public ThemCauHoi(Subject subject)
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();

            this.subjectModel = subject;

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
            // Thêm mới câu hỏi
            Question question = new Question();
            question.Answers = new List<Answer>();
            // Thêm mới 4 đáp án
            Answer a = new Answer();
            Answer b = new Answer();
            Answer c = new Answer();
            Answer d = new Answer();
            // Lấy text t/ứng 4 đáp án A,B,C,D
            a.Text = tbA.Text;
            b.Text = tbB.Text;
            c.Text = tbC.Text;
            d.Text = tbD.Text;
            // Lấy text của câu hỏi
            question.Text = tbCauHoi.Text;
            // Thêm 4 đáp án
            question.Answers.Add(a);
            question.Answers.Add(b);
            question.Answers.Add(c);
            question.Answers.Add(d);

            model.Answers.AddRange(question.Answers);
            model.SaveChanges();

            // Kiểm tra đáp án đúng --> gán vào CorrectID của câu hỏi
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

            // Level
            //
            var le = model.Levels.FirstOrDefault(
                l => l.LevelName == cmbLevel.SelectedItem.ToString() 
                && l.Subject.SubjectID == subjectModel.SubjectID);

            model.Levels.Attach( le );
            //Them level
            question.Level = le;

            // Chủ đề
            var grQ = model.GroupQuestions.FirstOrDefault(
                g => g.Name == cmbChuDe.SelectedItem.ToString() && g.Subject.SubjectID == subjectModel.SubjectID);

            model.GroupQuestions.Attach(grQ);
            // Thêm chủ đề
            question.GroupQuestion = grQ;
            // Môn
            model.Subjects.Attach(subjectModel);
            question.Subject = subjectModel;
            // Luu
            model.Questions.Add(question);

            model.SaveChanges();

            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
