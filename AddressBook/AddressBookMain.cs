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
        public void CreateContact()
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


        }
    }
}
