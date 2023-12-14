using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    struct Contact
    {
        public string firstName;
        public string lastName;
        public string email;
        public string phone;
    }

    struct ContactBook
    {
        private List<Contact> contacts;

        public void addContact(Contact contact)
        {
            Console.WriteLine("Wprowadź imię: ");
            Console.WriteLine("Wprowadź nazwisko: ");
            Console.WriteLine("Wprowadź email: ");
            Console.WriteLine("Wprowadź numer telefonu: ");

            contacts.Add(contact);
        }

        public void displayContacts()
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine("------- KONTAKT -------");
                Console.WriteLine($"Imię: {contact.firstName}");
                Console.WriteLine($"Nazwisko: {contact.lastName}");
                Console.WriteLine($"E-Mail: {contact.email}");
                Console.WriteLine($"Numer telefonu: {contact.phone}\n\n");

            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
