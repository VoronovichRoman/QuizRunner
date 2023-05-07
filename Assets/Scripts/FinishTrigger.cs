using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviour playerBehaviour = other.attachedRigidbody.GetComponent<PlayerBehaviour>();
        if (playerBehaviour)
        {
            playerBehaviour.StartFinishBehaviour();
            if (SceneManager.GetActiveScene().name.Contains("Quiz"))
            {
                FindObjectOfType<QuizManager>().ShowFinishWindow();
            }
            else
            {
                FindObjectOfType<GameManager>().ShowFinishWindow();
            }
        }
    }
}
