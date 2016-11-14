using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevelGUI : MonoBehaviour
{
    public GUIStyle guiButtonStyle = new GUIStyle();
    public GUIStyle guiArrowLeftStyle = new GUIStyle();
    public GUIStyle guiArrowRightStyle = new GUIStyle();

    GUIStyle guiTextStyle = new GUIStyle();

    void Awake()
    {
        guiTextStyle.font = guiButtonStyle.font;
        guiTextStyle.fontSize = 40;
        guiTextStyle.normal.textColor = new Color(0.4F, 0.4F, 0.4F);
    }

    public void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 120f, Screen.height / 2 - 220f, 240f, 50f), "[ выбор уровня ]", guiTextStyle);

        if (GUI.Button(new Rect(Screen.width / 2 - 160f, Screen.height / 2 - 160f, 100f, 100f), "1", guiButtonStyle))
        {
            SceneManager.LoadScene("Level1");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 50f, Screen.height / 2 - 160f, 100f, 100f), "2", guiButtonStyle))
        {
            SceneManager.LoadScene("Level2");
        }
        if (GUI.Button(new Rect(Screen.width / 2 + 60f, Screen.height / 2 - 160f, 100f, 100f), "3", guiButtonStyle))
        {
            SceneManager.LoadScene("Level3");
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 160f, Screen.height / 2 - 50f, 100f, 100f), "4", guiButtonStyle))
        {
            SceneManager.LoadScene("Level4");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 50f, Screen.height / 2 - 50f, 100f, 100f), "5", guiButtonStyle))
        {
            SceneManager.LoadScene("Level5");
        }
        if (GUI.Button(new Rect(Screen.width / 2 + 60f, Screen.height / 2 - 50f, 100f, 100f), "6", guiButtonStyle))
        {
            SceneManager.LoadScene("Level6");
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 160f, Screen.height / 2 + 60f, 100f, 100f), "7", guiButtonStyle))
        {
            SceneManager.LoadScene("Level7");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 50f, Screen.height / 2 + 60f, 100f, 100f), "8", guiButtonStyle))
        {
            SceneManager.LoadScene("Level8");
        }
        if (GUI.Button(new Rect(Screen.width / 2 + 60f, Screen.height / 2 + 60f, 100f, 100f), "9", guiButtonStyle))
        {
            SceneManager.LoadScene("Level9");
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 340f, Screen.height / 2 - 50f, 100f, 100f),"", guiArrowLeftStyle))
        {
            SceneManager.LoadScene("SwitchGame");
        }
        if (GUI.Button(new Rect(Screen.width / 2 + 210f, Screen.height / 2 - 50f, 100f, 100f), "", guiArrowRightStyle))
        {
            Game.Load();
        }
    }
}
