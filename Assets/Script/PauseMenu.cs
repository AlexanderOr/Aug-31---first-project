using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;


    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
    }


    public void TogglePause()
    {
        if (isPaused)
        {
            //unpause
            Time.timeScale = 1;

            pauseUI.SetActive(false);
        }
        else
        {
            //pause
            Time.timeScale = 0;

            pauseUI.SetActive(true);
        }

        isPaused = !isPaused;
    }

    public void Quit()
    {
        Application.Quit();
    }


}
