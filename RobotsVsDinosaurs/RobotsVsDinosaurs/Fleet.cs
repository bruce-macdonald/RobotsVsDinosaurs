using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {    //member variables (HAS A)

        public List<Robot> robots = new List<Robot>();
        

        //constructor(spawner, what do they start with)
        public Fleet()
        {
            Robot robot1 = new Robot("Robot1");
            Robot robot2 = new Robot("Robot2");
            Robot robot3 = new Robot("Robot3");
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
        }
    }   
}
