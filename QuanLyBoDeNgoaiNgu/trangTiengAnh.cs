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
        Subject subjectModel;
        Level levelModel;


        public trangTiengAnh(User user, Subject subject)
        {
            // Tạo model
            model = new QuanLyBoDeNgoaiNguModel1();

            //
            userModel = user;
            subjectModel = subject;
            
            // Tạo form
            InitializeComponent();

            // 

            /*
            // Lấy suất thi có ngày thi là hom ni
            var comp = model.Compositions.FirstOrDefault(
                c => c.CompositionDate == DateTime.Today);

            if(subjectModel.Name == "English")
            // Nếu suất thi có tồn tại
                if (comp != null)
                {

                // Thì
                
                // Đối chiếu ở chứng chỉ xem thằng Sinh viên này đang ở level mô
                var certificates = model.Certificates.FirstOrDefault(c => c.User.UserID == c.User.UserID);

                //
                if (certificates != null && certificates.Level.LevelName == "A1")
                {
                    // Hiện
                    btnA1.Enabled = true;
                }
                // Ẩn
                else { btnA1.Enabled = false; }

                }
                else { btnA1.Enabled = false; }

            */

            btnA1.Click += (sender, e) => ShowBocDeForm(sender);
            btnA2.Click += (sender, e) => ShowBocDeForm(sender);
            btnB1.Click += (sender, e) => ShowBocDeForm(sender);
            btnB2.Click += (sender, e) => ShowBocDeForm(sender);
            btnC1.Click += (sender, e) => ShowBocDeForm(sender);
            btnC2.Click += (sender, e) => ShowBocDeForm(sender);

        }

        private void trangTiengAnh_Load(object sender, EventArgs e)
        {

        }

        public void ShowBocDeForm(object e)
        {
            var btn = e as Button;
            levelModel = model.Levels.FirstOrDefault(l => l.LevelName == btn.Text);

            BocDe de = new BocDe(userModel, subjectModel, levelModel);
            de.Show();
            
        }
    }
}
