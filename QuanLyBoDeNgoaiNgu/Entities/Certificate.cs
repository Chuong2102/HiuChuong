using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDeNgoaiNgu.Entities
{
    public class Certificate
    {
        [Key]
        public int CertificateID { get; set; }
        public Level Level { get; set; }
        public Subject Subject { get; set; }
        public User User { get; set; }

    }
}
