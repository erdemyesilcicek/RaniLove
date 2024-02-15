using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartController : MonoBehaviour
{
    public void restartGame()
    {
        int presentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(presentScene);
    }
    public void quitTheGame() => Application.Quit();
}
