using System;
namespace ConAppParameterizedConstructor
{
    public class Student
    {
        readonly int id;
        readonly string name;
        readonly DateTime dob;
        public Student(int id, string name, DateTime dob)
        {
            Console.WriteLine("Parameterized Constructor of Student");
            this.id = id;
            this.name = name;
            this.dob = dob;
        }
        public void Display()
        {
            Console.WriteLine("Student Details as follows !!!");
            Console.WriteLine("ID :->" + id + "\t Name:-> " + name + "\tDate of Birth :->" + dob);
        }
    }
}
