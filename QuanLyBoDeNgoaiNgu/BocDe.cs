using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBoDeNgoaiNgu.Infrastructure;
using QuanLyBoDeNgoaiNgu.Entities;

namespace QuanLyBoDeNgoaiNgu
{
    public partial class BocDe : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;

        User userModel;
        Subject subjectModel;
        Composition compositionModel;
        Level levelModel;

        Exam baiThi;

        //
        List<int> userChooseAnswerID = new List<int>();
        //
        List<Question> questions = new List<Question>();

        public BocDe()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
        }

        public BocDe(User user, Subject subject, Composition composition, Level level)
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();

            this.userModel = user;
            this.subjectModel = subject;
            this.compositionModel = composition;
            this.levelModel = level;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            // Bốc đề
            baiThi = new Exam();
            //
            ThucHienBocDe();
            //
            baiThi.Questions = questions;

            frmThiSinhVien formThi = new frmThiSinhVien(baiThi);
            formThi.Show();
        }

        /* Tiến hành bốc đề
         */
        void ThucHienBocDe()
        {
            questions = model.Questions.Where(
                q => q.Subject.SubjectID == subjectModel.SubjectID 
                && levelModel.LevelID == q.Level.LevelID).ToList();

            // Random
            var random = new Random();
            //
            while(questions.Count > 0)
            {
                int index = random.Next(questions.Count);
                questions.RemoveAt(index);
            }
        }
    }
}
