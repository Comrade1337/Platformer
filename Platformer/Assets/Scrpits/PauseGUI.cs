using UnityEngine;

public class PauseGUI : MonoBehaviour
{
    public Font font;

    GUIStyle guiTextStyle = new GUIStyle();
    GUIStyle guiButtonStyle = new GUIStyle();

    void Awake()
    {
        guiTextStyle.font = font;
        guiTextStyle.fontSize = 50;
        guiTextStyle.normal.textColor = new Color(0.4F, 0.4F, 0.4F);
        guiTextStyle.hover.textColor = new Color(1F, 1F, 1F);

        guiButtonStyle.font = font;
        guiButtonStyle.fontSize = 40;
        guiButtonStyle.normal.textColor = new Color(0.4F, 0.4F, 0.4F);
        guiButtonStyle.hover.textColor = new Color(1F, 1F, 1F);
        guiButtonStyle.border = new RectOffset(10, 10, 10, 10);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 100, 100, 100), "[ пауза ]", guiTextStyle);

        if (GUI.Button(new Rect(Screen.width / 2 - 65, Screen.height / 2, 130, 40), "продолжить", guiButtonStyle))
            Data.Paused = true;
        if (GUI.Button(new Rect(Screen.width / 2 - 85, Screen.height / 2 + 50, 180, 40), "выйти из игры", guiButtonStyle))
            Application.Quit();
    }
}
