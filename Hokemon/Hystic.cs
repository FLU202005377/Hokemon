using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Hystic : Hokemon
    {
        public Hystic()
        {
            Team = "Hystic";

        }

        public void about()
        {
            Console.WriteLine("I am {0} part of a team {1}!!", Name, Team);
        }
        

    }
}
