using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        //this is where the fighting happens(where the run game method will be called)


        //member variables (HAS A)
        Herd herd;
        Fleet fleet;
        
        //constructor(spawner, what do they start with)
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }
        //member methods(action phrases)

        public void Battle()
        {

            while (herd.dinosaurs.Count > 0 && fleet.robots.Count > 0)
            {
                herd.dinosaurs[0].ChooseAttackType();
                herd.dinosaurs[0].Attack(fleet.robots[0]);
                fleet.CheckVitality(fleet.robots[0]);

                if (fleet.robots.Count == 0)
                {
                    Console.Write("DINOS WIN!");
                    break;
                }
                //fleet.robots[0].weapon.attackPower; 
                //example of dot notation for "peeling layers"

                
                fleet.robots[0].Attack(herd.dinosaurs[0]);
                herd.CheckVitality(herd.dinosaurs[0]);

                if (herd.dinosaurs.Count == 0)
                {
                    Console.Write("ROBOTS WIN!");
                    break;
                }

                
            }

            Console.WriteLine("Game over");
            Console.ReadLine();
           

        }
    }
}
