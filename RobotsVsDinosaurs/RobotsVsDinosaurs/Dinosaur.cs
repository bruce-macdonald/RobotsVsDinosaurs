using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {   //member variables (HAS A)
        public string[] attacks;
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        Random r = new Random();

        //constructor(spawner, what do they start with)

        public Dinosaur(string type)
        {
            health = r.Next(125, 175);
            energy = 100;
            attackPower = r.Next(80, 100);
            this.type = type;
            attacks = new string[] { "Maul", "Swipe", "Mangle", "Bash" };
        }

        //member methods(action phrases)

        public void Attack(Robot robot)
        {
            robot.health -= attackPower;
            //array of attacks
            energy -= 10;
        }

        public void ChooseAttackType()
        {
            Console.WriteLine("Press 1 for: " + attacks[0]);
            Console.WriteLine("Press 2 for: " + attacks[1]);
            Console.WriteLine("Press 3 for: " + attacks[2]);
            Console.WriteLine("Press 4 for: " + attacks[3]);
            string chosenAttackType = Console.ReadLine();
            //switch case for attack choice and randomize attack power etc

            switch (chosenAttackType)
            {
                case "1":
                    chosenAttackType = attacks[0];
                    Console.WriteLine("You've chosen" + attacks[0] + "!");
                    break;
                case "2":
                    chosenAttackType = attacks[1];
                    Console.WriteLine("You've chosen" + attacks[1] + "!");
                    break;
                case "3":
                    chosenAttackType = attacks[2];
                    Console.WriteLine("You've chosen" + attacks[2] + "!");
                    break;
                case "4":
                    chosenAttackType = attacks[3];
                    Console.WriteLine("You've chosen" + attacks[3] + "!");
                    break;
                default:
                    Console.WriteLine("Please put in a number between 1 and 4 to choose your dino attack.");
                    break;
            }
        }
    } }
