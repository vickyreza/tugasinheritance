using System;

namespace tugasInheritance
{
    public class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person("Vicky", 18);
            person.GetNamaAndUmur();

            Teacher teacher = new Teacher("Reza", 19, "3543", "languange");
            teacher.GetNamaAndUmur();

            Student student = new Student("fadillah", 17, "3133", "Fadiloutsider6@gmail.com");
            student.GetNamaAndUmur();
        }
    }
}
