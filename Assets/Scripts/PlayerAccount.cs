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
    static string _collection_2;
    static string _collection_3;
    static string _collection_4;

    static public List<bool> Collection_1Values;
    static public List<bool> Collection_2Values;
    static public List<bool> Collection_3Values;
    static public List<bool> Collection_4Values;

    public static void LoadAccount()
    {
        Collection_1Values = new List<bool>() { true, true, true, true, true, true, true, true, true };
        Collection_2Values = new List<bool>() { true, true, true, true, true, true, true, true, true };
        Collection_3Values = new List<bool>() { true, true, true, true, true, true, true, true, true };
        Collection_4Values = new List<bool>() { true, true, true, true, true, true, true, true, true };
        if (PlayerPrefs.HasKey("DiamondsCount"))
        {
            LoadData();
            Collection_1Values = CollectionInitialization(Collection_1, Collection_1Values);
            Collection_2Values = CollectionInitialization(Collection_2, Collection_2Values);
            Collection_3Values = CollectionInitialization(Collection_3, Collection_3Values);
            Collection_4Values = CollectionInitialization(Collection_4, Collection_4Values);
        }
        else
        {
            LoadDefaultData();
        }
    }
    static List<bool> CollectionInitialization(string colection, List<bool> collecnionValues)
    {
        char[] chars = colection.ToCharArray();
        for (int i = 0; i < 9; i++)
        {
            if (chars[i] == '1')
            {
                collecnionValues[i] = true;
            }
            else
            {
                collecnionValues[i] = false;
            }
        }
        return collecnionValues;
    }
    public static void LoadData()
    {
        DiamondsCount = PlayerPrefs.GetInt("DiamondsCount");
        PuzzlePiecesCount = PlayerPrefs.GetInt("PuzzlePiecesCount");
        IsSolarSystemQuizBought = PlayerPrefs.GetInt("IsSolarSystemQuizBought");
        IsVanGoghQuizBought = PlayerPrefs.GetInt("IsVanGoghQuizBought");
        IsLouvreQuizBought = PlayerPrefs.GetInt("IsLouvreQuizBought");
        Collection_1 = PlayerPrefs.GetString("Collection_1");
        Collection_2 = PlayerPrefs.GetString("Collection_2");
        Collection_3 = PlayerPrefs.GetString("Collection_3");
        Collection_4 = PlayerPrefs.GetString("Collection_4");
    }
    static void LoadDefaultData()
    {
        DiamondsCount = 0;
        PuzzlePiecesCount = 0;
        IsSolarSystemQuizBought = 0;
        IsVanGoghQuizBought = 0;
        IsLouvreQuizBought = 0;
        Collection_1 = "111111111";
        Collection_2 = "111111111";
        Collection_3 = "111111111";
        Collection_4 = "111111111";
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
            PlayerPrefs.SetInt("IsVanGoghQuizBought", IsVanGoghQuizBought);
        }
    }
    public static int IsLouvreQuizBought
    {
        get { return _isLouvreQuizBought; }
        set
        {
            _isLouvreQuizBought = value;
            PlayerPrefs.SetInt("IsLouvreQuizBought", IsLouvreQuizBought);
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
    public static string Collection_2
    {
        get { return _collection_2; }
        set
        {
            _collection_2 = value;
            PlayerPrefs.SetString("Collection_2", Collection_2);
        }
    }
    public static string Collection_3
    {
        get { return _collection_3; }
        set
        {
            _collection_3 = value;
            PlayerPrefs.SetString("Collection_3", Collection_3);
        }
    }
    public static string Collection_4
    {
        get { return _collection_4; }
        set
        {
            _collection_4 = value;
            PlayerPrefs.SetString("Collection_4", Collection_4);
        }
    }
}
