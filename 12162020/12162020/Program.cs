using System;
using System.Collections.Generic;

namespace _12162020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student dude = new Student();
            dude.Name = "Emioglu";

            Address ad = new Address();

            dude.AddressElovset = ad;

            // one - to - one 
            Console.WriteLine(dude.AddressElovset.ZipCode);

            Subject csharp = new Subject();
            csharp.Name = "C#";
            csharp.Faculty = "Computer Science";


            dude.Subjects.Add(csharp);
            dude.Subjects.Add(csharp);
            dude.Subjects.Add(csharp);
            dude.Subjects.Add(csharp);

        }

    }

    class Student
    {
        public string Name { get; set; }
        public Address AddressElovset { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student()
        {
            this.Subjects = new List<Subject>();
        }
    }

    class Address
    {
        public string City { get; set; }
        public string FirstLine { get; set; }
        public string SecondLine { get; set; }
        public string ZipCode { get; set; }
    }

    class Subject
    {
        public string Faculty { get; set; }
        public string Name { get; set; }
    }
}
