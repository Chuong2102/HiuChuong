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
        Subject subjectModel;
        

        QuanLyCauHoi frmQlch;

        public QuanLyBoCauHoi()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
        }

        public QuanLyBoCauHoi(Subject subject, QuanLyCauHoi frmQlch)
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            subjectModel = subject;

            InitializeComponent();
            this.frmQlch = frmQlch;
            LoadDataGridView();
            this.FormClosed += QuanLyBoCauHoi_FormClosed;

        }

        private void QuanLyBoCauHoi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmQlch.LoadDataGridView();
        }

        void LoadDataGridView()
        {
            var list = model.GroupQuestions.Where(q => q.Subject.SubjectID == subjectModel.SubjectID).ToList();
            Data.LoadData(dgvBoDapAn, list);

            // Ẩn các cột ko cần thiết
            dgvBoDapAn.Columns["Subject"].Visible = false;
            dgvBoDapAn.Columns["Questions"].Visible = false;

            Data.AddThuTu(dgvBoDapAn);
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

            ThemBo bo = new ThemBo(subjectModel);
            bo.Show();


        }

        private void ThemBoDapAn_Load(object sender, EventArgs e)
        {
            // Load data
            LoadDataGridView();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = (int)dgvBoDapAn.Rows[dgvBoDapAn.SelectedCells[0].RowIndex].Cells[0].Value;

            var grQ = model.GroupQuestions.FirstOrDefault(g => g.GroupQuestionID == id);

            grQ.Name = tbxTenBo.Text;

            model.SaveChanges();

            LoadDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxTenBo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
