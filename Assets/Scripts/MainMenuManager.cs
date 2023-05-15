using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _diamondsCountText;
    [SerializeField] TextMeshProUGUI _puzzlePiecesCountText;
    private void Start()
    {
        PlayerAccount.LoadAccount();
        _diamondsCountText.text = PlayerAccount.DiamondsCount.ToString() + " x ";
        _puzzlePiecesCountText.text = PlayerPrefs.GetInt("PuzzlePiecesCount").ToString() + " x ";
    }
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
    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
        PlayerAccount.LoadAccount();
        _diamondsCountText.text = PlayerAccount.DiamondsCount.ToString();
        _puzzlePiecesCountText.text = PlayerPrefs.GetInt("PuzzlePiecesCount").ToString();
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
