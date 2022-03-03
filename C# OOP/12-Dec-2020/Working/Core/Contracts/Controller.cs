using Bakery.Models;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Core.Contracts
{
    public class Controller : IController
    {
        private List<IBakedFood> bakedFoods;

        private List<IDrink> drinks;

        private List<ITable> tables;

        private decimal totalIncome;

        public Controller()
        {
            this.bakedFoods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();
            this.tables = new List<ITable>();
        }
        public string AddDrink(string type, string name, int portion, string brand)
        {
            if (type == "Tea")
            {
                var tea = new Tea(name, portion, brand);
                drinks.Add(tea);
            }
            if (type == "Water")
            {
                var water = new Water(name, portion, brand);
                drinks.Add(water);
            }

            return String.Format(OutputMessages.DrinkAdded, name, brand);
        }

        public string AddFood(string type, string name, decimal price)
        {
            if (type == "Bread")
            {
                var bread = new Bread(name, price);
                bakedFoods.Add(bread);
            }
            if (type == "Cake")
            {
                var cake = new Cake(name, price);
                bakedFoods.Add(cake);
            }

            return String.Format(OutputMessages.FoodAdded, name, type);
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            if (type == "InsideTable")
            {
                var insideTable = new InsideTable(tableNumber, capacity);
                tables.Add(insideTable);
            }
            if (type == "OutsideTable")
            {
                var outsideTable = new OutsideTable(tableNumber, capacity);
                tables.Add(outsideTable);
            }

            return String.Format(OutputMessages.TableAdded, tableNumber);
        }

        public string GetFreeTablesInfo()
        {
            List<ITable> notReservedTables = new List<ITable>();
            string result = "";

            foreach (var table in tables)
            {
                if (table.IsReserved == false)
                {
                    notReservedTables.Add(table);
                }
            }

            foreach (var notReservedTable in notReservedTables)
            {
                result += notReservedTable.GetFreeTableInfo() + Environment.NewLine;
            }
            return result.TrimEnd();
        }

        public string GetTotalIncome()
        {
            return $"Total income: {totalIncome:f2}lv";
        }

        public string LeaveTable(int tableNumber)
        {
            var table = this.tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            var bill = table.GetBill();
            totalIncome += bill;
            table.Clear();

            var sb = new StringBuilder();

            sb.AppendLine($"Table: {tableNumber}");
            sb.AppendLine($"Bill: {bill:f2}");

            return sb.ToString().TrimEnd();
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            var hasTable = this.tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            var hasDrinkName = this.drinks.FirstOrDefault(x => x.Name == drinkName && x.Brand == drinkBrand);

            if (hasTable == null)
            {
                return String.Format(OutputMessages.WrongTableNumber, tableNumber);
            }

            else if (hasDrinkName == null)
            {
                return String.Format(OutputMessages.NonExistentDrink, drinkName, drinkBrand);
            }

            hasTable.OrderDrink(hasDrinkName);
            return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            var hasTable = this.tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            var hasFoodName = this.bakedFoods.FirstOrDefault(x => x.Name == foodName);

            if (hasTable == null)
            {
                return String.Format(OutputMessages.WrongTableNumber, tableNumber);
            }

            else if (hasFoodName == null)
            {
                return String.Format(OutputMessages.NonExistentFood, foodName);
            }

            hasTable.OrderFood(hasFoodName);
            return String.Format(OutputMessages.FoodOrderSuccessful, tableNumber, foodName);

        }

        public string ReserveTable(int numberOfPeople)
        {
            var hasTable = this.tables.FirstOrDefault(x => x.Capacity >= numberOfPeople && x.IsReserved == false);

            if (hasTable == null)
            {
                return String.Format(OutputMessages.ReservationNotPossible, numberOfPeople);
            }

            else
            {
                hasTable.Reserve(numberOfPeople);
                return String.Format(OutputMessages.TableReserved, hasTable.TableNumber, numberOfPeople);
            }
        }
    }
}
