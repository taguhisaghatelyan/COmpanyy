using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmpanyy
{
    class Customer : Person
    {
        public int Amount { get; set; }
        public Customer()
        {
        }
        public Customer(int amount):base()
        {
            this.Amount = amount;           
        }

        public override string ToString()
        {
            return $" {Name}  {LastName}  {Amount} ";
        }


    }
}
