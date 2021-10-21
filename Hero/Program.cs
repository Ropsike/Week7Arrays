using System;

namespace Hero
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            hero = RandomHero();
            Console.WriteLine($"Random hero: {hero}");
        }

        private static string RandomHero()
        {
            string[] heroes = { "Batman", "Spongebob", "Spiderman", "Patric", "Lara Croft" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, heroes.Length);

            string randomHero = heroes[randomIndex];
            return randomHero;
        }

        private static string RandomVillain()

    }
}
