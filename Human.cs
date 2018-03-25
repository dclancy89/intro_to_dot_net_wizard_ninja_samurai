using System;

namespace Wizard__Ninja__Samurai
{
    public class Human
{
    public string name;

    //The { get; set; } format creates accessor methods for the field specified
    //This is done to allow flexibility
    public int health { get; set; }
    public int strength { get; set; }
    public int intelligence { get; set; }
    public int dexterity { get; set; }

    public Human(string person)
    {
        name = person;
        strength = 3;
        intelligence = 3;
        dexterity = 3;
        health = 100;
    }
    public Human(string person, int str, int intel, int dex, int hp)
    {
        name = person;
        strength = str;
        intelligence = intel;
        dexterity = dex;
        health = hp;
    }
    public void attack(object obj)
    {
        Human enemy = obj as Human;
        if(enemy == null)
        {
            Console.WriteLine("Failed Attack");
        }
        else
        {
            int damage = this.strength * 5;
            enemy.health -= damage;
            Console.WriteLine("{0} attacks {1} for {2} damage.", this.name, enemy.name, damage);
        }
    }
}
}
