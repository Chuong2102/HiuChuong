using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDeNgoaiNgu.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get;set; }
        public string Email { get; set; }
        public Account Account { get; set; }
    }
}
