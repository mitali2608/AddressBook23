using System;
using System.Collections.Generic;
using System.Text;


namespace AddressBook23
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook1 obj = new AddressBook1();
            int choice = 0;
            while (choice != 10)
            {

                Console.WriteLine("\n Menu:");
                Console.WriteLine("*************************");
                Console.WriteLine("1.Add Contacts");
                Console.WriteLine("2.Print Addressbook");
                Console.WriteLine("3.Remove");
                Console.WriteLine("4.Edit");
                Console.WriteLine("5.Search contact by city or state");
                Console.WriteLine("6.View contacts by state");
                Console.WriteLine("7.View contacts by city");
                Console.WriteLine("8.View count of contacts by state");
                Console.WriteLine("9.View count of contacts by city");
                Console.WriteLine("10.Exit");
                Console.WriteLine("----------------------------------------");






                Console.WriteLine("Please enter your choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("\n Adding record in Address Book");
                        Console.WriteLine(" \n Enter number of contacts want to store :");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("-----------------------------------------------------");
                        for (int i = 0; i < n; i++)
                        {
                            obj.AddContact();
                        }
                        Console.WriteLine("-----------------------------------------------------");

                        break;
                    case 2:
                        Console.WriteLine("Address Book:");
                        Console.WriteLine("-----------------------------------------------------");
                        obj.ListPeople();
                        Console.WriteLine("-----------------------------------------------------");

                        break;
                    case 3:
                        Console.WriteLine("Remove Contact:");
                        Console.WriteLine("-----------------------------------------------------");

                        obj.RemoveContact();
                        Console.WriteLine("-----------------------------------------------------");

                        break;
                    case 4:
                        Console.WriteLine("Edit Contact :");
                        Console.WriteLine("-----------------------------------------------------");

                        obj.EditContact();
                        Console.WriteLine("-----------------------------------------------------");

                        break;
                    case 5:
                        Console.WriteLine("Search contact by city or state :");
                        Console.WriteLine("-----------------------------------------------------");

                        Console.WriteLine(" \n Enter state or city to get contacts:");
                        string place = Console.ReadLine();
                        obj.search(place);
                        Console.WriteLine("-----------------------------------------------------");

                        break;
                    case 6:
                        Console.WriteLine("View contacts by state :");
                        Console.WriteLine("-----------------------------------------------------");

                        Console.WriteLine(" \n Enter state:");
                        string state = Console.ReadLine();

                        obj.viewPersonByState(state);
                        Console.WriteLine("-----------------------------------------------------");

                        break;

                    case 7:
                        Console.WriteLine("View contacts by city :");
                        Console.WriteLine("-----------------------------------------------------");

                        Console.WriteLine(" \n Enter city:");
                        string city = Console.ReadLine();

                        obj.viewPersonByCity(city);
                        Console.WriteLine("-----------------------------------------------------");

                        break;
                    case 8:
                        Console.WriteLine("View count of contacts by state :");
                        Console.WriteLine("-----------------------------------------------------");

                        obj.viewListPersonByState();
                        Console.WriteLine("-----------------------------------------------------");

                        break;

                    case 9:
                        Console.WriteLine("View contacts by city :");
                        Console.WriteLine("-----------------------------------------------------");

                        obj.viewListPersonByCity();
                        Console.WriteLine("-----------------------------------------------------");
                        break;

                }
            }

        }

    }
}
