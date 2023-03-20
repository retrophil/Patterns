using BuilderExample.Builder.Burgers;
using BuilderExample.Factories;

namespace BuilderExample.Builder
{
    public class BurgerBuilder
    {
        private BurgerFactory _burgerFactory;

        public BurgerBuilder(BurgerFactory burgerFactory)
        {
            _burgerFactory = burgerFactory;
        }

        public Burger BuildBurger()
        {
            return _burgerFactory.CookBurger();
        }
    }
}