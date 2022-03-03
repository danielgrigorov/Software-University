﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;

        private int age;

        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.name = value;
            }
        }

        public int Age 
        {
            get => this.age;
            set 
            {
                if (int.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.name = value;
            } 
        }

        public string Gender { get; set; }
    }
}
