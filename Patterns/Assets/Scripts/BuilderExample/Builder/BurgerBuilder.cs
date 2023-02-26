using System.Collections.Generic;
using BuilderExample.Base;

namespace BuilderExample.Builder
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger = new Burger("", new List<string>());

        public void SetBurgerSize(string size)
        {
            _burger.Size = size;
        }

        public void AddIngredients(List<string> ingredients)
        {
            _burger.Ingredients = ingredients;
        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }
}