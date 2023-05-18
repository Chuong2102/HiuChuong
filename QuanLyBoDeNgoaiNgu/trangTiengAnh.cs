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
        Composition compositionModel;

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
            lblMSV.Text = userModel.StudentID;
            lbHoTen.Text = userModel.FullName;
            // 
            var listCompQuery = model.Compositions.Where(c => c.CompositionDate == DateTime.Today);
            var listComp = listCompQuery.ToList();

            listComp.Sort((a, b) => a.StartTime.CompareTo(b.EndTime));

            // Lấy suất thi có ngày thi là hom ni
            Composition comp = null;
            if(listComp.Count > 0 ) 
                comp = listComp.Last();

            if(subjectModel.Name == "English")
            // Nếu suất thi có tồn tại
                if (comp != null)
                {
                    // Không cho sinh viên thi 2 lần trong cùng suất thi
                    var exam = model.Exams.FirstOrDefault(e => e.Composition.CompositionID == comp.CompositionID);
                    //
                    if(true) //exam == null
                    {
                        compositionModel = comp;
                        // Thì

                        // Đối chiếu ở chứng chỉ xem thằng Sinh viên này đang ở level mô
                        var certificates = model.Certificates.FirstOrDefault(c => c.User.UserID == userModel.UserID);
                        var level = model.Certificates.Where(c => c.CertificateID == certificates.CertificateID).Select(q => q.Level).FirstOrDefault();

                        //
                        if (certificates != null && certificates.Pass == false)
                        {
                            if (level.LevelName == "A1")
                                // Hiện
                                btnA1.Enabled = true;
                            if (level.LevelName == "A2")
                                // Hiện
                                btnA2.Enabled = true;
                            if (level.LevelName == "B1")
                                // Hiện
                                btnB1.Enabled = true;
                            if (level.LevelName == "B2")
                                // Hiện
                                btnB2.Enabled = true;
                            if (level.LevelName == "C1")
                                // Hiện
                                btnC1.Enabled = true;
                            if (level.LevelName == "C2")
                                // Hiện
                                btnC2.Enabled = true;
                        }
                        // Ẩn
                        else
                        {
                            btnA1.Enabled = true;
                        }
                    }
                    

                }
                else { btnA1.Enabled = false; }

            

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
            var checkStart = TimeSpan.Compare(DateTime.Now.TimeOfDay, compositionModel.StartTime.TimeOfDay);
            var checkEnd = TimeSpan.Compare(DateTime.Now.TimeOfDay, compositionModel.EndTime.TimeOfDay);

            if (checkStart == -1)
            {
                MessageBox.Show("Chưa tới thời gian thi");
            }
            else
            if (checkEnd == 1)
            {
                MessageBox.Show("Quá thời gian thi");
            }
            else
            {
                var btn = e as Button;
                levelModel = model.Levels.FirstOrDefault(l => l.LevelName == btn.Text);

                this.Hide();
                BocDe de = new BocDe(userModel, subjectModel, levelModel, compositionModel);
                de.Closed += (s, args) => this.Close();

                de.Show();
            }
            
        }
    }
}
