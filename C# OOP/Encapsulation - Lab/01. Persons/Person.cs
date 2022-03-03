using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }
        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get => this.age;
            internal set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative integer!");
                }
                this.age = value;
            }
        }

        public decimal Salary
        {
            get => this.salary;
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                this.salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            int delimiter = 100;

            if (Age < 30)
            {
                Salary = Salary + Salary * percentage / delimiter / 2;
            }
            else
            {
                Salary = Salary + Salary * percentage / delimiter;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} gets {this.Salary:f2} leva.";
        }
    }
}
