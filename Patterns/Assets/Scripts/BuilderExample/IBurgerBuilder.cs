using System.Collections.Generic;

namespace BuilderExample
{
    public interface IBurgerBuilder
    {
        void SetBurgerSize(string size);
        void AddIngredients(List<string> ingredients);
        Burger GetBurger();
    }
}