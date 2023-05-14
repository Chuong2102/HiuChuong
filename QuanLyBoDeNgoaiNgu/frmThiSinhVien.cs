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
    public partial class frmThiSinhVien : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;

        Exam examModel;
        List<Question> questions;
        List<Answer> answers;
        List<int> listCorrectAns;

        int[] userChoose = new int[2];

        int index = 0;

        public frmThiSinhVien()
        {
            InitializeComponent();
        }

        public frmThiSinhVien(Exam exam)
        {
            model = new QuanLyBoDeNgoaiNguModel1();

            // Lấy ds câu hỏi
            this.examModel = exam;
            questions = exam.Questions.ToList();
            // Load đáp án
            listCorrectAns = new List<int>();

            foreach(var q in questions)
            {
                listCorrectAns.Add(q.CorrectAnswerID);
            }

            InitializeComponent();

            rdbA.CheckedChanged += CheckedChanged;
            rdbB.CheckedChanged += CheckedChanged;
            rdbC.CheckedChanged += CheckedChanged;
            rdbD.CheckedChanged += CheckedChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmThiSinhVien_Load(object sender, EventArgs e)
        {
            LoadCauHoi();
        }

        void LoadCauHoi()
        {
            // Lay cau hoi hien tai
            var question = questions[index];
            // Lay dap an
            answers = model.Questions.Where(q => q.QuestionID == question.QuestionID).SelectMany(a => a.Answers).ToList();
            // Đẩy vào text 4 đáp án đó
            if (question != null)
            {
                rdbA.Text = answers[0].Text;
                rdbB.Text = answers[1].Text;
                rdbC.Text = answers[2].Text;
                rdbD.Text = answers[3].Text;
            }

            // Đẩy câu hỏi vào text
            tbCauHoi.Text = question.Text;
        }

        private void pBack_Click(object sender, EventArgs e)
        {
            if(index > 0)
            {
                index--;

                LoadCauHoi();
            }
        }

        private void pFollow_Click(object sender, EventArgs e)
        {
            if(index < questions.Count - 1)
            {
                index++;

                LoadCauHoi();
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if(rdbA.Checked)
                userChoose[index] = answers[0].AnswerID;
            if (rdbB.Checked)
                userChoose[index] = answers[1].AnswerID;
            if (rdbC.Checked)
                userChoose[index] = answers[2].AnswerID;
            if (rdbD.Checked)
                userChoose[index] = answers[3].AnswerID;
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            KetQuaThi ketQuaThi = new KetQuaThi(userChoose, listCorrectAns);
            ketQuaThi.Show();
        }
    }
}
