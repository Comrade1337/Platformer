using System;
using UnityEngine.SceneManagement;

public class Data
{
    static int _score;
    static int _stars;
    static int _lives;
    static int _completedLevels;
    static int _starTotal;

    static Data()
    {
        DefaultValues();
    }

    public static int Stars
    {
        get
        {
            return _stars;
        }

        set
        {
            _starTotal += (value == 0) ? 0 : value - _stars;
            _stars = value;

            if (_stars >= 10)
            {
                _lives++;
                _stars -= 10;
            }
        }
    }
    public static int Lives
    {
        get
        {
            return _lives;
        }

        set
        {
            _lives = value;
        }
    }
    public static int Score
    {
        get
        {
            _score = _starTotal * 100 + _completedLevels * 1000;
            return _score;
        }

        set
        {
            _score = value;
        }
    }
    public static int CompletedLevels
    {
        get
        {
            return _completedLevels;
        }

        set
        {
            _completedLevels = value;
        }
    }
    public static int StarTotal
    {
        get
        {
            return _starTotal;
        }

        set
        {
            _starTotal = value;
        }
    }
    public static bool Paused { get; set; }
    public static int CurrentLevelIndex
    {
        get
        {
            return SceneManager.GetActiveScene().buildIndex;
        }
    }

    /// <summary>
    /// Значения по умолчанию
    /// </summary>
    public static void DefaultValues()
    {
        _score = 0;
        _stars = 0;
        _lives = 5;
        _completedLevels = 0;
        _starTotal = 0;
    }
}
