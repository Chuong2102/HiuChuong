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
    public partial class ThemBo : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;
        public ThemBo()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GroupAnswer groupAnswer = new GroupAnswer();
                groupAnswer.Answers = new List<Answer>();

                // Them ten bo
                groupAnswer.GroupAnswerName = tbTenbo.Text;
                // Them cau hoi
                groupAnswer.Answers.Add(new Answer
                {
                    Text = tbDapAn.Text
                });
                // Thêm
                model.GroupQuestions.Add(groupAnswer);
                // Lưu
                model.SaveChanges();

                MessageBox.Show("Thêm thành công!");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Thêm bộ đáp án không thành công, lỗi: "+ ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
