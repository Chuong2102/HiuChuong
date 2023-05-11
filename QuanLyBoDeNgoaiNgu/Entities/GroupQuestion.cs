using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDeNgoaiNgu.Entities
{
    public class GroupQuestion
    {
        [Key]
        public int GroupQuestionID { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public ICollection<Question> Questions { get; set;}
    }
}
