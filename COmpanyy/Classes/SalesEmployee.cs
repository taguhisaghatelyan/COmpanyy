using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmpanyy
{
    class SalesEmployee 
    {
        public string ProductName { get ; set; }
        public DateTime ProductDate { get ; set ; }
        public int ProductPrice { get ; set ; }
        public SalesEmployee()
        { }
        public SalesEmployee(string productName, DateTime productDate, int productPrice)
        {
            this.ProductName = productName;
            this.ProductDate = ProductDate;
            this.ProductPrice = productPrice;
            //
        }
        public override string ToString()
        {

            return $"Product Name is {ProductName}, Product Date is {ProductDate}, Pruduct Price is{ProductPrice} ";

        }
    }
}
