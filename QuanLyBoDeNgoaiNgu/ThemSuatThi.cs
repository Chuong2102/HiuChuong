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
            //
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
                // Config lại ngày cho giờ thi và giờ kết thúc
                //
                var startTime = new DateTime(ddtNgayThi.Value.Year, ddtNgayThi.Value.Month, ddtNgayThi.Value.Day,
                    ddtStartime.Value.Hour, ddtStartime.Value.Minute, ddtStartime.Value.Second, ddtStartime.Value.Millisecond);

                var endTime = new DateTime(ddtNgayThi.Value.Year, ddtNgayThi.Value.Month, ddtNgayThi.Value.Day,
                    ddtEndtime.Value.Hour, ddtEndtime.Value.Minute, ddtEndtime.Value.Second, ddtEndtime.Value.Millisecond);
                // Gán
                composition.StartTime = startTime;
                composition.EndTime = endTime;


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

                compList.Sort((a, b) => a.StartTime.CompareTo(b.StartTime));

                Composition comp = null;
                if(compList.Count > 0)
                    comp = compList.Last(c => c.Subject == subjectModel && c.Level == level);

                // Luu
                if (comp == null)
                {
                    model.Compositions.Add(composition);
                    MessageBox.Show("Thêm suất thi thành công :>");
                }
                else
                {
                    if (TimeSpan.Compare(composition.StartTime.TimeOfDay, comp.EndTime.TimeOfDay) < 0)
                    {
                        MessageBox.Show("Bị trùng suất thi :<");
                    }
                    else
                    {
                        model.Compositions.Add(composition);
                        MessageBox.Show("Thêm suất thi thành công :>");
                    }
                }

                // Lưu
                model.SaveChanges();

                // Load lại trang quản lý
                quanLySuatThi.Refesh();

                
                this.Close();
            }
            
        }

    }
}
