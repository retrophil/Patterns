using BuilderExample.Builder.Burgers;

namespace BuilderExample.Factories
{
    public class McChuftyFactory : BurgerFactory
    {
        public override Burger CookBurger()
        {
            return new McChufty();
        }
    }
}