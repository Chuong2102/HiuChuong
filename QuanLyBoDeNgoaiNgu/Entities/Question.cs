using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDeNgoaiNgu.Entities
{
    public class Question
    {
        [Key]
        public int QuestionID { get; set; }
        public string Text { get; set; }
        public Level Level { get; set; }
        public int CorrectAnswerID { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
