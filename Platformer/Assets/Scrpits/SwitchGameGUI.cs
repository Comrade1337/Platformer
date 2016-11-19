using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchGameGUI : MonoBehaviour
{
    public GUIStyle guiButtonStyle = new GUIStyle();

    GUIStyle guiTextStyle = new GUIStyle();

    void Awake()
    {
        guiTextStyle.font = guiButtonStyle.font;
        guiTextStyle.fontSize = 50;
        guiTextStyle.normal.textColor = new Color(0.4F, 0.4F, 0.4F);
        guiButtonStyle.hover.background = Texture2D.blackTexture;
        guiTextStyle.alignment = TextAnchor.MiddleCenter;
        guiButtonStyle.alignment = TextAnchor.MiddleCenter;
    }

    public void OnGUI()
    {
        GUI.Label(new Rect(0, Screen.height / 2 - 150f, Screen.width, 50f), "[ выбор игры ]", guiTextStyle);

        if (GUI.Button(new Rect(0, Screen.height / 2 - 50f, Screen.width, 50f), "[ новая игра ]", guiButtonStyle))
        {
            SceneManager.LoadScene("Level1");
        }
        if (GUI.Button(new Rect(0, Screen.height / 2, Screen.width, 50f), "[ продолжить ]", guiButtonStyle))
        {
            Game.Load();
            SceneManager.LoadScene("MainMenu");
        }
        if (GUI.Button(new Rect(0, Screen.height / 2 + 50f, Screen.width, 50f), "[ выйти из игры ]", guiButtonStyle))
        {
            Application.Quit();
        }
    }
}
