using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public abstract class Animal
    {
        public Animal()
        {
        }

        public string Location { get; set; }

        public string Boundaries { get; set; }

        public void Sleep()
        {
            Console.Write("sample sleep");
        }

        public void Roam(string location)
        {
            this.Location = location;
            Console.Write("{0} roaming to {1}\n", this, location);
        }

        public abstract void MakeNoize();

        public abstract void Eat();
    }
}
