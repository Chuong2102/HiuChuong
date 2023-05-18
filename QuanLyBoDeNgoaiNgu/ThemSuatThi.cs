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
using System.Net;
using System.Net.Mail;


namespace QuanLyBoDeNgoaiNgu
{
    public partial class ThemSuatThi : Form
    {
        List<Level> levels;
        QuanLyBoDeNgoaiNguModel1 model;
        QuanLySuatThi quanLySuatThi;

        Subject subjectModel;

        public ThemSuatThi()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();

            // Get level to combobox
            levels = model.Levels.Where(l => l.Subject.SubjectID == subjectModel.SubjectID).ToList();

            // lay database
            foreach (Level level in levels)
            {
                if (level.LevelName != null)
                {
                    cmbBacST.Items.Add(level.LevelName);
                }
            }
        }

        public ThemSuatThi(QuanLySuatThi quanLySuatThi, Subject subject)
        {
            model = new QuanLyBoDeNgoaiNguModel1();

            subjectModel = subject;

            InitializeComponent();
            //
            levels = model.Levels.ToList();

            // lay database
            foreach (Level level in levels)
            {
                if (level.LevelName != null)
                {
                    cmbBacST.Items.Add(level.LevelName);
                }
            }
            this.quanLySuatThi = quanLySuatThi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           Composition composition = new Composition();

            // Setup cho suat thi
            composition.CompositionDate = ddtNgayThi.Value.Date;
            // Check endtime vs starttime
            
            if(TimeSpan.Compare(ddtStartime.Value.TimeOfDay, ddtEndtime.Value.TimeOfDay) >= 0 )
            {
                // THong bao
                MessageBox.Show("Giờ bắt đầu thi không hợp lệ, phải lớn hơn giờ kết thúc");
            }
            if(ddtNgayThi.Value.Date < DateTime.Now.Date)
            {
                // Quá ngày
                MessageBox.Show("Ngày thi không hợp lệ");
            }
            if(cmbBacST.SelectedItem == null) // Check xem bậc được chọn
            {
                MessageBox.Show("Vui lòng chọn bậc môn thi cho suất thi");
            }
            else // Hợp lệ
            {
                composition.StartTime = ddtStartime.Value;
                composition.EndTime = ddtEndtime.Value;


                // Lay level
                var level = model.Levels.FirstOrDefault(
                    c => c.LevelName == cmbBacST.SelectedItem.ToString());

                // Xem level co trong database san hay k
                model.Levels.Attach(level);
                composition.Level = level;
                // Xem subject co trong database san hay k
                model.Subjects.Attach(subjectModel);
                composition.Subject = subjectModel;

                // Trường hợp có suất thi khác trùng ngày
                //
                var compList = model.Compositions.Where(
                    c => c.CompositionDate == ddtNgayThi.Value).ToList();

                var comp = compList.FirstOrDefault(c => c.Subject == subjectModel && c.Level == level);
                // Luu
                if (comp == null)
                    model.Compositions.Add(composition);
                else
                {
                    if (TimeSpan.Compare(comp.StartTime.TimeOfDay, composition.EndTime.TimeOfDay) < 1)
                    {
                        MessageBox.Show("Bị trùng suất thi :<");
                    }
                    else
                    {

                        MessageBox.Show("Thêm suất thi thành công :>");
                    }
                }

                // Lưu
                model.SaveChanges();

                // Load lại trang quản lý
                quanLySuatThi.Refesh();

                MessageBox.Show("Thêm thành công !");
                this.Close();
            }
            
        }

    }
}
