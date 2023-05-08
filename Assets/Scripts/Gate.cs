using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] bool _quizOptionMode;
    [SerializeField] int _value;
    [SerializeField] DeformationType _deformationType;
    [SerializeField] GateAppearaence _gateAppearaence;

    QuizScoreManager _quizScoreManager;
    private void OnValidate()
    {
        if (_quizOptionMode)
        {
            _quizScoreManager = FindObjectOfType<QuizScoreManager>();
        }
        else
        {
            _gateAppearaence.UpdateVisual(_deformationType, _value);
        }        
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (playerModifier)
        {
            if (_deformationType == DeformationType.Width)
            {
                playerModifier.AddWidth(_value);
                if (_quizOptionMode)
                {
                    _quizScoreManager.ScoreCount(_value);
                }
            }
            else if (_deformationType == DeformationType.Height)
            {
                playerModifier.AddHeight(_value);
            }

            Destroy(gameObject);
        }
    }
}
