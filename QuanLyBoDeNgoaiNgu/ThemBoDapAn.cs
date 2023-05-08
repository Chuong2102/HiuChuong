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
    public partial class ThemBoDapAn : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;

        public ThemBoDapAn()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
        }

        private void btnTiengAnh_Click(object sender, EventArgs e)
        {
            ThemDapAn dapAn = new ThemDapAn();
            dapAn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThemBo bo = new ThemBo();
            bo.Show();
        }

        private void ThemBoDapAn_Load(object sender, EventArgs e)
        {
            LoadData(model.GroupQuestions.ToList());
        }

        // Hàm load data lên datagridview
        void LoadData(List<GroupAnswer> data)
        {
            dgvBoDapAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBoDapAn.DataSource = data;

            // Ẩn 2 trường ID và Answers
            //dgvBoDapAn.Columns["GroupAnswerID"].Visible = false;
            dgvBoDapAn.Columns["Answers"].Visible = false;
            dgvBoDapAn.Columns["GroupAnswerName"].HeaderText = "Tên bộ";

            
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
            int valueID = (int)dgvBoDapAn.SelectedCells[0].Value;

            var grAns = model.GroupQuestions.FirstOrDefault(
                g => g.GroupAnswerID == valueID);

            grAns.GroupAnswerName = tbxTenBo.Text;

            model.SaveChanges();

            // Load lai
            LoadData(model.GroupQuestions.ToList());
        }
    }
}
