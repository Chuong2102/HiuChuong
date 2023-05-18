using QuanLyBoDeNgoaiNgu.Entities;
using QuanLyBoDeNgoaiNgu.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBoDeNgoaiNgu
{
    public partial class Editcomposition : Form
    {
        QuanLyBoDeNgoaiNguModel1 model;
        QuanLySuatThi quanLySuatThi;
        Composition comp;
        public Editcomposition()
        {
            List<Level> levels;
            model = new QuanLyBoDeNgoaiNguModel1();
            InitializeComponent();
            
        }

        public Editcomposition(Composition comp, QuanLySuatThi quanLySuatThi)
        {
            List<Level> levels;
            model = new QuanLyBoDeNgoaiNguModel1();

            InitializeComponent();
            
            levels = model.Levels.ToList();

            // lưu vào biến toàn cục
            this.quanLySuatThi = quanLySuatThi;
            this.comp = comp;

        }

        private void ddtEndtime_ValueChanged(object sender, EventArgs e)
        {

        }

        // Save
        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ database
            Composition composition = model.Compositions.FirstOrDefault(c => c.CompositionID == comp.CompositionID);

            composition.CompositionDate = ddtNgayThi.Value;
            composition.StartTime = ddtStartime.Value;
            composition.EndTime = ddtEndtime.Value;

            var levelId = model.Levels.FirstOrDefault(
                c => c.LevelName == cmbBacST.SelectedItem.ToString()).LevelID;
            composition.Level.LevelID = levelId;


            model.SaveChanges();

            quanLySuatThi.Refesh();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Load
        private void Editcomposition_Load(object sender, EventArgs e)
        {
            ddtNgayThi.Value = comp.CompositionDate;
            ddtStartime.Value = comp.StartTime;
            ddtEndtime.Value = comp.EndTime;
            
            var levelID = model.Compositions.Where(c => c.CompositionID == comp.CompositionID).Select(c => c.Level).FirstOrDefault().LevelID;

            // Xóa hết
            cmbBacST.Items.Clear();
            //
            List<Level> levels;
            levels = model.Levels.ToList();

            // lay database
            int i = 0;
            foreach (Level level in levels)
            {
                if (level.LevelName != null)
                {
                    cmbBacST.Items.Add(level.LevelName);
                    if(levelID == level.LevelID)
                        cmbBacST.SelectedIndex = i;
                }
                i++;
            }
        }
    }
}
