using UnityEngine;

namespace _Game.Scripts.Game
{
    public class Car : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5f;

        private void Update()
        {
            transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
        }
        
        
    }
}