namespace Statement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int temp = Convert.ToInt32(Console.ReadLine());
            // Conditional Statements
            if (temp < 10)
            {
                Console.WriteLine("Take the Coat");
            }
            else if (temp == 10)
            {
                Console.WriteLine("it's 10 degree");
            }
            else
            {
                Console.WriteLine("It's cozy and cold");
            }


        }
    }
}