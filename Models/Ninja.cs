using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
            
        }

        /* public override string ToString()
        {
            return
                $"Name: {Name}, Health: {Health}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}";
        } */

        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Random rand = new Random();
            int roll = rand.Next(1, 21);
            int damage = 10;
            if(roll <= 5)
            {
                System.Console.WriteLine($"Roll was { roll }, { target } was damaged for {damage}!");
                damage -= target.Health;
                
            }
            else
            {
                System.Console.WriteLine($"Roll was { roll }, no extra damage!");
            }      
            return target.Health;
        }
        
        public int Steal(Human Target) //how do you add hp to the Ninja itself?
        {
            int StolenPoints = 5;
            Target.Health -= StolenPoints;
            Health += StolenPoints;
            System.Console.WriteLine($"{Name} stole {StolenPoints} from {Target.Name} and now has {Health} points!");
            return Target.Health;
        }
    }
}