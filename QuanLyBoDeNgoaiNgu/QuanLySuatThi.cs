﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBoDeNgoaiNgu.Entities;
using QuanLyBoDeNgoaiNgu.Infrastructure;

namespace QuanLyBoDeNgoaiNgu
{
    public partial class QuanLySuatThi : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;

        User userModel;
        Subject subjectModel;

        public QuanLySuatThi()
        {
            model = new QuanLyBoDeNgoaiNguModel1();

            InitializeComponent();
        }

        public QuanLySuatThi(User user, Subject subject)
        {
            model = new QuanLyBoDeNgoaiNguModel1();

            this.subjectModel = subject;
            this.userModel = user;

            InitializeComponent();
        }

        private void QuanLySuatThi_Load(object sender, EventArgs e)
        {
            Data.LoadData(dgvQLSuatThi, model.Compositions.ToList());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Warning warning = new Warning(this);
            warning.Show();
        }

        public void Delete()
        {
            // Click vào Datagriview dòng cần xóa
            // Lấy được ID mình chọn
            // Lấy các row(s)
            var Rows = dgvQLSuatThi.SelectedRows;

            foreach (DataGridViewRow Row in Rows)
            {
                // Lấy ID ra
                var ID = (int)Row.Cells[0].Value;
                // Xóa
                model.Compositions.Remove(
                    model.Compositions.FirstOrDefault(i => i.CompositionID == ID));
            }
            model.SaveChanges();

            Data.LoadData(dgvQLSuatThi, model.Compositions.ToList());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemSuatThi themSuatThi = new ThemSuatThi(this, subjectModel);
            themSuatThi.Show();
        }

        public void Refesh()
        {
            Data.LoadData(dgvQLSuatThi, model.Compositions.ToList());
        }

        // Edit suat thi
        private void button3_Click(object sender, EventArgs e)
        {
            var Row = dgvQLSuatThi.Rows[dgvQLSuatThi.SelectedCells[0].RowIndex];

            // Lấy ID ra
            var ID = (int)Row.Cells[0].Value;
            //
            var comp = model.Compositions.FirstOrDefault(c => c.CompositionID == ID);

            Editcomposition editcomposition = new Editcomposition(comp, this);
            editcomposition.Show();
        }

        // thay đổi Bậc
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
