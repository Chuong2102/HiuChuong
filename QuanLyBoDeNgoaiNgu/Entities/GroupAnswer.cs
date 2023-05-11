using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDeNgoaiNgu.Entities
{
    public class GroupAnswer
    {
        [Key]
        public int GroupAnswerID { get; set; }
        public string GroupAnswerName { get; set; }
        public Subject Subject { get; set; }
        public ICollection<Answer> Answers { get; set; }

    }
}
