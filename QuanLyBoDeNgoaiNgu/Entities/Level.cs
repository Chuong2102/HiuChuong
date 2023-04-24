using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDeNgoaiNgu.Entities
{
    public class Level
    {
        [Key]
        public int LevelID { get; set; }
        public int LevelName { get; set; }
        public int LevelMaxScore { get; set; }  
        public User User { get; set; }

    }
}
