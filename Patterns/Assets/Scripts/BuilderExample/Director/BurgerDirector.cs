using System.Collections.Generic;
using BuilderExample.Builder;

namespace BuilderExample.Director
{
    public class BurgerDirector
    {
        private IBurgerBuilder _builder;

        public BurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }

        public void BuildHappyCheeseBurger()
        {
            _builder.SetBurgerSize("Large");
            _builder.AddIngredients(new List<string> { "Cheese, Lettuce, Tomato" });
        }

        public void BuildSimpleCheeseBurger()
        {
            _builder.SetBurgerSize(("Small"));
            _builder.AddIngredients(new List<string> { "Cheese" });
        }
    }
}