using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void startGame() => SceneManager.LoadScene(1);
    public void quitGame() => Application.Quit();
}