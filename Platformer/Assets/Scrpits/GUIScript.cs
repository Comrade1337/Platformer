using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {
    public Font font;
    
    GUIStyle guiStyle = new GUIStyle();

    void Awake()
    {
        guiStyle.font = font;
        guiStyle.fontSize = 25;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), "Score: " + Data.Score + "\n\nStars: " + Data.Stars + "\nLives: " + Data.Lives, guiStyle);
    }

}
