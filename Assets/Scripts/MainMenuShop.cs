using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuShop : MonoBehaviour
{
    [SerializeField] int _price;
    [SerializeField] MainMenuManager _mainMenuManager;
    [Header("BuyAndQuizButtons")]
    [SerializeField] GameObject _solarSystemBuyButton;
    [SerializeField] Button _solarSystemQuizButton;
    [SerializeField] GameObject _vanGoghBuyButton;
    [SerializeField] Button _vanGoghQuizButton;
    [SerializeField] GameObject _louvreBuyButton;
    [SerializeField] Button _louvreQuizButton;
    //[Header("Collections")]
    //[SerializeField] List<GameObject> _collection_1Parts;
    public void BuyQuiz(string quizName)
    {
        if (_price <= PlayerAccount.DiamondsCount)
        {
            string category = "";
            PlayerAccount.DiamondsCount -= _price;

            switch (quizName)
            {
                case "SolarSystem":
                    PlayerAccount.IsSolarSystemQuizBought = 1;
                    category = "Astronomy";
                    break;
                case "VanGogh":
                    PlayerAccount.IsVanGoghQuizBought = 1;
                    category = "Art";
                    break;
                case "Louvre":
                    PlayerAccount.IsLouvreQuizBought = 1;
                    category = "Art";
                    break;
            }
            PurchasedQuizzesCheck(category);
            _mainMenuManager.LoadAccount();
        }
    }
    public void PurchasedQuizzesCheck(string category)
    {
        switch (category)
        {
            case "Geography":
                break;
            case "Astronomy":
                if (PlayerAccount.IsSolarSystemQuizBought == 0)
                {
                    _solarSystemQuizButton.interactable = false;
                }
                else
                {
                    _solarSystemQuizButton.interactable = true;
                    _solarSystemBuyButton.SetActive(false);
                }
                break;
            case "Art":
                if (PlayerAccount.IsVanGoghQuizBought == 0)
                {
                    _vanGoghQuizButton.interactable = false;
                }
                else
                {
                    _vanGoghQuizButton.interactable = true;
                    _vanGoghBuyButton.SetActive(false);
                }
                if (PlayerAccount.IsLouvreQuizBought == 0)
                {
                    _louvreQuizButton.interactable = false;
                }
                else
                {
                    _louvreQuizButton.interactable = true;
                    _louvreBuyButton.SetActive(false);
                }
                break;
        }
    }
    //public void OpenCollectionPart(int index)
    //{
    //    if (PlayerAccount.PuzzlePiecesCount >= 1)
    //    {
    //        PlayerAccount.PuzzlePiecesCount--;
    //        PlayerAccount.Collection_1Values[index] = false;
    //        PlayerAccount.Collection_1 = "";
    //        foreach (var item in PlayerAccount.Collection_1Values)
    //        {
    //            if (item)
    //            {
    //                PlayerAccount.Collection_1 += "1";
    //            }
    //            else
    //            {
    //                PlayerAccount.Collection_1 += "0";
    //            }
    //        }
    //        CollectionPartsCheck();
    //        _mainMenuManager.LoadAccount();
    //    }
    //}
    //public void CollectionPartsCheck()
    //{
    //    for (int i = 0; i < _collection_1Parts.Count; i++)
    //    {
    //        _collection_1Parts[i].SetActive(PlayerAccount.Collection_1Values[i]);
    //    }
    //}
}
