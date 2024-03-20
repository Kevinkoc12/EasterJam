using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("Juego");
    }

    public void LeaderBoard()
    {
        SceneManager.LoadScene("LeaderBoard");
    }

    public void Info()
    {
        SceneManager.LoadScene("Info");
    }

    public void Inicio()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void ExitApp()
    {
        Application.Quit();
    }

}
