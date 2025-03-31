using System;
using UnityEngine;

namespace _Game.Scripts.Game
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private GameModel model;
        [SerializeField] private Player player;

        private void Awake()
        {
            if (player == null)
            {
                throw new Exception("Player is not set in GameController");
            }


            player.InitPlayer(model.playerSpeed);
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                player.MoveLeft();
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                player.MoveRight();
            }
            else
            {
                player.StopMoving();
            }
        }
    }
}