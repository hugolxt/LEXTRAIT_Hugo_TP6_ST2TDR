using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEXTRAIT_Hugo_TP6_ST2TDR
{
    class Menu
    {
        private Creator pizzaInit;


        void setCreate(Creator pizzaInit)
        {
            this.pizzaInit = pizzaInit;
        }

        public void smallMargarita(Creator pizzaInit)
        {
            pizzaInit.deletePizza();
            pizzaInit.setName("Margarita");
            pizzaInit.setSize("Small");
            pizzaInit.setDough("Wheat flour");
            String[] toppings = { "Tomatoes", "Mozarella", "Basilic", "Olive oil" };
            pizzaInit.setTopping(toppings);
        }
        public void largeMargarita(Creator pizzaInit)
        {
            pizzaInit.deletePizza();
            pizzaInit.setName("Margarita");
            pizzaInit.setSize("Large");
            pizzaInit.setDough("Wheat flour");
            String[] toppings = { "Tomatoes", "Mozarella", "Basilic", "Olive oil" };
            pizzaInit.setTopping(toppings);
        }

        public void smallCalzone(Creator pizzaInit)
        {
            pizzaInit.deletePizza();
            pizzaInit.setName("Calzone");
            pizzaInit.setSize("Small");
            pizzaInit.setDough("Folded on itself");
            String[] toppings = { "Cheese", "Pepers", "Onions", "Olive oil", "Ham" };
            pizzaInit.setTopping(toppings);
        }

        public void largeCalzone(Creator pizzaInit)
        {
            pizzaInit.deletePizza();
            pizzaInit.setName("Calzone");
            pizzaInit.setSize("Large");
            pizzaInit.setDough("Folded on itself");
            String[] toppings = {"Cheese", "Pepers", "Onions", "Olive oil", "Ham"};
            pizzaInit.setTopping(toppings);
        }

        public void smallChorizza(Creator pizzaInit)
        {
            pizzaInit.deletePizza();
            pizzaInit.setName("Chorizza");
            pizzaInit.setSize("Small");
            pizzaInit.setDough("Folded on itself");
            String[] toppings = {"Tomato", "mozzarella", "Chorizzo", "Goat cheese", "Olives"};
            pizzaInit.setTopping(toppings);
        }

        public void largeChorizza(Creator pizzaInit)
        {
            pizzaInit.deletePizza();
            pizzaInit.setName("Chorizza");
            pizzaInit.setSize("Large");
            pizzaInit.setDough("Folded on itself");
            String[] toppings = {"Tomato", "mozzarella", "Chorizzo", "Goat cheese", "Olives"};
            pizzaInit.setTopping(toppings);
        }

        public void bigDogo(Creator pizzaInit)
        {
            pizzaInit.deletePizza();
            pizzaInit.setName("Dogo");
            pizzaInit.setSize("Big");
            pizzaInit.setDough("Dough 110%");
            String[] toppings = { };
            pizzaInit.setTopping(toppings);
        }

    }
}