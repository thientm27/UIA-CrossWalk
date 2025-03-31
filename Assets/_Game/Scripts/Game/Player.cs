using UnityEngine;

namespace _Game.Scripts.Game
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        [SerializeField] private GameObject uiaModel;

        private float _speed = 5f;

        public void InitPlayer(float playerSpeed)
        {
            _speed = playerSpeed;
        }

        public void MoveLeft()
        {
            transform.position += Vector3.back * _speed * Time.deltaTime;
            if (animator != null)
            {
                animator.SetBool("isSpin", true);
            }
        }

        public void MoveRight()
        {
            transform.position += Vector3.forward * _speed * Time.deltaTime;
            if (animator != null)
            {
                animator.SetBool("isSpin", true);
            }
        }
        
        public void StopMoving()
        {
            if (animator != null)
            {
                animator.SetBool("isSpin", false);
            }
        }
    }
}