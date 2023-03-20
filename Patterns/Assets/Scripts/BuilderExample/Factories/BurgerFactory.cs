using BuilderExample.Builder.Burgers;

namespace BuilderExample.Factories
{
    public abstract class BurgerFactory
    {
        public abstract Burger CookBurger();
    }
}