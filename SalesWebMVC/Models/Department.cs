using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Department()
        {
        }

        public Department(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
