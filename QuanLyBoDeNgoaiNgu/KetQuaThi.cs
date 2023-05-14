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

        const int SCORE = 5;
        int totalScore = 0;

        public KetQuaThi()
        {
            InitializeComponent();
        }

        public KetQuaThi(int[] chooseAns, List<int> listCorrectAns)
        {
            InitializeComponent();

            this.chooseAnswer = chooseAns.ToList();
            this.correctAnswer = listCorrectAns;

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
    }
}
