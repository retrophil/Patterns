using UnityEngine;

namespace BuilderExample
{
    public class MakeBurgers : MonoBehaviour
    {
        public void Start()
        {
            BurgerBuilder _builder = new BurgerBuilder();
            BurgerDirector _director = new BurgerDirector(_builder);
    
            _director.BuildHappyCheeseBurger();
            Burger happyCheeseBurger = _builder.GetBurger();
            Display(happyCheeseBurger);
        }

        private void Display(Burger madeBurger)
        {
            Debug.Log($"BurgerSize: {madeBurger.Size}, Ingredients: {string.Join(", ", madeBurger.Ingredients)}");
        }
    }
}