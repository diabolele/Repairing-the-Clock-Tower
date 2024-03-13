using System.ComponentModel.Design;

namespace Repairing_the_Clock_Tower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) 
            Console.WriteLine("Tick");
           else

                Console.WriteLine("Tock");


        }
    }
}
