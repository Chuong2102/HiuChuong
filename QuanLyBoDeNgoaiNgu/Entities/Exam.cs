using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDeNgoaiNgu.Entities
{
    public class Exam
    {
        [Key]
        public int EntityID { get; set; }
        TimeSpan Time { get; set; }
        public int Score { get; set; }
        public Level Level { get; set; }
        public Composition Composition { get; set; }

    }
}
