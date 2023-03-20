using BuilderExample.Builder.Burgers;

namespace BuilderExample.Factories
{
    public class McHappyFactory : BurgerFactory
    {
        public override Burger CookBurger()
        {
            return new McHappy();
        }
    }
}