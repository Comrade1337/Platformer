using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGUI : MonoBehaviour
{
    public Font font;

    float timer;
    bool isGuiPause;
    GUIStyle guiTextStyle = new GUIStyle();
    public GUIStyle guiButtonStyle;// = new GUIStyle();

    void Awake()
    {
        guiTextStyle.font = font;
        guiTextStyle.fontSize = 50;
        guiTextStyle.normal.textColor = new Color(0.2F, 0.2F, 0.2F);
                
        guiButtonStyle.font = font;
        guiButtonStyle.fontSize = 45;
    }

    void Update()
    {
        Time.timeScale = timer;
        if (Input.GetKeyDown(KeyCode.Escape) && Data.Paused == false)
            Data.Paused = true;
        else if (Input.GetKeyDown(KeyCode.Escape) && Data.Paused == true)
            Data.Paused = false;

        if (Data.Paused == true)
        {
            timer = 0;
            isGuiPause = true;
        }
        else if (Data.Paused == false)
        {
            timer = 1f;
            isGuiPause = false;
        }
    }
    public void OnGUI()
    {
        if (isGuiPause == true)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75f, Screen.height / 2 - 150f, 150f, 45f), "[ пауза ]", guiTextStyle);

            if (GUI.Button(new Rect(Screen.width / 2 - 120f, Screen.height / 2 - 50f, 260f, 45f), "[ продолжить ]", guiButtonStyle))
            {
                Data.Paused = false;
                timer = 0;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100f, Screen.height / 2, 220f, 45f), "[ сохранить ]", guiButtonStyle))
            {

            }
            if (GUI.Button(new Rect(Screen.width / 2 - 80f, Screen.height / 2 + 50, 180f, 45f), "[ в меню ]", guiButtonStyle))
            {
                Data.Paused = false;
                timer = 0;
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
