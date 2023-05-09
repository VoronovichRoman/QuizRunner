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

    public static void LoadAccount()
    {
        if (PlayerPrefs.HasKey("DiamondsCount"))
        {
            DiamondsCount = PlayerPrefs.GetInt("DiamondsCount");
            PuzzlePiecesCount = PlayerPrefs.GetInt("PuzzlePiecesCount");
            IsSolarSystemQuizBought = PlayerPrefs.GetInt("IsSolarSystemQuizBought");
            IsVanGoghQuizBought = PlayerPrefs.GetInt("IsVanGoghQuizBought");
            IsLouvreQuizBought = PlayerPrefs.GetInt("IsLouvreQuizBought");
        }
        else
        {
            DiamondsCount = 0;
            PuzzlePiecesCount = 0;
            IsSolarSystemQuizBought = 0;
            IsVanGoghQuizBought = 0;
            IsLouvreQuizBought = 0;
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


}