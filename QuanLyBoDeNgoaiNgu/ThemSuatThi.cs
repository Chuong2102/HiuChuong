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
                cmbBacST.Items.Add(level.LevelName);
            }
        }
    }
}
