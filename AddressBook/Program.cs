namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine();
            ContactView contactView = new ContactView();
            //hard coded contacts initializing.
            contactView.ContactViewMethod();
            //display selection for User.
            Display display = new Display();
            display.DisplayChoice();
            display.Selection();
            contactView.DeleteContact();
        }
    }    
}