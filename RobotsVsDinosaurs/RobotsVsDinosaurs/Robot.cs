using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        //member variables (HAS A)

        public string name;
        public int powerLevel;
        public Weapon weapon;
        public int health;
        Random r = new Random();       
        

        //constructor(spawner, what do they start with, pass in variables needed)
        public Robot(string name)
        {
            this.name = name;
            this.powerLevel = r.Next(80, 100);
            this.health = r.Next(85, 125);
            this.weapon = new Weapon();

        }

        //member methods(action phrases)
        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= weapon.attackPower;
            powerLevel -= 10;
        }

        

    }
}
