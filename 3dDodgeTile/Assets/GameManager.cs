using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public void EndGame()
    {
        Debug.Log("quit");
        Restart();
    }

    void Restart()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
