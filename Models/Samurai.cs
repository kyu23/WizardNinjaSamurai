using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai.Models
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {

        }

        public override string ToString()
        {
            return
                $"Name: {Name}, Health: {Health}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}";
        }

        public override int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            System.Console.WriteLine($"{ target.Name }'s health is now { target.Health }");
            if(target.Health < 50)
            {
                System.Console.WriteLine($"{ target.Name }'s health is below 50hp, Fatal blow occurred!");
                target.Health = 0;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            System.Console.WriteLine($"{ target.Name }'s health is now { target.Health }");
            }
            return target.Health;
        }

        public int Meditate() //how do you call Meditate without a Human target? Is that possible to just reference itself?
        {
            System.Console.WriteLine($"{Name} used Meditate and is healed to full hp!");
            int HealedPoints = 100;
            Health = HealedPoints;
            return Health;
        }
    }
}