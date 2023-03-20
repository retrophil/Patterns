using BuilderExample.Builder;
using BuilderExample.Builder.Burgers;
using BuilderExample.Factories;
using UnityEngine;

namespace BuilderExample
{
    public class BuilderPatternExample : MonoBehaviour
    {
        void Start()
        {
            McChuftyFactory mCChuftyFactory = new McChuftyFactory();
            BurgerBuilder mCChuftyBuilder = new BurgerBuilder(mCChuftyFactory);
            Burger mcChufty = mCChuftyBuilder.BuildBurger();
            Debug.Log($"Burger: {mcChufty.Name}, TasteLevel: {mcChufty.TasteLevel}");

            McHappyFactory mCHappyFactory = new McHappyFactory();
            BurgerBuilder mCHappyBuilder = new BurgerBuilder(mCHappyFactory);
            Burger mCHappy = mCHappyBuilder.BuildBurger();
            Debug.Log($"Burger: {mCHappy.Name}, TasteLevel: {mCHappy.TasteLevel}");
        }
    }
}
