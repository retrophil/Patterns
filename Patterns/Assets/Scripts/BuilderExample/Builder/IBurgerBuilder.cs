using System.Collections.Generic;
using BuilderExample.Base;

namespace BuilderExample.Builder
{
    public interface IBurgerBuilder
    {
        void SetBurgerSize(string size);
        void AddIngredients(List<string> ingredients);
        Burger GetBurger();
    }
}