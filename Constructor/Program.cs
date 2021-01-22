using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 1, FirstName = "Tolga", LastName = "Hastaoğlu", City = "Sivas" };
            Customer customer2 = new Customer(2, "Hülya", "Acabay", "Manisa");
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer1.FirstName);
        }
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstname,string lastname, string city)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
