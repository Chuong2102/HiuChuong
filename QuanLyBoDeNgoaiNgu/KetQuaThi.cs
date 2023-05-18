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
    public partial class KetQuaThi : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;

        List<int> chooseAnswer;
        List<int> correctAnswer;
        Exam examModel;

        const int SCORE = 5;
        int totalScore = 0;

        public KetQuaThi()
        {
            InitializeComponent();
        }

        public KetQuaThi(int[] chooseAns, List<int> listCorrectAns, Exam exam)
        {
            InitializeComponent();

            this.chooseAnswer = chooseAns.ToList();
            this.correctAnswer = listCorrectAns;
            this.examModel = exam;

            model = new QuanLyBoDeNgoaiNguModel1();

            KiemTraDapAn();
            ThongKe();
        }

        void KiemTraDapAn()
        {
            for(int i = 0;  i < this.chooseAnswer.Count; i++)
            {
                if (chooseAnswer[i] == correctAnswer[i])
                {
                    totalScore += SCORE;
                }
            }
            lbDiem.Text = totalScore.ToString() + "/" + examModel.Level.LevelMaxScore;
        }

        void ThongKe()
        {
            // Chứng chỉ
            var chungChi = model.Certificates.FirstOrDefault(
                c => c.User.UserID == examModel.user.UserID && c.Subject.SubjectID == examModel.Subject.SubjectID);
            //
            if (chungChi == null)
            {
                // Thêm mới chứng chỉ

            }
            else
            {
                // Bac A1
                chungChi.Score = examModel.Score;

                // Check xem co pass hay ko
                if (chungChi.Score >= examModel.Level.LevelMaxScore)
                {
                    chungChi.Pass = true;
                    // Set text
                    lbKetQua.Text = "Đậu";
                }
                else
                    lbKetQua.Text = "Rớt";

                // Luu
                model.SaveChanges();
            }
        }

        void Luu()
        {
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
