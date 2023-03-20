using UnityEngine;

namespace StrategyExample.Movements
{
    public class RunMovement : IMovementStrategy
    {
        public void Move(Transform transform, float speed)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}