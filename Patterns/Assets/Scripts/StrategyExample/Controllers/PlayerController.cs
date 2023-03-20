using StrategyExample.Movements;
using UnityEngine;

namespace StrategyExample.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private float playerSpeed = 3.0f;
        private IMovementStrategy _movementStrategy;

        private void Start()
        {
            _movementStrategy = new RunMovement();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_movementStrategy is RunMovement)
                {
                    _movementStrategy = new ClimbMovement();
                }
                else
                {
                    _movementStrategy = new RunMovement();
                }
            }

            _movementStrategy.Move(transform, playerSpeed);
        }
    }   
}