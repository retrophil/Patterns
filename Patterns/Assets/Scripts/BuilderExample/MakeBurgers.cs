using BuilderExample.Base;
using BuilderExample.Builder;
using BuilderExample.Director;
using BuilderExample.Enumerations;
using UnityEngine;
using UnityEngine.Serialization;

namespace BuilderExample
{
    public class MakeBurgers : MonoBehaviour
    {
        [FormerlySerializedAs("burgerOrder")] [FormerlySerializedAs("burgerType")] [SerializeField] private BurgerType burgerOrderToKitchen;
        public void Start()
        {
            PickBurger(burgerOrderToKitchen);
        }

        private void PickBurger(BurgerType burgerOrder)
        {
            BurgerBuilder _builder = new BurgerBuilder();
            BurgerDirector _director = new BurgerDirector(_builder);
            
            switch (burgerOrder)
            {
                case BurgerType.Simple:
                {
                    _director.BuildSimpleCheeseBurger();
                    Burger buildSimpleCheeseBurger = _builder.GetBurger();
                    Display(buildSimpleCheeseBurger);
                    break;
                }

                case BurgerType.Happy:
                {
                    _director.BuildHappyCheeseBurger();
                    Burger happyCheeseBurger = _builder.GetBurger();
                    Display(happyCheeseBurger);
                    break;
                }
            }
        }
        
        private void Display(Burger madeBurger)
        {
            Debug.Log($"BurgerSize: {madeBurger.Size}, Ingredients: {string.Join(", ", madeBurger.Ingredients)}");
        }
    }
}