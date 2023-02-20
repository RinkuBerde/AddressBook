using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class MultipleAddressBook
    {
        static Dictionary<string, List<Contacts>> dtAddressbook;
        public MultipleAddressBook()
        {
            dtAddressbook = new Dictionary<string, List<Contacts>>();
        }     
        // ability to return addressBook Dictionary      
        public Dictionary<string, List<Contacts>> GetAddressBook()
        {
            return dtAddressbook;
        }
        // create a new address book check for name,
        // if already exists then, wont create new.
        public bool AddAddressBook(string name)
        {
            //check for addressbook name
            if (dtAddressbook.ContainsKey(name))
            {
                Console.WriteLine("Name already exists!! \n Choose other Name and try Creating new AddressBook.");
                return false;
            }
            else
            {
                List<Contacts> contactsList = new List<Contacts>();
                Console.WriteLine("address book created successfully....");
                Console.WriteLine("Add new Contacts? \n Press Y/N :");
                char ch = Convert.ToChar(Console.ReadLine());
                ch = Char.ToUpper(ch);
                switch (ch)
                {
                    case 'Y':

                        ContactView contact = new ContactView();
                        Contacts newContact = contact.NewContact(contactsList);
                        if (newContact != null)
                        {
                            contactsList.Add(newContact);
                            dtAddressbook.Add(name, contactsList);
                        }
                        else
                            Console.WriteLine("Contact Add failed");
                        break;
                    case 'N':
                        dtAddressbook.Add(name, contactsList);
                        break;
                }
                return true;
            }
        }
        // view all addressbooks present.
        public string ViewAddressBooks()
        {
            if (dtAddressbook.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (dtAddressbook.Count >= 1)
            {
                Console.WriteLine("Select AddressBook(s):");
                foreach (var item in dtAddressbook.Keys)
                {
                    Console.WriteLine($"Enter name to Select AddressBook : {item}");
                }
                string addressBookName = Console.ReadLine();
                if (dtAddressbook.ContainsKey(addressBookName))
                    return addressBookName;
                else
                {
                    Console.WriteLine("Invalid Selection made!! \n Try again.");
                    ViewAddressBooks();
                }
            }
            return null;
        }
    }
}
