using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDeNgoaiNgu.Entities
{
    public class Subject
    {
        [Key]
        public int SubjectID { get; set; }
        public string Name { get; set; }


    }
}
