public static class Data
{
    static int _score;
    static int _stars;
    static int _lives = 5;
    static int _completedLevels = 0;

    public static int Stars
    {
        get
        {
            return _stars;
        }

        set
        {
            _stars = value;

            if (_stars >= 100)
            {
                _lives++;
                _stars -= 100;
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
            _score = _stars * 100 + _completedLevels * 1000;
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
}
