using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hokeworld! ");

            Hokemon[] ChallengerArray = new Hokemon[3];
            Battle_Arena firstArena = new Battle_Arena(); //INSTANTIATED Battle_Arena

            Random rnd = new Random();

            bool repeatGame;
            string result;

            Hokemon hokeObject01 = new Hokemon();
            hokeObject01.get_details();

            Console.WriteLine("\n*********\n");


            Halor haloHokemon01 = new Halor();
            haloHokemon01.get_details();
            haloHokemon01.about();

            Console.WriteLine("\n*********\n");

            Hystic hystHokemon01 = new Hystic();
            hystHokemon01.get_details();
            hystHokemon01.about();

            Console.WriteLine("\n*********\n");
            
            // NPC Hokemon 

            for (int i = 0; i < ChallengerArray.Length; i++)
            {
                ChallengerArray[i] = new Hokemon(); // INSTATANTIATING Challenger Hokemon
            }


            Battle_Arena firstArena = new Battle_Arena();


            firstArena.Battle(hokeObject01, ChallengerArray[rnd.Next(0,ChallengerArray.Length)]);


            firstArena.ChallengeAccepted(hokeObject01, hystHokemon01); // Passing two objects into 
                                                                      // the firstArena

            

            






        }
    }
}
