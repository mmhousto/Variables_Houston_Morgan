using System;

namespace Variables_Houston_Morgan
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!"); // Prints "Hello World!" to the console

            /*
             * Creates string variable set to Morgan.
             * Prints a welcome message for Morgan.
             * */
            string myName = "Morgan";
            Console.WriteLine("Hello, " + myName + "!");

            Console.WriteLine("What is your favorite sport?");
            string myFavSport = Console.ReadLine();

            Console.WriteLine($"{myName}\'s favorite sport is {myFavSport}!");

            Console.WriteLine("Changed");

        }
    }
}
