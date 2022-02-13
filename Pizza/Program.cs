using System;

namespace LEXTRAIT_Hugo_TP6_ST2TDR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***  Welcome in AUTO PIZZA & CO Builder 2022   ***\n");

            Menu menu = new Menu();
            PizzaBuilder builder = new PizzaBuilder();

            menu.smallMargarita(builder);
            Console.WriteLine(builder.GetPizza().ToString());

            menu.largeMargarita(builder);
            Console.WriteLine(builder.GetPizza().ToString());

            menu.smallChorizza(builder);
            Console.WriteLine(builder.GetPizza().ToString());

            menu.largeChorizza(builder);
            Console.WriteLine(builder.GetPizza().ToString());

            menu.smallCalzone(builder);
            Console.WriteLine(builder.GetPizza().ToString());

            menu.largeCalzone(builder);
            Console.WriteLine(builder.GetPizza().ToString());

            menu.bigDogo(builder);
            Console.WriteLine(builder.GetPizza().ToString());
        }
    }
}