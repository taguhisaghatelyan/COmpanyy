using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmpanyy
{
    interface IEmployee
    {
        //general class for all employees,
        // holding the field salaryand department. 
        // The departmentcan only have one of the followingvalues: 
        // Production, Accounting, Salesor Marketing
        int Salary { get; set; }
    }
}
