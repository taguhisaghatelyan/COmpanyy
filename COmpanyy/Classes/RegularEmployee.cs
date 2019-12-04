using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmpanyy
{
    class RegularEmployee : Person
    {
       
        public RegularEmployee():base()
        {

        }
      
        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
    }
}
