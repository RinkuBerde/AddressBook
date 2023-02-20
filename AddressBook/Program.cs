namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Contacts contacts = new Contacts
            {
                FirstName = "Rinku",
                LastName = "Berde",
                Address = "SR nagar",
                City = "Mysore",
                State = "Karnataka",
                ZipCode = 583201,
                PhoneNumber = 1234567890,
                Email = "rinkuberde@gmail.com"
            };
            contacts.ValidateContactDetails();
            Console.WriteLine("Contact Details: ");
            Console.WriteLine($"Full Name: {contacts.FirstName + contacts.LastName} ");
            Console.WriteLine($"Phone Number: {contacts.PhoneNumber} ");
            Console.WriteLine($"Address: {contacts.Address} ");
            Console.WriteLine($"Address:{contacts.City} ");
            Console.WriteLine($"Address:{contacts.State} ");
            Console.WriteLine($"Address:{contacts.ZipCode} ");
            Console.WriteLine($"Email: {contacts.Email} ");
            Console.ReadLine();
        }
      
    }
    
}