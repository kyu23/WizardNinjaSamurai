using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai.Models
{
    public class Human
    {
        public string Name;
        public int Strength { get; set; } = 3;
        public int Intelligence { get; set; } = 3;
        public int Dexterity { get; set; } = 3;
        public int Health { get; set; } = 100;

        public Human(string name, int str = 3, int intel = 3, int dex = 3, int hp = 100)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Health = hp;
            
        }

        public override string ToString()
            {
                return
                    $"Name: {Name}, Health: {Health}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}";
            }
        
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            System.Console.WriteLine($"{ target.Name }'s health is now { target.Health }");
            return target.Health;
        }
    }
}
