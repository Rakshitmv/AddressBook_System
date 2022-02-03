using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Welcome to Address Book Program--------\n");

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Value:" + "\n" + "1.Add to Contacts"+ "\n" + "2.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddressBookMain addressBook = new AddressBookMain();
                        addressBook.CreateContact();
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter correct option");
                        break;


                }
            }
        }
    }
}
