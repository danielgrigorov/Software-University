using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;

        public Bakery(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Employee>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Employee> Data
        {
            get => this.data;
        }

        public void Add(Employee employee)
        {
            if (this.data.Count +1 <= this.Capacity)
            {
                this.data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            var employeeToRemove = this.data.FirstOrDefault(x => x.Name == name);

            if (employeeToRemove == null)
            {
                return false;
            }

            this.data.Remove(employeeToRemove);
            return true;
        }

        public Employee GetOldestEmployee()
        {
            var oldestEmployeeToGet = this.data.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldestEmployeeToGet;
        }

        public Employee GetEmployee(string name)
        {
            var employeeToGet = this.data.FirstOrDefault(x => x.Name == name);

            return employeeToGet;
        }

        public int Count => this.data.Count();

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Employees working at Bakery {this.Name}:");

            foreach (var item in this.data)
            {
                sb.AppendLine($"{item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
