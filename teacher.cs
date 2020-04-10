using System;
using System.Collections.Generic;
using System.Text;

namespace tugasInheritance
{
    public class Teacher : Person
    {
        public Teacher(string nama, int umur, string teacherid, string subject)
        : base(nama, umur)
        {
            TeacherId = teacherid;
            Subject = subject;
        }

        public string TeacherId { get; set; }
        public string Subject { get; set; }

    }
}