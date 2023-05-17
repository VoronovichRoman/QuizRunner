using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizScoreManager : MonoBehaviour
{
    [SerializeField] int _maxCorrectAnswers;
    [SerializeField] float _percentageOfCorrectness;

    public float ÑorrectAnswers;
    public float IncorrectAnswers;
    public void ScoreCount(int value)
    {
        if (value > 0)
        {
            ÑorrectAnswers++;
        }
        else if (value < 0)
        {
            IncorrectAnswers++;
        }
    }
    public float GettingPuzzlePiece()
    {
        float value = (ÑorrectAnswers - IncorrectAnswers) / _maxCorrectAnswers * 100;
        if (value >= _percentageOfCorrectness)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
