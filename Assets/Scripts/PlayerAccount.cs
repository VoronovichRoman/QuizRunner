using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerAccount
{
    static int _diamondsCount;
    static int _puzzlePiecesCount;
    static int _isSolarSystemQuizBought;
    static int _isVanGoghQuizBought;
    static int _isLouvreQuizBought;
    static string _collection_1;

    static public List<bool> Collection_1Values;
    
    public static void LoadAccount()
    {
        Collection_1Values = new List<bool>() { true, true, true, true, true, true, true, true, true };
        if (PlayerPrefs.HasKey("DiamondsCount"))
        {
            DiamondsCount = PlayerPrefs.GetInt("DiamondsCount");
            PuzzlePiecesCount = PlayerPrefs.GetInt("PuzzlePiecesCount");
            IsSolarSystemQuizBought = PlayerPrefs.GetInt("IsSolarSystemQuizBought");
            IsVanGoghQuizBought = PlayerPrefs.GetInt("IsVanGoghQuizBought");
            IsLouvreQuizBought = PlayerPrefs.GetInt("IsLouvreQuizBought");
            Collection_1 = PlayerPrefs.GetString("Collection_1");
           // Collection_1 = "111111111";
            char[] chars =  Collection_1.ToCharArray();
            Debug.Log("jhnorfgoik");
            for (int i = 0; i < 9; i++)
            {
                if (chars[i] == '1')
                {
                    Debug.Log("Uno");
                    Collection_1Values[i] = true;
                }
                else
                {
                    Debug.Log("ds");
                    Collection_1Values[i] = false;
                }
            }
        }
        else
        {
            DiamondsCount = 0;
            PuzzlePiecesCount = 0;
            IsSolarSystemQuizBought = 0;
            IsVanGoghQuizBought = 0;
            IsLouvreQuizBought = 0;
            Collection_1 = "111111111";
            //Collection_1Values = new List<bool>() { true, true, true, true, true, true, true, true, true };
        }
    }
    public static int DiamondsCount
    {
        get { return _diamondsCount; }
        set
        {
            _diamondsCount = value;
            PlayerPrefs.SetInt("DiamondsCount", DiamondsCount);
        }
    }
    public static int PuzzlePiecesCount
    {
        get { return _puzzlePiecesCount; }
        set
        {
            _puzzlePiecesCount = value;
            PlayerPrefs.SetInt("PuzzlePiecesCount", PuzzlePiecesCount);
        }
    }

    public static int IsSolarSystemQuizBought
    {
        get { return _isSolarSystemQuizBought; }
        set
        {
            _isSolarSystemQuizBought = value;
            PlayerPrefs.SetInt("IsSolarSystemQuizBought", IsSolarSystemQuizBought);
        }
    }

    public static int IsVanGoghQuizBought
    {
        get { return _isVanGoghQuizBought; }
        set
        {
            _isVanGoghQuizBought = value;
            PlayerPrefs.SetInt("IsSolarSystemQuizBought", IsVanGoghQuizBought);
        }
    }

    public static int IsLouvreQuizBought
    {
        get { return _isLouvreQuizBought; }
        set
        {
            _isLouvreQuizBought = value;
            PlayerPrefs.SetInt("IsSolarSystemQuizBought", IsLouvreQuizBought);
        }
    }
    public static string Collection_1
    {
        get { return _collection_1; }
        set
        {
            _collection_1 = value;
            PlayerPrefs.SetString("Collection_1", Collection_1);
        }
    }
}
