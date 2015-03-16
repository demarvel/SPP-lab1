using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_lab1
{
    public abstract class PizzaStore
    {
        public Pizza OrederPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cute();
            pizza.Box();
            return pizza;
        }
        abstract Pizza CreatePizza(string type);
    }
    public class NYStore : PizzaStore
    {
        Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("NewYork"))
            {
                pizza = new NewYorkPizza();
            }
            else if (type.Equals("Americano"))
            {
                pizza = new AmericanoPizza();
            }
            return pizza;
        }
    }
    public class MexicoStore : PizzaStore
    {
        Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("Americano"))
            {
                pizza = new AmericanoPizza();
            }
            else if (type.Equals("Mexico"))
            {
                pizza = new MexicoPizza();
            }
            return pizza;
        }
    }

    public class FabricPizza
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("NewYork"))
            {
                pizza = new NewYorkPizza();
            }
            else if (type.Equals("Americano"))
            {
                pizza = new AmericanoPizza();
            }
            else if (type.Equals("Mexico"))
            {
                pizza = new MexicoPizza();
            }
            return pizza;
        }
    }
    public abstract class Pizza
    {
        public string name = "Pizza classic";
        public string bake = "выпекать при 360 гр.";
        public string cute = "бла бла бла";
        public string box = "коробка стандартная";
        public string Prepare() { return this.name; }
        public string Bake() { return this.bake; }
        public string Cute() { return this.cute; }
        public string Box() { return this.box; }
    }
    public class NewYorkPizza : Pizza
    {
        public string name = "NewYork Pizza";
        public string bake = "выпекать при 330 гр.";
        public string cute = "тонкая корочка";
        public string box = "коробка из старбакса";
    }
    public class AmericanoPizza : Pizza
    {
        public string name = "Americano Pizza";
        public string bake = "выпекать при 460 гр.";
        public string cute = "корка средней прожаренности";
        public string box = "коробка со стилем кофе";
    }
    public class MexicoPizza : Pizza
    {
        public string name = "Mexico Pizza";
        public string bake = "выпекать при 260 гр.";
        public string cute = "толстая корка";
        public string box = "на коробке нарисован Эль-Мучачос";
    }
}
