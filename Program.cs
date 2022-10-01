using System;

namespace Borat
{
    class Program
    {
        static void Main(string[] args)
        {
            do {
                double číslo1 = 1;
                double číslo2 = 1;
                double výsledek = 1;

                Console.WriteLine("-famfára-");
                Console.WriteLine("Vítám tě, jmenuji se Kalkulačka.");
                Console.WriteLine("umím násobit, dělit, sčítat, odčítat a taky mocnit,");
                Console.WriteLine("pokud budeš operovat s nulou, hodím ti ?, místo erroru.");

                Console.WriteLine("Zadej mi sem první číslo pro zahájení procesu: ");
                číslo1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Budu potřebovat i druhý numero pro pokračování: ");
                číslo2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Vyber si operaci");
                Console.WriteLine("zde je 5 maximálních oprací v systému ");
                Console.WriteLine("/ : dělit");
                Console.WriteLine("první číslo dělí druhým");
                Console.WriteLine("+ : sčítání");
                Console.WriteLine("sčítá čísla mezi sebou");
                Console.WriteLine("* : násobení");
                Console.WriteLine("vynásobí čísla mezi sebou");
                Console.WriteLine("- : odčítání");
                Console.WriteLine("odečte čísla mezi sebou");
                Console.WriteLine(", : nadruhou(druhé zadané číslo nemá vliv na výsledek)");
                Console.WriteLine("vynásobí číslo sebou samím");

                switch (Console.ReadLine())
                {
                    case "/":
                        výsledek = číslo1 / číslo2;
                        Console.WriteLine("Tvůj výsledek : {číslo1} / {číslo2} =  " + výsledek);
                        break;
                        Console.WriteLine("dělení spočívá v dělení 1¨. čísla mezi 2. zadané");
                    case "*":
                        výsledek = číslo1 * číslo2;
                        Console.WriteLine("Tvůj výsledek : {číslo1} * {číslo2} =  " + výsledek);
                        break;
                        Console.WriteLine("násobení spočívá v navyšování počtů 1. čísla mezi 2. číslo");
                    case "-":
                        výsledek = číslo1 - číslo2;
                        Console.WriteLine("Tvůj výsledek : {číslo1} - {číslo2} =  " + výsledek);
                        break;
                        Console.WriteLine("odčítání spočívá ve ztrátě 2.čísla v 1.čísle");
                    case "+":
                        výsledek = číslo1 + číslo2;
                        Console.WriteLine("Tvůj výsledek : {číslo1} + {číslo2} =  " + výsledek);
                        break;
                        Console.WriteLine("sčítání spočívá v spojení dvou číslic, nehledě na pořadí");
                    case ",":
                        výsledek = číslo1 * číslo1;
                        Console.WriteLine("Tvůj výsledek : {číslo1} * {číslo1} =  " + výsledek);
                        break;
                        Console.WriteLine("nadruhou spočívá v násobení 1.čísla taktéž 1.číslem");

                }
                Console.WriteLine("vše sedí? (j= jo , a= ano):");
            } while(Console.ReadLine().ToUpper()=="j"); 

            Console.WriteLine("děkuji za použití,měj se");
            Console.WriteLine("kalkulačka by Slíž Jakub, bez hodnocení na metacritics");
            
            Console.ReadKey();

        }
    }
}

