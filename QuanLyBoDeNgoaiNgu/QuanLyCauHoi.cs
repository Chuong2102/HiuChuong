﻿using QuanLyBoDeNgoaiNgu.Entities;
using QuanLyBoDeNgoaiNgu.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyBoDeNgoaiNgu
{

    public partial class QuanLyCauHoi : Form
    {
        QuanLyBoDeNgoaiNguModel1 model = new QuanLyBoDeNgoaiNguModel1();
        User userModel;
        Subject subjectModel;

        Question questionModel;

        public QuanLyCauHoi()
        {
            InitializeComponent();
        }

        public QuanLyCauHoi(User user, Subject sub)
        {
            InitializeComponent();

            Data.LoadData(dgvCauHoi, model.Questions.ToList());
        
            userModel = user;
            subjectModel = sub;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemCauHoi themCauHoi = new ThemCauHoi(subjectModel, this);
            themCauHoi.Show();
        }



        private void QuanLyCauHoi_Load(object sender, EventArgs e)
        {
            // Load DatagridView
            LoadDataGridView();

            // Load combobox Bậc
            var listLevel = model.Levels.ToList();
            //
            foreach (var level in listLevel)
            {

                if (level.LevelName != null)


                    cmbBac.Items.Add(level.LevelName);
            }

            // Load comboBox Chủ đề
            var listGroupQuestion = model.GroupQuestions.ToList();
            foreach (var grQuestion in listGroupQuestion)
            {
                if (grQuestion.Name != null)

                    cmbChuDe.Items.Add(grQuestion.Name);
            }
            
            
        }
        
        public void LoadDataGridView()
        {
            Data.LoadData(dgvCauHoi, model.Questions.Where(q => q.Subject.SubjectID == subjectModel.SubjectID).ToList());
            Data.AddThuTu(dgvCauHoi);
            // Ẩn các cột không cần thiết 
            this.dgvCauHoi.Columns["GroupQuestion"].Visible = false;
            this.dgvCauHoi.Columns["Level"].Visible = false;
            this.dgvCauHoi.Columns["CorrectAnswerID"].Visible = false;
            this.dgvCauHoi.Columns["Answers"].Visible = false;
            this.dgvCauHoi.Columns["Exams"].Visible = false;
            this.dgvCauHoi.Columns["Subject"].Visible = false;
            this.dgvCauHoi.Columns["QuestionID"].Visible = false;

            dgvCauHoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCauHoi.Columns["TT"].Width = 100;
        }

        public void LoadDataGridView(List<Question> questions)
        {
            Data.LoadData(dgvCauHoi, questions);
            Data.AddThuTu(dgvCauHoi);
            // Ẩn các cột không cần thiết 
            this.dgvCauHoi.Columns["GroupQuestion"].Visible = false;
            this.dgvCauHoi.Columns["Level"].Visible = false;
            this.dgvCauHoi.Columns["CorrectAnswerID"].Visible = false;
            this.dgvCauHoi.Columns["Answers"].Visible = false;
            this.dgvCauHoi.Columns["Exams"].Visible = false;
            this.dgvCauHoi.Columns["Subject"].Visible = false;
            this.dgvCauHoi.Columns["QuestionID"].Visible = false;

            dgvCauHoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCauHoi.Columns["TT"].Width = 100;
        }

        private void dgvCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvCauHoi.Rows[e.RowIndex];

                var cellValue = row.Cells[1].Value;
                if (cellValue != null)
                {
                    tbCauHoi.Text = cellValue.ToString();
                }
                else
                {
                    // Xử lý khi giá trị là null
                    tbCauHoi.Text = string.Empty; // hoặc gán giá trị khác tùy thuộc vào yêu cầu của bạn
                }

                // Lấy ID của câu hỏi hiện tại
                var questionID = (int)row.Cells[0].Value;
                // 
                var question = model.Questions.Where(q => q.QuestionID == questionID).FirstOrDefault();
                questionModel = question;

                // Load đáp án
                var listAnswers = model.Questions.Where(q => q.QuestionID == questionID).SelectMany(a => a.Answers).ToList();
                //
                // A
                tbA.Text = listAnswers[0].Text;
                // B
                tbB.Text = listAnswers[1].Text;
                // C
                tbC.Text = listAnswers[2].Text;
                // D
                tbD.Text = listAnswers[3].Text;
                // 
                // Check radio button
                for (int i = 0; i < listAnswers.Count; i++)
                {
                    if (listAnswers[i].AnswerID == question.CorrectAnswerID)
                        if (i == 0)
                            rdbA.Checked = true;
                    if (i == 1)
                        rdbB.Checked = true;
                    if (i == 2)
                        rdbC.Checked = true;
                    if (i == 3)
                        rdbD.Checked = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Refesh()
        {
            LoadDataGridView();
        }

        private void btnChuDe_Click(object sender, EventArgs e)
        {
            QuanLyBoCauHoi frmQlBoChuDeCauHoi = new QuanLyBoCauHoi(subjectModel, this);

            frmQlBoChuDeCauHoi.Show();
        }


       


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            List<Question> questionList = new List<Question>();

           

            questionList = model.Questions.Where(q => q.Subject.SubjectID == subjectModel.SubjectID).ToList();
            var query = questionList.Where(c => c.Text.Contains(textBox1.Text)).ToList();
            if (textBox1.Text == null)
            {
                LoadDataGridView();
            }

            LoadDataGridView(query);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            UpdateCauhoi updateCauhoi = new UpdateCauhoi(questionModel, this);
            updateCauhoi.Show();
        }

        private void cmbBac_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Khi select cmb sẽ lấy được level từ database
                var level = model.Levels.FirstOrDefault(l => l.LevelName == cmbBac.SelectedItem.ToString());
                // 
                var listQ = model.Questions.Where(
                    q => q.Subject.SubjectID == subjectModel.SubjectID
                    && q.Level.LevelID == level.LevelID).ToList();
                //
                LoadDataGridView(listQ);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi, không có câu hỏi thuộc bậc này");
            }
            
            
        }

        private void cmbChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var group = model.GroupQuestions.FirstOrDefault(g => g.Name == cmbChuDe.SelectedItem.ToString());
                //
                var listG = model.Questions.Where(
                    q => q.Subject.SubjectID == subjectModel.SubjectID
                    && q.GroupQuestion.GroupQuestionID == group.GroupQuestionID).ToList();

                LoadDataGridView(listG);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi, không có câu hỏi thuộc chủ đè này");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Click vào Datagriview dòng cần xóa
            // Lấy được ID mình chọn
            // Lấy các row(s)
            var Row = dgvCauHoi.Rows[dgvCauHoi.SelectedCells[0].RowIndex];

            // Lấy ID ra
            var ID = (int)Row.Cells[0].Value;
            // Xóa
            model.Questions.Remove(
                model.Questions.FirstOrDefault(i => i.QuestionID == ID));
            model.SaveChanges();

            LoadDataGridView();

            tbCauHoi.Text = String.Empty;
            tbA.Text = String.Empty;
            tbB.Text = String.Empty;
            tbC.Text = String.Empty;
            tbD.Text = String.Empty;
        }


    }
}
