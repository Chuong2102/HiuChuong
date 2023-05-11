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
    public partial class QuanLyBoCauHoi : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;

        public QuanLyBoCauHoi()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
        }

        void LoadDataGridView()
        {
            Data.LoadData(dgvBoDapAn, model.GroupQuestions.ToList());
        }

        private void btnTiengAnh_Click(object sender, EventArgs e)
        {
            var grID = (int) dgvBoDapAn.CurrentRow.Cells[0].Value;

            var group = model.GroupQuestions.FirstOrDefault(g => g.GroupQuestionID == grID);
            // Xoa
            model.GroupQuestions.Remove(group);
            model.SaveChanges();

            // Load lai
            LoadDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThemBo bo = new ThemBo();
            bo.Show();
        }

        private void ThemBoDapAn_Load(object sender, EventArgs e)
        {
            // Load data
            Data.LoadData(dgvBoDapAn, model.GroupQuestions.ToList());
        }

        private void btnCauHoi_Click(object sender, EventArgs e)
        {
            QuanLyCauHoi frmQlCauHoi = new QuanLyCauHoi();
            frmQlCauHoi.Show();
        }

        private void dgvBoDapAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvBoDapAn.Rows[e.RowIndex];

            tbxTenBo.Text = row.Cells[1].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var cc = dgvBoDapAn.SelectedRows;

            var groupID = dgvBoDapAn.CurrentRow.Cells[0].Value;

            var group = model.GroupQuestions.FirstOrDefault(g => g.GroupQuestionID == (int)groupID);

            group.Name = tbxTenBo.Text;

            model.SaveChanges();

            Data.LoadData(dgvBoDapAn, model.GroupQuestions.ToList());
        }
    }
}
