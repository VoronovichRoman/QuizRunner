using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterMovement : MonoBehaviour
{
    [SerializeField] float _clockwiseRotationBorder;
    [SerializeField] float _counterClockwiseRotationBorder;
    [SerializeField] float _rotationSpeed;
    void Update()
    {
        if (  transform.eulerAngles.y >= _clockwiseRotationBorder && transform.eulerAngles.y <= _counterClockwiseRotationBorder)
        {
            _rotationSpeed = -_rotationSpeed;
        }
        Debug.Log(transform.eulerAngles.y);

        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
        
    }
}
