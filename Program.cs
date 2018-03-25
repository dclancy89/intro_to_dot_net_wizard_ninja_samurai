using System;

namespace Wizard__Ninja__Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human hector = new Human("Hector");
            Wizard lennon = new Wizard("Lennon");
            Ninja daniel = new Ninja("Daniel");
            Samurai hayden = new Samurai("Hayden");

            lennon.heal();
            lennon.fireball(hector);

            daniel.steal(hayden);
            daniel.get_away(lennon);

            hayden.death_blow(lennon);
            hayden.meditate();

            int how_many_samurai = Samurai.count;
            Console.WriteLine("There are {0} Samurai in the world.", how_many_samurai);
        }
    }
}
