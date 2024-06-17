using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
   public void GameStart()
   {
        SceneManager.LoadScene("Game");
   }
   public void GameSetthings()
   {
      SceneManager.LoadScene("Settings");
   }

   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
         SceneManager.LoadScene("PauseScene");
      if (Input.GetKeyDown(KeyCode.Return))
      {
         SceneManager.LoadScene("Game");
      }
      }
   }
   
}
