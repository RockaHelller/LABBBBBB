using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _2December_Lab
{
    public class Department
    {
        public string? Name { get; set; }
        public int Capacity { get; set; }

        public List<Employee> employees;
        public static List<Department> departments = new List<Department>(); 
       
        public Department(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            employees = new List<Employee>();
        }




    }
}
