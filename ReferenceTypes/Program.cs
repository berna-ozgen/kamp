using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Value types
            //int sayi1=10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("sayi = " + sayi1);

            ////Reference types
            //int[] array1 = new int[] { 1,2,3};
            //int[] array2 = new int[] { 10,20,30 };
            //array1 = array2;
            //array2[0] = 1000;

            //Console.WriteLine("array1[0]= "+array1[0]);

            Person person1 = new Person();
            person1.FirstName = "Berna";
            Customers customers = new Customers();
            customers.FirstName = "Melis";
            Employee employee1 = new Employee();
            employee1.FirstName = "Tuana";
            PersonManager personManager = new PersonManager();
            personManager.Add(person1);
            personManager.Add(customers);
            personManager.Add(employee1);


        }
    }
    //base class(temel sınıf) ->Person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customers:Person
    {
        public string CreditCardNumber { get; set; }

    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
