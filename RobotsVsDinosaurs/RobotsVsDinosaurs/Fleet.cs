using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {    //member variables (HAS A)

        public List<Robot> robots; 
        public List<Weapon> weapons;
        Random r = new Random();


        //constructor(spawner, what do they start with)
        public Fleet()
        {
            robots = new List<Robot>();
            weapons = new List<Weapon>();
            Weapon weapon1 = ChooseWeaponType();
            Weapon weapon2 = ChooseWeaponType();
            
            
            weapons.Add(weapon1);
            weapons.Add(weapon2);
          
            
            Robot robot1 = new Robot("Robot1");
            Robot robot2 = new Robot("Robot2");
            Robot robot3 = new Robot("Robot3");

            robot1.weapon = weapons[0];
            robot2.weapon = weapons[0];
            robot3.weapon = weapons[0];
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
            
        }
        //member methods(action phrases)
        public void CheckVitality(Robot robot)
        {
            if (robot.health <= 0)
            {
                RemoveRoboFromList(robot);
            }
        }
        public void RemoveRoboFromList(Robot robot)
        {
            robots.Remove(robot);
            Console.WriteLine("You've lost a robot! You now have " + robots.Count + " remaining.");
            Console.WriteLine();
        }



        public Weapon ChooseWeaponType()
        {
            Console.WriteLine("Press 1 for: sword");
            Console.WriteLine("Press 2 for: rifle");
           
            Weapon chosenWeaponType;
            chosenWeaponType = null;
            string weaponChoice = Console.ReadLine();
            switch (weaponChoice)
            {
                case "1":
                    chosenWeaponType = new Weapon();
                    Console.WriteLine("You've chosen sword!");
                    chosenWeaponType.weaponType = "Sword";
                    chosenWeaponType.attackPower = r.Next(80, 100);
                    break;
                case "2":
                    chosenWeaponType = new Weapon();
                    Console.WriteLine("You've chosen rifle!");
                    chosenWeaponType.attackPower = r.Next(80, 100);
                    break;
                default:
                    Console.WriteLine("Please put in a number between 1 and 4 to choose your dino attack.");
                    break;                   
            }
            return chosenWeaponType;
        }
    }   

}
