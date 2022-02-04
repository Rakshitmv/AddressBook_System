using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contacts> addressBook = new List<Contacts>();
        public void AddContact()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter First Name\n");
            contacts.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name\n");
            contacts.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address\n");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter city\n");
            contacts.City = Console.ReadLine();
            Console.WriteLine("Enter State\n");
            contacts.State = Console.ReadLine();
            Console.WriteLine("Enter Zip\n");
            contacts.Zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number\n");
            contacts.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            contacts.Email = Console.ReadLine();
            Console.WriteLine("Created Contacts:\n " + contacts.FirstName + "\n" + contacts.LastName + "\n" + contacts.Address + "\n" + contacts.City + "\n" + contacts.State + "\n" + contacts.Zip + "\n" + contacts.PhoneNumber + "\n" + contacts.Email + "\n");

            addressBook.Add(contacts);
            Console.WriteLine("{0}Contact has successfully added", contacts.FirstName);
        }
        public void EditContact(string firstName)
        {
            Contacts contact = new Contacts();

            foreach (var data in addressBook)
            {
                if (data.FirstName == firstName)
                {
                    contact = data;
                    Console.WriteLine("\n 1. First name\n 2. Last name\n 3. Address\n 4. City\n 5. State\n 6. Zipcode\n 7. Phone number\n 8. Email ID\n 9. Exit");
                    bool flag = true;
                    while (flag)
                    {

                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter the First name");
                                contact.FirstName = Convert.ToString(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("Enter the Last name");
                                contact.LastName = Convert.ToString(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Enter the Address");
                                contact.Address = Convert.ToString(Console.ReadLine());
                                break;
                            case 4:
                                Console.WriteLine("Enter the City");
                                contact.City = Convert.ToString(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Enter the State");
                                contact.State = Convert.ToString(Console.ReadLine());
                                break;
                            case 6:
                                Console.WriteLine("Enter the Zip Code");
                                contact.Zip = Convert.ToString(Console.ReadLine());
                                break;
                            case 7:
                                Console.WriteLine("Enter the Phone Number");
                                contact.PhoneNunmber = Convert.ToString(Console.ReadLine());
                                break;
                            case 8:
                                Console.WriteLine("Enter the Email");
                                contact.Email = Convert.ToString(Console.ReadLine());
                                break;
                            case 9:
                                flag = false;
                                break;
                            default:
                                Console.WriteLine("Enter Correct option!!!");
                                break;
                        }
                        Display();
                        return;
                    }

                }
            }
        }


        public void Display()
        {
            foreach (var data in addressBook)
            {
                Console.WriteLine("Created Contacts:\n " + data.FirstName + "\n" + data.LastName + "\n" + data.Address + "\n" + data.City + "\n" + data.State + "\n" + data.Zip + "\n" + data.PhoneNumber + "\n" + data.Email + "\n");
            }
        }
    }
}

       
