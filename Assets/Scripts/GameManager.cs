using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;
    [SerializeField] TextMeshProUGUI _levelText;
    [SerializeField] GameObject _finishWindow;
    [SerializeField] CoinManager _coinManager;
    [SerializeField] TextMeshProUGUI _finishText;
    private void Start()
    {
        _levelText.text = SceneManager.GetActiveScene().name;
    }
    public void Play()
    {
        _startMenu.SetActive(false);
        FindObjectOfType<PlayerBehaviour>().Play();
    }
    public void ShowFinishWindow()
    {
        _finishWindow.SetActive(true);
        _finishText.text = "Level finished!\nEarned Diamonds: " + (_coinManager.NumberOfCoins / 10);
    }
    public void NextLevel()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < 10)
        {
            _coinManager.SaveToProgress();

            SceneManager.LoadScene(next);
        }
    }
    public void GoToMainMenu()
    {
        Progress.Instance.Coins = 0;
        Progress.Instance.Height = 0;
        Progress.Instance.Width = 0;
        SceneManager.LoadScene("MainMenu");
    }
}
