using System;

namespace procedrualprogramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //RemoveStudent();
            //AddTeacher();
            Student s1 = new Student();
            s1.AddStudent();
            s1.RemoveStudent();
            Teacher t1 = new Teacher();
        }


        public void AddEmployee()
        {
            Console.WriteLine("Adding new Employee");
        }
    }
}
