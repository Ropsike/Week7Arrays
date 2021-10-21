using System;

namespace FunctionsWithReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = { "Kananagitsad", "burger", "friikartulid", "salat" };
            string[] drinks = { "cocacola", "fanta", "sprite", "tavaline vesi" };
            string[] movie = { "The birds", "Friday 13", "John Wick", "Shrek", "Pirates Of The Carribean"};

            //DisplayRandomFromArray(food);
            //DisplayRandomFromArray(drinks)
            string randomSnack = PickRandomFromArray(food);
            string randomDrink = PickRandomFromArray(drinks);
            string randomMovie = PickRandomFromArray(movie);

            Console.WriteLine($"Computer picked {randomSnack} and {randomDrink}. for a {randomMovie} night.");
        }
        private static string PickRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomElement = someArray[randomIndex];

            return randomElement;
        }
        
        
        private static void DisplayRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            Console.WriteLine($"computer has chosen {someArray[randomIndex]}");
        }



    }
}
