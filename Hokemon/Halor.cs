using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Halor : Hokemon // INHERITING from parent Hokemon class
    {
        
        public Halor()
        {
            Team = "Halor";

        }

        public void about() // POLYMORPHISM from the Hokemon about method
        {
            Console.WriteLine("I am {0} part of a team {1}!!", Name, Team);

        }
    }
}
