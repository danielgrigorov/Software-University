using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Age { get; set; }
        public string HomeTown { get; set; }

    }
}



namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] token = command.Split();

                string firstName = token[0];
                string lastName = token[1];
                string age = token[2];
                string homeTown = token[3];

                Student currentStudent = new Student();

                currentStudent.FirstName = firstName;
                currentStudent.LastName = lastName;
                currentStudent.Age = age;
                currentStudent.HomeTown = homeTown;

                list.Add(currentStudent);
            }

            string resultCity = Console.ReadLine();

            foreach (Student currentStudent in list)
            {
                if (resultCity == currentStudent.HomeTown)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }
    }
}
