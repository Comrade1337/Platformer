public static class Data
{
    static int _score;
    static int _stars;
    static int _lives = 5;

    public static int Stars
    {
        get
        {
            return _stars;
        }

        set
        {
            _score += 100;
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
            return _score;
        }

        set
        {
            _score = value;
        }
    }
}
