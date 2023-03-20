using UnityEngine;

namespace StrategyExample.Movements
{
    public interface IMovementStrategy
    {
        void Move(Transform transform, float speed);
    }   
}
