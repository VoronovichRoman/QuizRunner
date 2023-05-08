using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;
    [SerializeField] TextMeshProUGUI _finishText;
    [SerializeField] GameObject _finishWindow;
    [SerializeField] GameObject _scoreManager;

    QuizScoreManager _finishScore;
    private void Start()
    {
        _finishScore = _scoreManager.GetComponent<QuizScoreManager>();
    }
    public void Play()
    {
        _startMenu.SetActive(false);
        FindObjectOfType<PlayerBehaviour>().Play();
    }
    public void ShowFinishWindow()
    {
        _finishWindow.SetActive(true);
        _finishText.text = "Correct: " + _finishScore.ÑorrectAnswers + "\nIncorrect: " + _finishScore.IncorrectAnswers 
            + "\nEarned fragments: " + _finishScore.GettingPuzzlePiece();
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
