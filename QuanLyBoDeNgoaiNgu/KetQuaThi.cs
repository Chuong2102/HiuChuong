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

            KiemTraDapAn();
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
            lbDiem.Text = totalScore.ToString();
        }

        void ThongKe()
        {
            var chungChi = model.Certificates.FirstOrDefault(c => c.CertificateID == )
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
