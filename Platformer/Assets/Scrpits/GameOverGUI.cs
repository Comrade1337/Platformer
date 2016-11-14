using UnityEngine;

public class GameOverGUI : MonoBehaviour
{
    public Font font;

    GUIStyle guiTextStyle = new GUIStyle();

    void Awake()
    {
        guiTextStyle.font = font;
        guiTextStyle.fontSize = 50;
        guiTextStyle.normal.textColor = new Color(0.4F, 0.4F, 0.4F);
        guiTextStyle.hover.textColor = new Color(0F, 0F, 0F);
        guiTextStyle.hover.background = Texture2D.blackTexture;
        guiTextStyle.alignment = TextAnchor.MiddleCenter;
    }

    void OnGUI()
    {
        string score = string.Format("[ ваш окончательный счёт: {0}]", Data.Score);
        string star = string.Format("[ собрано звёзд: {0}]", Data.StarTotal);

        GUI.Label(new Rect(0, Screen.height / 2 - 150f, Screen.width, 45f), "[ игра пройдена ! ]", guiTextStyle);
        GUI.Label(new Rect(0, Screen.height / 2 - 50f, Screen.width, 45f), score, guiTextStyle);
        GUI.Label(new Rect(0, Screen.height / 2, Screen.width, 45f), star, guiTextStyle);

        if (GUI.Button(new Rect(0, Screen.height / 2 + 100, Screen.width, 45f), "[ выход ]", guiTextStyle))
        {
            Application.Quit();
        }
    }
}
