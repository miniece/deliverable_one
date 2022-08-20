using System;

namespace HowManyPBJs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine("How many people are we making PB&J sandwiches for?");
                int sandwiches = int.Parse(Console.ReadLine());

                //calculations//
                int slicesPerLoaf = 28;
                int tablespoonPerPB = 32;
                int teaspoonPerJelly = 48;

                double totalSlicesNeeded = sandwiches * 2;
                double totalTablespoons = sandwiches * 2;
                double totalTeaspoons = sandwiches * 4;
                double totalLoavesNeeded = Math.Ceiling(totalSlicesNeeded / slicesPerLoaf);
                double totalPeanutButter = Math.Ceiling(totalTablespoons / tablespoonPerPB);
                double totalJelly = Math.Ceiling(totalTeaspoons / teaspoonPerJelly);

                Console.WriteLine("You need:");
                Console.WriteLine("");

                Console.WriteLine(totalSlicesNeeded + " slices of bread");
                Console.WriteLine(totalTablespoons + " tablespoons of peanut butter");
                Console.WriteLine(totalTeaspoons + " teaspoons of jelly");

                Console.WriteLine("");
                Console.WriteLine("which is...");
                Console.WriteLine("");

                Console.WriteLine(totalLoavesNeeded + " loaves of bread");
                Console.WriteLine(Math.Ceiling(totalPeanutButter) + " jars of peanut butter");
                Console.WriteLine(Math.Ceiling(totalJelly) + " teaspoons of jelly");

                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                string start = Console.ReadLine();

                if (start == "yes" || start == "y")
                {
                    valid = false;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    valid = true;
                }
            }
            

        }
    } 
}