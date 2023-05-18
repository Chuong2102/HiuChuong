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
    public partial class UpdateCauhoi : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;

        Question qs;
        QuanLyCauHoi quanLyCauHoi;

        
        public UpdateCauhoi()
        {
            List<Level> levels;
            List<GroupQuestion> groups;
            QuanLyBoDeNgoaiNguModel1 model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
        }

        public UpdateCauhoi(Question qs, QuanLyCauHoi quanLyCauHoi)
        {
            List<Level> levels;
            List<GroupQuestion> groups;
            model = new QuanLyBoDeNgoaiNguModel1();

            InitializeComponent();
            //
            levels = model.Levels.ToList();
            groups = model.GroupQuestions.ToList();
            //
            this.quanLyCauHoi = quanLyCauHoi;

            // luu vao bien toan cuc
            this.qs = qs;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            // Lay du lieu tu database
            Question question = model.Questions.FirstOrDefault(q => q.QuestionID == qs.QuestionID);

            question.Text = tbCauHoi.Text;
            //
            var listanswers = model.Questions.Where(
                q => q.QuestionID == qs.QuestionID).SelectMany(a => a.Answers).ToList();
            listanswers[0].Text = tbA.Text;
            listanswers[1].Text = tbB.Text;
            listanswers[2].Text = tbC.Text;
            listanswers[3].Text = tbD.Text;

            var levelId = model.Levels.FirstOrDefault(
                c => c.LevelName == cmbLevel.SelectedItem.ToString()).LevelID;
            question.Level.LevelID = levelId;

            var groupId = model.GroupQuestions.FirstOrDefault(
                g => g.Name == cmbChuDe.SelectedItem.ToString()).GroupQuestionID;
            question.GroupQuestion.GroupQuestionID = groupId;

            model.SaveChanges();

            quanLyCauHoi.Refesh();

            this.Close();
        }

        private void UpdateCauhoi_Load(object sender, EventArgs e)
        {
            
            tbCauHoi.Text = qs.Text; 

            var listanswers = model.Questions.Where(
                q => q.QuestionID == qs.QuestionID).SelectMany(a => a.Answers).ToList();
            tbA.Text = listanswers[0].Text;
            tbB.Text = listanswers[1].Text;
            tbC.Text = listanswers[2].Text;
            tbD.Text = listanswers[3].Text;

            cmbLevel.SelectedItem = qs.Level.LevelID;

            List<Level> levels;
            levels = model.Levels.ToList();

            // lay database
            int i = 0;
            foreach (Level level in levels)
            {
                if (level.LevelName != null)
                {
                    cmbLevel.Items.Add(level.LevelName);
                    if (qs.Level.LevelID == level.LevelID)
                        cmbLevel.SelectedIndex = i;
                }
                i++;
            }
            List<GroupQuestion> groups = model.GroupQuestions.ToList();
            //
            

            // lay database
            int j = 0;
            foreach (GroupQuestion group in groups)
            {
                if (group.Name != null)
                {
                    cmbChuDe.Items.Add(group.Name);
                    if (qs.GroupQuestion.GroupQuestionID == group.GroupQuestionID)
                        cmbChuDe.SelectedIndex = j;
                }
                j++;
            }

            if (qs.CorrectAnswerID == listanswers[0].AnswerID)
                rdbA.Checked = true;

                if(qs.CorrectAnswerID == listanswers[1].AnswerID)
                rdbB.Checked = true;

                    if(qs.CorrectAnswerID == listanswers[2].AnswerID)
                    rdbC.Checked = true;
                        
                        if(qs.CorrectAnswerID == listanswers[3].AnswerID) 
                        rdbD.Checked = true;    


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
