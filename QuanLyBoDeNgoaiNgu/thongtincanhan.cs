using QuanLyBoDeNgoaiNgu.Entities;
using QuanLyBoDeNgoaiNgu.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;

namespace QuanLyBoDeNgoaiNgu
{
    public partial class thongtincanhan : Form
    {
        QuanLyBoDeNgoaiNguModel1 model = new QuanLyBoDeNgoaiNguModel1();
        User userModel;
        Certificate certificateModel;
        public thongtincanhan()
        {
            InitializeComponent();
        }

        public thongtincanhan(User user)
        {
            InitializeComponent();

            userModel = user;
            var listcer = model.Certificates.Where(c => c.User.UserID == userModel.UserID).ToList();
            //
            lbTen.Text = userModel.FullName;
            lbMa.Text = userModel.StudentID;
            lbEmail.Text = userModel.Email;

            foreach (var cert in listcer)
            {
                var sub = model.Certificates.Where(
                    c => c.CertificateID == cert.CertificateID).Select(c => c.Subject).FirstOrDefault();
                if (sub.Name == "English")
                {
                    var le = model.Certificates.Where(
                        c => c.CertificateID == cert.CertificateID).Select(c => c.Level).FirstOrDefault();
                    lbBacTA.Text = le.LevelName;
                }
                else
                if (sub.Name == "Japanese")
                {
                    var le = model.Certificates.Where(
                        c => c.CertificateID == cert.CertificateID).Select(c => c.Level).FirstOrDefault();
                    lbBacTN.Text = le.LevelName;
                }
                else
                if (sub.Name == "Chinese")
                {
                    var le = model.Certificates.Where(
                        c => c.CertificateID == cert.CertificateID).Select(c => c.Level).FirstOrDefault();
                    lbBacTH.Text = le.LevelName;
                }
                else
                if (sub.Name == "Korean")
                {
                    var le = model.Certificates.Where(
                        c => c.CertificateID == cert.CertificateID).Select(c => c.Level).FirstOrDefault();
                    lbBacTN.Text = le.LevelName;
                }
            }



        }
    }
}
