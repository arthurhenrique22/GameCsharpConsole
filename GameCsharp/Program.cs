using System;
using GameCsharp.src.Entities;

namespace GameCsharp
{
    class Program
    {
        static void Main(string[]args)
        {
            Knight arus= new Knight("Arus", "LvL", 50, "Classe Knight: HP/", 11000, "Strong/", 500); 
            Console.WriteLine(arus);
            Console.WriteLine(arus.Attack());
            
            Wizard wizard = new Wizard("Jennica","Lvl", 50, "Classe White Wizard: HP/", 5000, "Strong/",960 );
            Console.WriteLine(wizard);
            Console.WriteLine(wizard.Attack(401));
            Console.WriteLine(wizard.Attack(758));

            Dragon dragon = new Dragon ("Dragon", "Lvl", 89, "Classe Strong Max: HP/", 24000, "Strong/", 2000);
            Console.WriteLine(dragon);
            Console.WriteLine(dragon.Attack(1007));
            Console.WriteLine(dragon.Attack(1834));
        }  
    }
}