using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGUI : MonoBehaviour
{
    public Font font;
    public GUIStyle guiButtonStyle = new GUIStyle();
    public GUIStyle guiBackgroundStyle = new GUIStyle();

    float timer;
    bool isGuiPause;
    GUIStyle guiTextStyle = new GUIStyle();

    void Awake()
    {
        guiTextStyle.font = font;
        guiTextStyle.fontSize = 50;
        guiTextStyle.normal.textColor = new Color(0.2F, 0.2F, 0.2F);
        guiTextStyle.alignment = TextAnchor.MiddleCenter;

        guiButtonStyle.font = font;
        guiButtonStyle.fontSize = 50;
        guiButtonStyle.normal.textColor = new Color(0.4F, 0.4F, 0.4F);
        guiButtonStyle.hover.textColor = new Color(0F, 0F, 0F);
        guiButtonStyle.hover.background = Texture2D.blackTexture;
        guiButtonStyle.alignment = TextAnchor.MiddleCenter;
    }

    void Update()
    {
        Time.timeScale = timer;
        if (Input.GetKeyDown(KeyCode.Escape) && !Data.Paused)
            Data.Paused = true;
        else if (Input.GetKeyDown(KeyCode.Escape) && Data.Paused)
            Data.Paused = false;

        if (Data.Paused)
        {
            timer = 0;
            isGuiPause = true;
        }
        else if (!Data.Paused)
        {
            timer = 1f;
            isGuiPause = false;
        }
    }

    public void OnGUI()
    {
        if (isGuiPause)
        {
            GUI.Box(new Rect(Screen.width / 2 - 200f, 0, 400f, Screen.height),"",guiBackgroundStyle);

            GUI.Label(new Rect(0, Screen.height / 2 - 150f, Screen.width, 45f), "[ пауза ]", guiTextStyle);

            if (GUI.Button(new Rect(0, Screen.height / 2 - 50f, Screen.width, 45f), "[ продолжить ]", guiButtonStyle))
            {
                Data.Paused = false;
                timer = 0;
            }
            if (GUI.Button(new Rect(0, Screen.height / 2, Screen.width, 45f), "[ сохранить ]", guiButtonStyle))
            {
                Game.Save();
            }
            if (GUI.Button(new Rect(0, Screen.height / 2 + 50, Screen.width, 45f), "[ в меню ]", guiButtonStyle))
            {
                Data.Paused = false;
                timer = 0;
                SceneManager.LoadScene("MainMenu");
            }
            if (GUI.Button(new Rect(0, Screen.height / 2 + 100, Screen.width, 45f), "[ выйти из игры ]", guiButtonStyle))
            {
                Application.Quit();
            }
        }
    }
}
