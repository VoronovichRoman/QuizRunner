using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManager : MonoBehaviour
{
    [SerializeField] MainMenuManager _mainMenuManager;
    [SerializeField] int _collectionNumber;
    [Header("Collections")]
    [SerializeField] List<GameObject> _collection_1Parts;
    public void OpenCollectionPart(int index)
    {
        if (PlayerAccount.PuzzlePiecesCount >= 1)
        {
            PlayerAccount.PuzzlePiecesCount--;
            List<bool> tempCollectionValues = ChoseCollectionValuesList(_collectionNumber);
            tempCollectionValues[index] = false;
            string tempCollection = "";
            foreach (var item in tempCollectionValues)
            {
                if (item)
                {
                    tempCollection += "1";
                }
                else
                {
                    tempCollection += "0";
                }
            }
            switch (_collectionNumber)
            {
                case 1:
                    PlayerAccount.Collection_1Values = tempCollectionValues;
                    PlayerAccount.Collection_1 = tempCollection;
                    break;
                case 2:
                    PlayerAccount.Collection_2Values = tempCollectionValues;
                    PlayerAccount.Collection_2 = tempCollection;
                    break;
                case 3:
                    PlayerAccount.Collection_3Values = tempCollectionValues;
                    PlayerAccount.Collection_3 = tempCollection;
                    break;
                case 4:
                    PlayerAccount.Collection_4Values = tempCollectionValues;
                    PlayerAccount.Collection_4 = tempCollection;
                    break;
                default:
                    break;
            }
            CollectionPartsCheck();
            _mainMenuManager.RefreshResourcesUI();
        }
    }
    public void CollectionPartsCheck()
    {
        for (int i = 0; i < _collection_1Parts.Count; i++)
        {
            _collection_1Parts[i].SetActive(ChoseCollectionValuesList(_collectionNumber)[i]);
        }
    }
    List<bool> ChoseCollectionValuesList(int index)
    {
        switch (index)
        {
            case 1:
                return PlayerAccount.Collection_1Values;
            case 2:
                return PlayerAccount.Collection_2Values;
            case 3:
                return PlayerAccount.Collection_3Values;
            case 4:
                return PlayerAccount.Collection_4Values;
            default:
                return null;
        }
    }
}
