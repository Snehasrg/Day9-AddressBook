namespace AddressBook
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //Console.WriteLine(" Welcome to Address Book Program");
            // Contact obj = new Contact("Ram","Sharma","JubliHills,pune","Pune","Maharashtra","90200","92xxxxxxxx","ramsharma@gmail.com" );
            // obj.Add();
            //AddContact obj = new AddContact();
            // obj.Add();

            Console.WriteLine("Welcome to Address Book");

            int choice = 0;
            while (choice != 2)
            {
                Console.WriteLine("1.Perform Operations \n2.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice != 2)
                    AddMultiplePerson.AddPerson();
            }
            AddMultiplePerson.ListPeople();
            Console.WriteLine("Program Ends: Address Book: Press Enter");
            Console.ReadLine();

        }
    }
}
