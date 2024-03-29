﻿using QuanLyBoDeNgoaiNgu.Entities;
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
        QuanLyCauHoi quanLyCauHoi;
        QuanLyBoDeNgoaiNguModel1 model;

        Subject subjectModel;
        public ThemCauHoi()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
            
        }

        public ThemCauHoi(Subject subject, QuanLyCauHoi quanLyCauHoi)
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();

            this.subjectModel = subject;
            this.quanLyCauHoi = quanLyCauHoi; 

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
            if(tbA.Text == String.Empty || tbB.Text == String.Empty || 
                tbC.Text == String.Empty || tbD.Text == String.Empty || tbCauHoi.Text == String.Empty)
            {
                MessageBox.Show("Câu hỏi hoặc Đáp án bị thiếu");
            }
            else
            {
                // Thêm mới câu hỏi
                Question question = new Question();
                question.Answers = new List<Answer>();

                // Thêm 4 đáp án

                Answer a;
                Answer b;
                Answer c;
                Answer d;

                a = model.Answers.FirstOrDefault(aa => aa.Text == tbA.Text);
                if (a == null)
                {
                    a = new Answer();
                    a.Text = tbA.Text;
                }


                b = model.Answers.FirstOrDefault(bb => bb.Text == tbB.Text);
                if (b == null)
                {
                    b = new Answer();
                    b.Text = tbB.Text;
                }

                c = model.Answers.FirstOrDefault(cc => cc.Text == tbC.Text);
                if (c == null)
                {
                    c = new Answer();
                    c.Text = tbC.Text;
                }

                d = model.Answers.FirstOrDefault(dd => dd.Text == tbD.Text);
                if (d == null)
                {
                    d = new Answer();
                    d.Text = tbD.Text;
                }

                question.Text = tbCauHoi.Text;






                // Kiểm tra đáp án đúng --> gán vào CorrectID của câu hỏi
                if (rdbA.Checked)
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

                model.Levels.Attach(le);
                //Them level

                question.Level = new Level
                {
                    LevelID = le.LevelID
                };

                var gr = model.GroupQuestions.FirstOrDefault(g => g.Name == cmbChuDe.SelectedItem.ToString());
                question.GroupQuestion = new GroupQuestion
                {
                    GroupQuestionID = gr.GroupQuestionID
                };

                question.Answers.Add(a);
                question.Answers.Add(b);
                question.Answers.Add(c);
                question.Answers.Add(d);

                model.Answers.AddRange(question.Answers);

                model.Questions.Add(question);

                model.Subjects.Attach(subjectModel);
                question.Subject = subjectModel;

                model.SaveChanges();
            }

            quanLyCauHoi.LoadDataGridView();

            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
