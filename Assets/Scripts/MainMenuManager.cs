using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame(string gameMode)
    {
        switch (gameMode)
        {
            case "Run":
                SceneManager.LoadScene("Level 1");
                break;
            case "Guess the city":
                SceneManager.LoadScene("Quiz_Geography_GuessTheCity");
                break;
            case "Solar system":
                SceneManager.LoadScene("Quiz_Astronomy_SolarSystem");
                break;
            case "Van Gogh":
                SceneManager.LoadScene("Quiz_Art_VanGogh"); 
                break;
            case "Louvre":
                SceneManager.LoadScene("Quiz_Art_LouvrePaintings");
                break;
            default:
                break;
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
