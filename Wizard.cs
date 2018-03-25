using System;



namespace Wizard__Ninja__Samurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name, 3, 25, 3, 50)
        {

        }

        public void heal()
        {
            int healing = 10 * this.intelligence;
            this.health += healing;
            Console.WriteLine("{0} healed for {1} points. {0} now has {2} health.", this.name, healing, this.health);
        }

        public void fireball(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Fireball missed.");
            }
            else
            {
                Random rand = new Random();
                int damage = rand.Next(20,51);
                enemy.health -= damage;
                if(enemy.health < 0)
                {
                    enemy.health = 0;
                }
                Console.WriteLine("{0} uses fireball against {1}. It does {2} damage. {1} now has {3} health.", this.name, enemy.name, damage, enemy.health);
            }
        }
    }
}