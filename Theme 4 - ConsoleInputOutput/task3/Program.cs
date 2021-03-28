using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Write company adress: ");
            string companyAdress = Console.ReadLine();
            Console.Write("Write company phone: ");
            string companyPhone = Console.ReadLine();
            Console.Write("Write company fax number: ");
            string companyFax = Console.ReadLine();
            Console.Write("Write company website: ");
            string companyWebSite = Console.ReadLine();
            Console.Write("Write manager name: ");
            string managerName = Console.ReadLine();
            Console.Write("Write manager surname: ");
            string managerSurname = Console.ReadLine();
            Console.Write("Write manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Company Info:");
            Console.WriteLine(companyName);
            Console.WriteLine(companyAdress);
            Console.WriteLine(companyPhone);
            Console.WriteLine(companyWebSite);

            Console.WriteLine();
            Console.WriteLine("Manager Info:");
            Console.WriteLine(managerName);
            Console.WriteLine(managerSurname);
            Console.WriteLine(managerPhone);

        }
    }
}
