using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmpanyy
{
    class Employee : Person, IEmployee
    {
        public int Salary { get; set; }
       public Department department { get; set; }
     

        public Employee()
        { }
        public Employee(int salary,  Department department) : base()
        {
            this.Salary = salary;
            this.department = department;
            
        }
        public override string ToString()
        {
            return $"Person's Salary--{Salary}, Department--{department}, Name--{Name}, LastName--{LastName}";
        }

    }
}

