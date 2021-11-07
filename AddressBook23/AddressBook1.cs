using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook23
{
    public class contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
    }
    class AddressBook1
    {
        
        public List<contact> People = new List<contact>();
        internal void AddContact()
        {
            contact person = new contact();

            Console.WriteLine("First Name :");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Last Name :");
            person.LastName = Console.ReadLine();

            if (duplicateCheck(person.FirstName, person.LastName) == true)
            {
                return;
            }
            else
            {
                Console.WriteLine("Address :");
                person.Address = Console.ReadLine();

                Console.WriteLine("City :");
                person.City = Console.ReadLine();

                Console.WriteLine("State :");
                person.State = Console.ReadLine();

                Console.WriteLine("Zip :");
                person.Zip = Console.ReadLine();

                Console.WriteLine("Phone Number :");
                person.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Email :");
                person.Email = Console.ReadLine();
            }
            People.Add(person);

        }
        internal bool duplicateCheck(string fname, string lname)
        {
            for (int j = 0; j < People.Count; j++)
            {
                var temp = People.ElementAt(j);
                if (temp.FirstName.Equals(fname) && temp.LastName.Equals(lname))
                {
                    Console.WriteLine("Contact already exists!!Please enter a different contact name");
                    return true;
                }
            }
            return false;
        }

        internal void Print(contact person)
        {
            Console.WriteLine("First Name   : " + person.FirstName);
            Console.WriteLine("Last Name    : " + person.LastName);
            Console.WriteLine("Address      : " + person.Address);
            Console.WriteLine("City         : " + person.City);
            Console.WriteLine("State        : " + person.State);
            Console.WriteLine("Zip          : " + person.Zip);
            Console.WriteLine("Phone Number : " + person.PhoneNumber);
            Console.WriteLine("Email        : " + person.Email);
            Console.WriteLine("---------------------------------------");

        }

        internal void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("\n Address Book:");
            foreach (var person in People)
            {
                Print(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        internal void RemoveContact()
        {
            Console.WriteLine("Enter the first name you want to remove.");
            string firstName = Console.ReadLine();
            contact person = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());

            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue. ");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Are you sure you want to remove this person from the address book? (Y/N)");
            Print(person);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                People.Remove(person);
                Console.WriteLine("Person removed. Press any key to continue");
                Console.ReadKey();
            }
        }
        internal void EditContact()
        {
            //    Console.WriteLine("Enter the first name of the contact you want to edit");
            //    string initial = Console.ReadLine();
            //    contact person = People.FirstOrDefault(x => x.FirstName.ToLower() == initial.ToLower());


            //    if (person == null)
            //    {
            //        Console.WriteLine("That person could not be found. Press any key to continue. ");
            //        Console.ReadKey();
            //        return;
            //    }

            //    Console.WriteLine("Are you sure you want to edit this person from the address book? (Y/N)");
            //    Print(person);

            //    if (Console.ReadKey().Key == ConsoleKey.Y)
            //    {
            //       People.Remove(person);
            //        Console.WriteLine("Person removed. Press any key to continue");
            //        Console.ReadKey();
            //    }

            //    AddContact();

            //    Console.WriteLine("edited succesfully");
            //}

            Console.WriteLine("Enter the person whose contact to be edited :");
            Console.WriteLine("Enter First Name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lname = Console.ReadLine();
            int flag = 0;
            for (int j = 0; j < People.Count; j++)
            {
                contact person = People.ElementAt(j);
                if (person.FirstName.Equals(fname) && person.LastName.Equals(lname))
                {
                    flag = 1;
                    Console.WriteLine("First Name : " + person.FirstName);
                    Console.WriteLine("Last Name  : " + person.LastName);
                    Console.WriteLine("Address    : " + person.Address);
                    Console.WriteLine("City       : " + person.City);
                    Console.WriteLine("State      : " + person.State);
                    Console.WriteLine("Zip        : " + person.Zip);
                    Console.WriteLine("Phone Number:" + person.PhoneNumber);
                    Console.WriteLine("Email      : " + person.Email);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine(
                            "Enter the number which you want to edit\n1.First Name\n2.Last Name\n3.Address\n4.C\n5.State\n6.Zip\n7.Phone Number\n8.Email");
                    int choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("first name:");
                            person.FirstName = Console.ReadLine();
                            Console.WriteLine("edited succesfully");
                            break;
                        case 2:
                            Console.WriteLine("last name:");
                            person.LastName = Console.ReadLine();
                            Console.WriteLine("edited succesfully");
                            break;
                        case 3:
                            Console.WriteLine("address:");
                            person.Address = Console.ReadLine();
                            Console.WriteLine("edited succesfully");
                            break;

                        case 4:
                            Console.WriteLine("city:");
                            person.City = Console.ReadLine();
                            Console.WriteLine("edited succesfully");
                            break;
                        case 5:
                            Console.WriteLine("state:");
                            person.State = Console.ReadLine();
                            Console.WriteLine("edited succesfully");
                            break;
                        case 6:
                            Console.WriteLine("zip:");
                            person.Zip = Console.ReadLine();
                            Console.WriteLine("edited succesfully");
                            break;
                        case 7:
                            Console.WriteLine("phone_number:");
                            person.PhoneNumber = Console.ReadLine();
                            Console.WriteLine("edited succesfully");
                            break;
                        case 8:
                            Console.WriteLine("email:");
                            person.Email = Console.ReadLine();
                            Console.WriteLine("edited succesfully");
                            break;
                    }
                }
            }
            if (flag == 0)
                Console.WriteLine("Contact not found!!!");


        }

        internal void search(string place)
        {
            for (int j = 0; j < People.Count; j++)
            {
                contact person = People.ElementAt(j);
                if (person.City.Equals(place) || person.State.Equals(place))
                {

                    {
                        Console.WriteLine(person.FirstName + " " + person.LastName);
                    }
                }

            }
        }


        internal void viewPersonByState(String state)
        {
            Dictionary<String, String> cityMap = new Dictionary<String, String>();
            for (int j = 0; j < People.Count; j++)
            {
                contact person = People.ElementAt(j);
                cityMap.Add(person.FirstName, person.State);
            }
            foreach (var m in cityMap)
            {
                if (m.Value.Equals(state))
                {
                    Console.WriteLine(m.Key);
                }
            }
        }

        internal void viewPersonByCity(String city)
        {
            Dictionary<String, String> cityMap = new Dictionary<String, String>();
            for (int j = 0; j < People.Count; j++)
            {
                contact person = People.ElementAt(j);
                cityMap.Add(person.FirstName, person.City);
            }
            foreach (var m in cityMap)
            {
                if (m.Value.Equals(city))
                {
                    Console.WriteLine(m.Key);
                }
            }
        }

        internal void viewListPersonByState()
        {
            Dictionary<String, List<String>> stateMap = new Dictionary<String, List<String>>();
            for (int j = 0; j < People.Count; j++)
            {
                contact person = People.ElementAt(j);
                if (stateMap.ContainsKey(person.State))
                {
                    List<String> temp = stateMap[person.State];
                    temp.Add(person.FirstName);
                    stateMap.Add(person.State, temp);
                }
                else
                {
                    var temp = new List<String>();
                    temp.Add(person.FirstName);
                    stateMap.Add(person.State, temp);
                }
            }
            foreach (var m in stateMap)
            {

                // Console.WriteLine(m.Key + " : " + m.Value);
                Console.WriteLine("There are " + m.Value.Count + " persons in state " + m.Key);
            }
        }


        internal void viewListPersonByCity()
        {
            Dictionary<String, List<String>> cityMap = new Dictionary<String, List<String>>();
            for (int j = 0; j < People.Count; j++)
            {
                contact person = People.ElementAt(j);
                if (cityMap.ContainsKey(person.City))
                {
                    List<String> temp = cityMap[person.City];
                    temp.Add(person.FirstName);
                    cityMap.Add(person.City, temp);
                }
                else
                {
                    var temp = new List<String>();
                    temp.Add(person.FirstName);
                    cityMap.Add(person.City, temp);
                }
            }
            foreach (var m in cityMap)
            {

                //  Console.WriteLine(m.Key + " : " + m.Value);
                Console.WriteLine("There are " + m.Value.Count + " persons in city " + m.Key);
            }
        }
       
    }

}

