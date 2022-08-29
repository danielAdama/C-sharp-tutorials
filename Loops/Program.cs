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
            for(int counter=1; counter < 20; counter += 2)
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine();
            // Do while Loop - While counter is less than 5 do the following
            int counter_new = 0;
            do
            {
                Console.WriteLine(counter_new);
                counter_new ++;
            } while (counter_new < 5);
        }
    }
}