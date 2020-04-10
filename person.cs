using System;
using System.Collections.Generic;
using System.Text;

namespace tugasInheritance
{
    public class Person
    {
        public Person(string nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }

        public string Nama { get; set; }
        public int Umur { get; set; }

        public void GetNamaAndUmur()
        {
            Console.WriteLine("orang mempunyai nama : {0} dan umur : {1} ", Nama, Umur);
        }

    }
}