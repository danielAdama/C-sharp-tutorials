namespace SimpleLoginSys
{
    class Program
    {
        public static void Main(string[] args)
        {
            // A Login system that signifies, if a user is registered and have a userName print their username,
            // and if that userName is admin, print admin
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your Username: ");
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi there, registered User");

                if (userName != "")
                {
                    Console.WriteLine($"Hey {userName}");

                    if (userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hello Admin!");
                    }
                }

            }

        }
    }
}