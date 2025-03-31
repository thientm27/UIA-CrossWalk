using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Game.Scripts.Entry
{
    public class EntryController : MonoBehaviour
    {
       [SerializeField] private GameObject dontDestroyOnLoad;
       
         private void Awake()
         {
              if (dontDestroyOnLoad != null)
              {
                DontDestroyOnLoad(dontDestroyOnLoad);
              }
         }

         private void Start()
         {
             SceneManager.LoadScene("_Game/Scenes/Game");
         }
    }
}
