using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private string name;
        private int age;
        private string id;
        private string birthDate;

        public Citizen(string name, int age, string id, string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthDate;
        }

        public string Name 
        { 
            get => this.name; 
            set => this.name = value; 
        }

        public int Age 
        { 
            get => this.age; 
            set => this.age = value; 
        }

        public string Id 
        { 
            get => this.id; 
            set => this.id = value; 
        }

        public string Birthdate 
        { 
            get => this.birthDate; 
            set => this.birthDate = value; 
        }
    }
}
