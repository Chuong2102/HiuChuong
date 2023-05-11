using QuanLyBoDeNgoaiNgu.Entities;
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

namespace QuanLyBoDeNgoaiNgu
{
    
    public partial class QuanLyCauHoi : Form
    {
        QuanLyBoDeNgoaiNguModel1 model = new QuanLyBoDeNgoaiNguModel1();
        User userModel;

        public QuanLyCauHoi()
        {
            InitializeComponent();
        }

        public QuanLyCauHoi(User user)
        {
            InitializeComponent();

            userModel = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemCauHoi themCauHoi = new ThemCauHoi();
            themCauHoi.Show();
        }



        private void QuanLyCauHoi_Load(object sender, EventArgs e)
        {
            // Load DatagridView
            LoadData(model.Questions.ToList());

            // Load combobox Bậc
            var listLevel = model.Levels.ToList();
            //
            foreach( var level in listLevel )
            {
                cmbBac.Items.Add(level.LevelName);
            }

            // Load comboBox Chủ đề
            var listGroupQuestion = model.GroupQuestions.ToList();
            foreach( var grQuestion in listGroupQuestion )
            {
                cmbChuDe.Items.Add(grQuestion.Name);
            }
        }
        void LoadData(List<Question> questions)
        {
            dgvCauHoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCauHoi.DataSource = questions;

        }

        private void dgvCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvCauHoi.Rows[e.RowIndex];

            tbCauHoi.Text = row.Cells[1].Value.ToString();

            // Lấy ID của câu hỏi hiện tại
            var questionID = (int)row.Cells[0].Value;
            // 
            var question = model.Questions.Where(q => q.QuestionID == questionID).FirstOrDefault();

            // Load đáp án
            var listAnswers = model.Questions.Where( q => q.QuestionID == questionID).SelectMany(a =>  a.Answers).ToList();
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
            for(int i = 0; i < listAnswers.Count; i++)
            {
                if (listAnswers[i].AnswerID == question.CorrectAnswerID)
                    if (i == 0)
                        rdbA.Checked = true;
                    if(i == 1)
                        rdbB.Checked = true;
                    if(i == 2) 
                        rdbC.Checked = true;
                    if(i == 3) 
                        rdbD.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
