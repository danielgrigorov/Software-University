using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizens : Inameable, IAgeable, Idable, IBuyer
    {
        private string name;

        private int age;

        private string id;

        private string birthdate;

        private int food;

        public Citizens(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthdate;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }

        public string BirthDate { get; set; }
        public int Food 
        { 
            get => this.food; 
            set => this.food = 0; 
        }

        public void BuyFood(int currentFood)
        {
            this.food += currentFood;
        }
    }
}
