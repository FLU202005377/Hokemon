using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Hokemon
    {
        // Members - All Attributes, Methods and Properties are MEMEBERS of this CLASS

        // VARIABLES a.k.a ATTRIBUTES inside a class can also be refered to as FIELDS

        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;
        private string team = "Hokemon";

        // PROPERTIES
        // PROPERTIES are a combination of a field and method - this keeps variable / attributes PRIVATE
        // and allows us to perform checks on what is input

        public string Name          // Notice PROPERTY has no parenthesis its identifier unlike the METHODS below
        {
            get { return name; }    // access to the name attribute
            set { name = value;     // sets the name attribute
            }
         }
        
        public string Team
        {
            get { return name; }
            set { name = value; 
            }

        }

        public int Health
        {
            get { return health; }
            set { health = value; 
            }

        }

        // METHODS
        public Hokemon() // CONSTRUCTOR method runs 1st when INSTANTIATE
        {

            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);

        }
        public void provide_name()
        {
            Console.WriteLine("Enter a name for your Hokemon: ");
            name = Console.ReadLine();

        }
        
        public void get_details() //METHOD
        {
            Console.WriteLine("\n\n********\nName: {0}\nHealth: {1}/{2}\nAttack Value: {3}\nSpeed Value: {4}\nDefense Value: {5}", name, Health, max_health, attack, speed, defense);

        }

        public int random_int_generator(int min_value, int max_value) // int min_value, int max_value are PARAMETERS
        {
            Random rnd = new Random(); // Creating a new OBJECT called rnd this is an 
                                                    // INSTANCE of RANDOM class

            int randomValue;

            randomValue = rnd.Next(min_value, max_value); //usine the NEXT method from the RANDOM class found in rnd OBJECT

            return randomValue;
        }

        public void about()
        {
            Console.WriteLine("I am a mystical species know as Hokemon! ");
        }
        public int attackCalculator()
        {
            int attackValue = (attack + speed) * random_int_generator(0, 2);

            return attackValue;
        }
        
        public int defenceCalculator()
        {
            int defenceValue;

            // Adding a calculation
            defenceValue = (defense + speed) * random_int_generator(0, 2);

            return defenceValue;
        }


    }



}
