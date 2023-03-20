using UnityEngine;

namespace StrategyExample.Movements
{
    public class ClimbMovement : IMovementStrategy
    {
        public void Move(Transform transform, float speed)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }
}