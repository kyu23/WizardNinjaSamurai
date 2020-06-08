using System;
using System.Collections.Generic;
using WizardNinjaSamurai.Models;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Human("Kevin");
            System.Console.WriteLine(player1);

            //var player2 = new Wizard("Gandalf");
            //System.Console.WriteLine(player2);

            var player3 = new Ninja("Ninja");
            System.Console.WriteLine(player3);

            //var player4 = new Samurai("Samurai");
            //System.Console.WriteLine(player4);
            

            //player1.Attack(player2);
            //System.Console.WriteLine(player1);
            //System.Console.WriteLine(player2);

            //player2.CastSpell(player1);
            //player2.Heal(player2);
            //System.Console.WriteLine(player1);
            //System.Console.WriteLine(player2);

            //player3.Attack(player1);
            player3.Steal(player1);
            System.Console.WriteLine(player3);
            System.Console.WriteLine(player1);

            //player1.Attack(player4);
            //player4.Meditate();
            //System.Console.WriteLine(player4);
            //System.Console.WriteLine(player1);
        }
    }
}
