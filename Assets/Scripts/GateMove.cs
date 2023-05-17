using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMove : MonoBehaviour
{
    [SerializeField] bool _horizontalMove;
    [SerializeField] bool _verticalMove;
    [SerializeField] bool _circling;
    [SerializeField] bool _reverseÑircling;
    [SerializeField] float _moveSpeed;
    [SerializeField] float _moveWidth;
    [SerializeField] float _moveHeight;
    [SerializeField] GameObject _leftPillar;
    [SerializeField] GameObject _rightPillar;
    [SerializeField] float _horizontalDirection;
    [SerializeField] float _verticalDirection;
    float _leftBorder;
    float _rightBorder;
    private void Awake()
    {
        _rightBorder = _rightPillar.transform.localPosition.x + _rightPillar.transform.localScale.x / 2;
        _leftBorder = _leftPillar.transform.localPosition.x - _leftPillar.transform.localScale.x / 2;
    }
    void Update()
    {
        if (_circling)
        {
            _horizontalMove = _verticalMove = false;
            Ñircling();
        }
        if (_horizontalMove)
        {
            HorizontalMove();
        }
        if (_verticalMove)
        {
            VerticalMove();
        }
    }
    void VerticalMove()
    {
        Vector3 gatePosition = transform.position;
        gatePosition.y = Mathf.MoveTowards(gatePosition.y, _moveHeight * _verticalDirection, Time.deltaTime * _moveSpeed);
        if (gatePosition.y >= _moveHeight)
        {
            gatePosition.y = _moveHeight;
            _verticalDirection = -_verticalDirection;
        }
        if (gatePosition.y <= 0)
        {
            gatePosition.y = 0;
            _verticalDirection = -_verticalDirection;
        }
        transform.position = gatePosition;
    }
    void HorizontalMove()
    {
        Vector3 gatePosition = transform.position;
        gatePosition.x = Mathf.MoveTowards(gatePosition.x, _moveWidth / 2 * _horizontalDirection, Time.deltaTime * _moveSpeed);
        if (gatePosition.x + _rightBorder >= _moveWidth / 2)
        {
            gatePosition.x = _moveWidth / 2 - _rightBorder;
            _horizontalDirection = -_horizontalDirection;
        }
        if (gatePosition.x + _leftBorder <= -_moveWidth / 2)
        {
            gatePosition.x = -_moveWidth / 2 - _leftBorder;
            _horizontalDirection = -_horizontalDirection;
        }
        transform.position = gatePosition;
    }
    void Ñircling()
    {
        if (_verticalDirection == 1 && _horizontalDirection == -1)
        {
            if (!_reverseÑircling)
            {
                HorizontalMove();
            }
            else
            {
                VerticalMove();
            }
        }
        else if (_verticalDirection == 1 && _horizontalDirection == 1)
        {
            if (!_reverseÑircling)
            {
                VerticalMove();
            }
            else
            {
                HorizontalMove();
            }
        }
        else if (_verticalDirection == -1 && _horizontalDirection == 1)
        {
            if (!_reverseÑircling)
            {
                HorizontalMove();
            }
            else
            {
                VerticalMove();
            }
        }
        else if (_verticalDirection == -1 && _horizontalDirection == -1)
        {
            if (!_reverseÑircling)
            {
                VerticalMove();
            }
            else
            {
                HorizontalMove();
            }
        }
    }
}
