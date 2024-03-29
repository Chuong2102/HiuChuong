﻿using QuanLyBoDeNgoaiNgu.Entities;
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
        Subject subjectModel;
        public ThemBo()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
        }
        public ThemBo(Subject subject)
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            subjectModel = subject;

            InitializeComponent();

            Data.LoadData(dgvChuDe, model.GroupQuestions.Where(q => q.Subject.SubjectID == subjectModel.SubjectID).ToList());
        }

        private void ThemBo_Load(object sender, EventArgs e)
        {
                       
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(tbChuDe.Text == String.Empty)
            {
                MessageBox.Show("Chủ đề bị rỗng, vui lòng nhập tên chủ đề ạ :<");
            }
            else
            {
                GroupQuestion groupQuestion = new GroupQuestion();
                groupQuestion.Name = tbChuDe.Text;

                var listGr = model.GroupQuestions.Where(g => g.Subject.SubjectID == subjectModel.SubjectID).ToList();

                if(listGr.Count > 0)
                {
                    MessageBox.Show("Tên chủ đề bị trùng");
                }
                else
                {
                    model.Subjects.Attach(subjectModel);

                    groupQuestion.Subject = subjectModel;


                    model.GroupQuestions.Add(groupQuestion);

                    model.SaveChanges();

                    var listData = model.GroupQuestions.Where(
                        q => q.Subject.SubjectID == subjectModel.SubjectID).ToList();
                    Data.LoadData(dgvChuDe, listData);

                    this.dgvChuDe.Columns["Subject"].Visible = false;
                }
                
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
