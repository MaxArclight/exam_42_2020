using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Wolf : Animal
    {
        public Wolf(string location, string boundaries)
        {
            Location = location;
            Boundaries = boundaries;
        }

        public override void Eat()
        {
            Console.WriteLine("Nom nom");
        }

        public override void MakeNoize()
        {
            Console.WriteLine("Woooof");
        }
    }
}
