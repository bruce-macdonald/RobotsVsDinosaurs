using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {   //member variables (HAS A)

        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //constructor(spawner, what do they start with)

        public Dinosaur(string type)
        {
            health = 100;
            energy = 100;
            attackPower = 100;
            this.type = type;
        }

        //member methods(action phrases)

        public void Attack(Robot robot)
        {
            robot.health -= attackPower;
            //array of attacks
            energy -= 10;
        }
    }
}
