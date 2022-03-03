using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private int age;

        private string name;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
