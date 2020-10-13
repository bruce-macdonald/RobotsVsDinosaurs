using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        //member variables (HAS A)

        public List<Dinosaur> dinosaurs = new List<Dinosaur>();
        Dinosaur dinosaur1;
        Dinosaur dinosaur2;
        Dinosaur dinosaur3;

        //constructor(spawner, what do they start with)
        public Herd()
        {
            dinosaur1 = new Dinosaur("dinosaur1");
            dinosaur2 = new Dinosaur("dinosaur2");
            dinosaur3 = new Dinosaur("dinosaur3");
            dinosaurs.Add(dinosaur1);
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);
        }
        //member methods(action phrases)
        public void CheckVitality(Dinosaur dinosaur)
        {
            if(dinosaur.health <= 0)
            {
                RemoveDinoFromList(dinosaur);
            }
        }
        public void RemoveDinoFromList(Dinosaur dinosaur)
        {
            dinosaurs.Remove(dinosaur);
        }
       
    }
}
