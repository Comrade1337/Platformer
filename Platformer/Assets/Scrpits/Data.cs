public static class Data
{
    static int _score;
    static int _lives = 5;

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
}
