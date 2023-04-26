using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDeNgoaiNgu.Entities
{
    public class Answer
    {
        [Key]
        public int AnswerID { get; set; }
        public string Text { get; set; }
        public ICollection<Question> Questions { get; set; }

    }
}
