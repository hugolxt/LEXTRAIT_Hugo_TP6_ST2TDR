using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEXTRAIT_Hugo_TP6_ST2TDR
{
    class PizzaBuilder : Creator
    {
        private Pizza Pizza;

        public PizzaBuilder() { this.Pizza = new Pizza(); }

        void Creator.deletePizza()
        {
            this.Pizza = new Pizza(); // destruct our item
        }
        void Creator.setName(string name)
        {
            Pizza.setName(name);
        }

        void Creator.setSize(string size)
        {
            Pizza.setSize(size);
        }

        void Creator.setDough(string dough)
        {
            Pizza.setDough(dough);
        }

        void Creator.setTopping(string[] topping)
        {
            Pizza.setTopping(topping);
        }

        public Pizza GetPizza()
        {
            return this.Pizza;  // getter => allow to access the pizza 
        }


    }
}