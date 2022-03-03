using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name = "No name";
        private int age;

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public int Age 
        {
            get => this.age;
            set
            {
                if (value > 30)
                {
                    this.age = value;
                }
            }
        }


        public Person()
        {
            
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(int age)
        {
            this.Age = age;
        }
    }
}
