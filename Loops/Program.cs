namespace Loops
{
    class Program
    {
        public static void Main(string[] args)
        {
            // // for(start, stop, increment/decrement)
            // for(int counter=0; counter < 10; counter++)
            // {
            //     Console.WriteLine(counter);
            // }
            // for(int counter=1; counter < 20; counter += 2)
            // {
            //     Console.WriteLine(counter);
            // }
            // Console.WriteLine();
            // // Do while Loop - While counter is less than 5 do the following
            // int counter_new = 0; int lenghtOfText = 0; string wholeText = "";
            // do
            // {
            //     Console.WriteLine("Please enter the name of a friend");
            //     string nameOfFriend = Console.ReadLine();
            //     int currentLength = nameOfFriend.Length;
            //     lenghtOfText += currentLength;
            //     wholeText += nameOfFriend;
            // } while (lenghtOfText < 20);
            // Console.WriteLine("Thanks, that's enough!"+wholeText);

            // While Loop
            // int counter = 0;
            // while (counter < 10)
            // {
            //     Console.WriteLine(counter);
            //     counter++;
            // }

            // Break and Continue
            for (int counter = 0; counter < 10; counter++)
            {
                
                if (counter == 3)
                {
                    Console.WriteLine("We skip number 3");
                    continue;
                }
                Console.WriteLine(counter);
            }
            Console.WriteLine("Thank you!");
        }
    }
}