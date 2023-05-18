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

        const int SCORE = 100;
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
                chungChi.Score = totalScore;

                // Check xem co pass hay ko
                if (chungChi.Score >= examModel.Level.LevelMaxScore)
                {
                    chungChi.Pass = true;
                    // Set text
                    lbKetQua.Text = "Đậu";

                    //
                    var user = examModel.user;
                    model.Users.Attach(user);

                    // Thêm mới chứng chỉ
                    // Check từng môn
                    if(examModel.Subject.Name == "English")
                    {
                        if (examModel.Level.LevelName == "A1")
                            ThemChungChi(user, "A2");
                        if (examModel.Level.LevelName == "A2")
                            ThemChungChi(user, "B1");
                        if (examModel.Level.LevelName == "B1")
                            ThemChungChi(user, "B2");
                        if (examModel.Level.LevelName == "B2")
                            ThemChungChi(user, "C1");
                        if (examModel.Level.LevelName == "C1")
                            ThemChungChi(user, "C2");
                        if (examModel.Level.LevelName == "B2")
                            MessageBox.Show("Hoàn thành chương trình");
                    }
                    else
                    if(examModel.Subject.Name == "Jappanese")
                    {

                    }

                }
                else
                    lbKetQua.Text = "Rớt";

                // Luu
                model.SaveChanges();
            }
        }

        void ThemChungChi(User user, string TenBacChungChi)
        {
            var level = model.Levels.Where(
                                l => l.Subject.SubjectID == examModel.Subject.SubjectID && l.LevelName == TenBacChungChi).FirstOrDefault();
            model.Levels.Attach(level);

            model.Subjects.Attach(examModel.Subject);

            model.Certificates.Add(new Certificate
            {
                Pass = false,
                User = user,
                Level = level,
                Subject = examModel.Subject,
                Score = 0
            });
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
