using System;

namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Lion lion = new Lion("Section A", "Zoo");
            Wolf wolf = new Wolf("near forest", "Forest");

            lion.MakeNoize();
            wolf.MakeNoize();

            lion.Roam("Feeder");
            wolf.Roam("Cave");
            Console.ReadKey();
        }
    }
}
