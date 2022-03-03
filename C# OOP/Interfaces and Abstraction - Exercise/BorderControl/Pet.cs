using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet
    {
        private string name;

        private string birthDate;

        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public string Name { get; set; }

        public string BirthDate { get; set; }
    }
}
