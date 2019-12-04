using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmpanyy
{
    class Person : IPerson
    {
        private int ID;
        public int Id
        {
            get => ID;

            set => ID = value;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Person()
        {

        }
        public Person(int id, string name, string lastName)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            return $"Person ID--{ID}, Name--{Name},  LastName--{LastName}";
        }
    }
}

