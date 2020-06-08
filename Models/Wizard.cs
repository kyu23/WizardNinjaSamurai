using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai.Models
{
    public class Wizard : Human
    {
    public Wizard(string name) : base(name)
    {
        Intelligence = 25;
        Health = 50;
        //System.Console.WriteLine($"Stats: {Name} Strength: {Strength} Intelligene: {Intelligence} Dexterity: { ////Dexterity} Health: {health}");
    }
    public override string ToString()
            {
                return
                    $"Name: {Name}, Health: {Health}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}";
            }
    public int CastSpell(Human target)
    {
        int dmg = Intelligence * 5;
        
        target.Health -= dmg;
        Health += dmg;

        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        System.Console.WriteLine($"Stats: {Name} Strength: {Strength} Intelligene: {Intelligence} Dexterity: { Dexterity} Health: {Health}");
        System.Console.WriteLine($"Stats: {target.Name} Strength: {target.Strength} Intelligene: {target.Intelligence} Dexterity: { target.Dexterity} Health: {target.Health}");


        return target.Health;
    }

    public int Heal(Human target)
    {
        int HealedPoints = Intelligence * 10;
        System.Console.WriteLine($"{target.Name} was healed for {HealedPoints} points");
        target.Health += HealedPoints;
        return target.Health;
    }

    }
}