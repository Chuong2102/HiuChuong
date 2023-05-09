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
        public ThemSuatThi()
        {
            model = new QuanLyBoDeNgoaiNguModel1();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Composition composition = new Composition();

            composition.CompositionDate = ddtNgayThi.Value;
            composition.StartTime = ddtStartime.Value;
            composition.EndTime = ddtEndtime.Value;

            var levelId = model.Levels.FirstOrDefault(
                c => c.LevelName == cmbBacST.SelectedItem.ToString()).LevelID;
           
            model.Compositions.Add(composition);

            model.SaveChanges();

           
           
        }
    }
}
