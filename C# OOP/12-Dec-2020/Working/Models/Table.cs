using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models
{
    public abstract class Table : ITable
    {
        private int capacity;

        private int numberOfPeople;

        private List<IBakedFood> foodOrders;

        private List<IDrink> drinkOrders;

        protected Table(int tableNumber, int capacity, decimal initialPricePerPerson)
        {
            this.TableNumber = tableNumber;
            this.Capacity = capacity;
            this.PricePerPerson = initialPricePerPerson;
            this.foodOrders = new List<IBakedFood>();
            this.drinkOrders = new List<IDrink>();
            this.IsReserved = false;
        }

        
        protected Table(int tableNumber, int capacity, int pricePerPerson)
        {
            this.TableNumber = tableNumber;
            this.Capacity = capacity;
            this.PricePerPerson = pricePerPerson;
        }

        public int TableNumber { get; private set; }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTableCapacity);
                }
                this.capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get
            {
                return this.numberOfPeople;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNumberOfPeople);
                }
                this.numberOfPeople = value;
            }
        }

        public decimal PricePerPerson {get; private set;}

        public bool IsReserved { get; private set; }

        public decimal Price
        {
            get
            {
                return NumberOfPeople * PricePerPerson;
            }
        }

        public void Clear()
        {
            this.numberOfPeople = 0;
            this.drinkOrders.Clear();
            this.foodOrders.Clear();
            this.Capacity += NumberOfPeople;
            IsReserved = false;
        }

        public decimal GetBill()
        {
            var bill = 0m;

            foreach (var food in foodOrders)
            {
                bill += food.Price;
            }
            foreach (var drink in drinkOrders)
            {
                bill += drink.Price;
            }

            bill += Price;
            return bill;
        }

        public string GetFreeTableInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Table: {this.TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {this.Capacity}");
            sb.AppendLine($"Price per Person: {this.PricePerPerson:f2}");

            return sb.ToString().TrimEnd();
        }

        public void OrderDrink(IDrink drink)
        {
            this.drinkOrders.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            this.foodOrders.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            if (this.Capacity >= numberOfPeople)
            {
                IsReserved = true;
                this.NumberOfPeople = numberOfPeople;
            }
            
        }
    }
}
