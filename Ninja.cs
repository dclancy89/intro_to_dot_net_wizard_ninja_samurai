using System;

namespace Wizard__Ninja__Samurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100)
        {

        }

        public void steal(object obj)
        {
            this.attack(obj);
            this.health += 10;
            Console.WriteLine("{0} heals 10 points. {0} now has {1} health.", this.name, this.health);
        }

        public void get_away(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Get away failed.");
            }
            else
            {
                this.health -= 10;
                Console.WriteLine("{0} got away from {1} and lost 10 health. {0} now has {2} health.", this.name, enemy.name, this.health);
            }

        }

    }
}