using System;

namespace Wizard__Ninja__Samurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name, 3, 3, 3, 200)
        {

        }

        public void death_blow(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Deathblow Failed.");
            }
            else
            {
                if(enemy.health < 50)
                {
                    enemy.health = 0;
                    Console.WriteLine("{0} dealt a deathblow to {1}.", this.name, enemy.name);
                }
                else
                {
                    Console.WriteLine("Cannot deal deathblow. {0} is too strong.", enemy.name);
                }
            }

        }

        public void meditate()
        {
            this.health = 200;
            Console.WriteLine("{0} meditates and returns to full health.", this.name);
        }
    }
}