using System.Collections.Generic;

namespace BuilderExample.Base
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
    }
}