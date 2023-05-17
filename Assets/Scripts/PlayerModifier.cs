using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModifier : MonoBehaviour
{
    [SerializeField] int _width;
    [SerializeField] int _height;
    [SerializeField] Renderer _renderer;
    [SerializeField] Transform _topSpine;
    [SerializeField] Transform _bottomSpine;
    [SerializeField] Transform _colliderTransform;
    [SerializeField] AudioSource _resizeSound;

    float _widthMultiplier = 0.0005f;
    float _heightMultiplier = 0.006f;
    private void Start()
    {
        SetWidth(Progress.Instance.Width);
        SetHeight(Progress.Instance.Height);
    }
    void Update()
    {
        //TestSizeChange();
    }
    public void AddWidth(int value)
    {
        _width += value;
        UpdateWidth();
        _resizeSound.Play();
        if (_width < -100)
        {
            Die();
        }
    }
    public void AddHeight(int value)
    {
        _height += value;
        UpdateHeight();
        _resizeSound.Play();
        if (_height < -100)
        {
            Die();
        }
    }
    public void SetWidth(int value)
    {
        _width = value;
        UpdateWidth();
    }
    public void SetHeight(int value)
    {
        _height = value;
        UpdateHeight();
    }
    public void HitBlock(int value)
    {
        if (_height > 0)
        {
            _height -= value;
            UpdateHeight();
        }
        else if (_width > 0)
        {
            _width -= value;
            UpdateWidth();
        }
        else
        {
            Die();
        }
    }
    void UpdateWidth()
    {
        _renderer.material.SetFloat("_PushValue", _width * _widthMultiplier);
        ColliderResize();
    }
    void UpdateHeight()
    {
        _topSpine.position = _bottomSpine.position + new Vector3(0, _height * _heightMultiplier, 0);
        ColliderResize();
    }
    void ColliderResize()
    {
        _colliderTransform.localScale = new Vector3(1.1f + _width * _widthMultiplier, 1.7f + _height * _heightMultiplier, 1);
    }
    void Die()
    {
        FindObjectOfType<GameManager>().ShowFinishWindow();
        Destroy(gameObject);
    }
    void TestSizeChange()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            AddWidth(50);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            AddHeight(50);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddWidth(-50);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            AddHeight(-50);
        }
    }
}
