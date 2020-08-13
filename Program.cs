using System;

namespace DifferentKettleOfFish08132020
{
    class Program
    {
        static void Main(string[] args)
        {
            int fish = 1;

            while (fish < 11)
            {
                if (fish == 3)
                {
                    Console.WriteLine("RED fish!");
                }
                else if (fish == 4)
                {
                    Console.WriteLine("Blue fish!");
                }
                else
                {
                    Console.WriteLine(fish + " fish!");
                }

                fish++;
            }
        }
    }
}