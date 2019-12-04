using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmpanyy
{
    class Manager:Employee
    {
       
       public List<Employee> Employees { get; set; }
        public Manager()
        {
            
        }
        public Manager (  string name, string lastname, double salary, Department department, List<Employee> employees) :base()
        {
            this.Employees = new List<Employee>();

        }
        public override string ToString()
        {
            return $"{Name} {LastName} {Salary} {department} {Employees}";
        }
    }
}
