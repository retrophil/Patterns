using System.Collections.Generic;
using BuilderExample;

public class BurgerBuilder : IBurgerBuilder
{
    private Burger _burger = new Burger("", new List<string>());

    public void SetSize(string size)
    {
        _burger.Size = size;
    }

    public void SetBurgerSize(string size)
    {
        _burger.Size = size;
    }

    public void AddIngredients(List<string> ingredients)
    {
        _burger.Ingredients.AddRange(ingredients);
    }

    public Burger GetBurger()
    {
        return _burger;
    }
}