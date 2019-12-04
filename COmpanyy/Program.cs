using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmpanyy
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of Persons
            List<Person> Persons = new List<Person>();
           Persons.Add(new Person(){   Id = 10, Name = "Steve", LastName = "Jobs" });
            Persons.Add(new Person() { Id = 20, Name = "Mike", LastName = "San" });
            Persons.Add(new Person() { Id = 30, Name = "John", LastName = "Lenon" });

            foreach (var item in Persons)
            {
                Console.WriteLine($"{item.Id}, {item.Name}, {item.LastName}");
            }
            Console.WriteLine();
            Console.WriteLine();




            //List of Cusmoters
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new Customer() { Name = "Steve", LastName = "Jobs",Amount=1000 });
            Customers.Add(new Customer() { Name = "Mike", LastName = "San",Amount=2000 });
            Customers.Add(new Customer() { Name = "John", LastName = "Lenon",Amount=3000 });
            

            foreach (var item in Customers)
            {
                Console.WriteLine($" {item.Name}, {item.LastName}, {item.Amount}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            //List of Developers
            List<Developer> Developers = new List<Developer>();
            Developers.Add(new Developer() { Name = "Steve", LastName = "Jobs", ProjectName="Matrix", ProjectStartDate=new DateTime(2019,11,30),ProjectState=State.Closed });
            Developers.Add(new Developer() { Name = "Mike", LastName = "San", ProjectName = "Matrix", ProjectStartDate = new DateTime(2018, 11, 30), ProjectState = State.Closed });
            Developers.Add(new Developer() { Name = "John", LastName = "Lenon", ProjectName = "Matrix", ProjectStartDate = new DateTime(2015, 11, 22), ProjectState = State.Open });


            foreach (var item in Developers)
            {
                Console.WriteLine($" {item.Name}, {item.LastName}, {item.ProjectState}, {item.ProjectStartDate}, {item.ProjectName}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //List of Managers
            List<Manager> Managers = new List<Manager>();
            Managers.Add(new Manager() { Name = "Steve", LastName = "Jobs" });
            Managers.Add(new Manager() { Name = "Mike", LastName = "San" });
            Managers.Add(new Manager() { Name = "John", LastName = "Lenon" });


            foreach (var item in Managers)
            {
                Console.WriteLine($" {item.Name}, {item.LastName}");
            }



            //Employee Employee1 = new Employee() { Salary = 100, department=Department.Accounting  , Name = "Mark", LastName = "Zuckerberg" };
            //Console.WriteLine(Employee1);           
            //SalesEmployee SalesEmployee1 = new SalesEmployee() { ProductName = "FirstSalesProduct", ProductDate = new DateTime(2019, 11, 11), ProductPrice = 2000 };
            //Console.WriteLine(SalesEmployee1);
            //Customer Customer1 = new Customer() {Name="John",LastName="Lenon",Amount=1000 };
            //Console.WriteLine(Customer1);




            //vehicles.Add(new Bike() { Model = "BMX", Year = 2005, IsRentable = true });
            //vehicles.Add(new Car() { Model = "BMW", Year = 2009, IsRentable = true });
            //vehicles.Add(new Car() { Model = "Nissan", Year = 2010, IsRentable = false });

            //bikes.Add(new Bike() { Model = "BMX", Year = 2005, IsRentable = true });
            //bikes.Add(new Bike() { Model = "Trek", Year = 2010, IsRentable = false });
        }
    }
}
