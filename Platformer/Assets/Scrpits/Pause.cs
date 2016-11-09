using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            if (!Data.Paused)
            {
                Time.timeScale = 0;
                Data.Paused = true;
            }
            else
            {
                Time.timeScale = 1;
                Data.Paused = false;
            }
    }
}
