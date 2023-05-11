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
    
    public partial class trangTiengAnh : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;

        User userModel;
        Subject subject;

        public trangTiengAnh()
        {
            // Tạo model
            model = new QuanLyBoDeNgoaiNguModel1();
            // Tạo form
            InitializeComponent();

            // Lấy user có mã sv = labelMSV.Text
            var user = model.Users.FirstOrDefault(u => u.StudentID == lblMSV.Text);
            userModel = user;
            // Lấy suất thi có ngày thi là hom ni
            var comp = model.Compositions.FirstOrDefault(
                c => c.CompositionDate == DateTime.Today);
            // Nếu suất thi có tồn tại
            if (comp != null)
            {

                // Thì
                // Suất thi cho môn tiếng anh
                var exam = model.Exams.FirstOrDefault(e => e.Subject.Name == "English");
                // Đối chiếu ở chứng chỉ xem thằng Sinh viên này đang ở level mô
                var certificates = model.Certificates.FirstOrDefault(c => c.User.UserID == c.User.UserID);
                if (certificates != null && certificates.Level.LevelName == "A1")
                {
                    // Hiện
                    btnA1.Enabled = true;
                }
                // Ẩn
                else { btnA1.Enabled = false; }

            }
            else { btnA1.Enabled = false; }

            btnA1.Click += (sender, e) => ShowBocDeForm();
            btnA2.Click += (sender, e) => ShowBocDeForm();
            btnB1.Click += (sender, e) => ShowBocDeForm();
            btnB2.Click += (sender, e) => ShowBocDeForm();
            btnC1.Click += (sender, e) => ShowBocDeForm();
            btnC2.Click += (sender, e) => ShowBocDeForm();

        }

        private void trangTiengAnh_Load(object sender, EventArgs e)
        {

        }

        public void ShowBocDeForm()
        {
            BocDe de = new BocDe();
            de.Show();
        }
    }
}
