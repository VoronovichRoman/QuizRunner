using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] CoinManager _coinManager;

    PlayerModifier _playerModifier;

    private void Start()
    {
        _playerModifier = FindObjectOfType<PlayerModifier>();
    }
    public void BuyWidth()
    {
        if (_coinManager.NumberOfCoins >= 50)
        {
            _coinManager.SpendMoney(50);
            Progress.Instance.Coins = _coinManager.NumberOfCoins;
            Progress.Instance.Width += 50;
            _playerModifier.SetWidth(Progress.Instance.Width);
        }
    }

    public void BuyHeight()
    {
        if (_coinManager.NumberOfCoins >= 50)
        {
            _coinManager.SpendMoney(50); 
            Progress.Instance.Coins = _coinManager.NumberOfCoins;
            Progress.Instance.Height += 50;
            _playerModifier.SetHeight(Progress.Instance.Height);
        }
    }
}
