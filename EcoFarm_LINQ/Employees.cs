using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFarm_LINQ
{
    class Employees
    {
        public Employees(string Name, int Age, string Company)
        {
            this.Name = Name;
            this.Age = Age;
            this.Company = Company;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}
