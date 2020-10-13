using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {

        //member variables (HAS A)
        public string weaponType;
        public int attackPower;


        //constructor(spawner, what do they start with)
        public Weapon()
        {
            //switch case 1 for sword, 2 for rifle
            Console.WriteLine("Please select weapon type.");
            Console.WriteLine("Press 1 for Sword, or 2 for Rifle.");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Sword equipped!");
                    weaponType = "Sword";
                    attackPower = 100;
                    break;
                case "2":
                    Console.WriteLine("Locked and Loaded!");
                    weaponType = "Rifle";
                    attackPower = 80;
                    break;
                default:
                    Console.WriteLine("Please select weapon type.");
                    Console.WriteLine("Press 1 for Sword, or 2 for rifle.");
                    break;
            }


        //member methods(action phrases)
    }
        }
}
