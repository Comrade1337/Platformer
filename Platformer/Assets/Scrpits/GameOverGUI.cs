using UnityEngine;

public class GameOverGUI : MonoBehaviour
{
    public Font font;

    GUIStyle guiTextStyle = new GUIStyle();

    void Awake()
    {
        guiTextStyle.font = font;
        guiTextStyle.fontSize = 40;
        guiTextStyle.normal.textColor = new Color(0.4F, 0.4F, 0.4F);
        guiTextStyle.alignment = TextAnchor.MiddleCenter;
    }

    void OnGUI()
    {
        string score = string.Format("[ ваш окончательный счёт: {0}]", Data.Score);
        string star = string.Format("[ собрано звёзд {0}]", Data.StarTotal);

        GUI.Label(new Rect(Screen.width / 2 - 150f, Screen.height / 2 - 150f, 300f, 45f), "[ игра пройдена ! ]", guiTextStyle);
        GUI.Label(new Rect(Screen.width / 2 - 150f, Screen.height / 2 - 50f, 300f, 45f), score, guiTextStyle);
        GUI.Label(new Rect(Screen.width / 2 - 150f, Screen.height / 2, 300f, 45f), star, guiTextStyle);
    }
}
