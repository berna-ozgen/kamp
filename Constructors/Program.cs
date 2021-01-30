using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1,"Berna","Özgen","İzmir");
            Customer customer2 = new Customer();
            customer2.Id = 3;
            customer2.FirstName = "Berna";
            customer2.LastName = "Özgen";
            customer2.City = "İzmir";

            Console.WriteLine(customer1.Id);
            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer1.LastName);
            Console.WriteLine(customer1.City);

        }
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
