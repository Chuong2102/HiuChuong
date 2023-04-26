using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDeNgoaiNgu.Entities
{
    public class Composition
    {
        [Key]
        public int CompositionID { get; set; }
        public DateTime StartTime { get ; set; }
        public DateTime EndTime { get; set; }
        public DateTime CompositionDate { get; set; }
    }
}
