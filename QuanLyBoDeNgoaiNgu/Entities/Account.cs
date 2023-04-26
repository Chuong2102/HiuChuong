using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDeNgoaiNgu.Entities
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User User { get; set; }
    }
}
