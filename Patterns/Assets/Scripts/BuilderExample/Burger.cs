using System.Collections.Generic;
using UnityEngine;

namespace BuilderExample
{
    public class Burger
    {
        public string Size { get; set; }
        public List<string> Ingredients { get; set; }
    
        public Burger(string size, List<string> ingredients)
        {
            Size = size;
            Ingredients = ingredients;
        }

        public void Display()
        {
            Debug.Log($"BurgerSize: {Size}, Ingredients: {string.Join(", ", Ingredients)}");
        }
    }
}
