using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTimer : MonoBehaviour
{
    public float targetTime = 60.0f;
    private bool keyPressed = false;
    [SerializeField]
    private int sceneNum = 0;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) // Only start timer when the player presses the up arrow for the first time
        {
            keyPressed = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) // Only start timer when the player presses the up arrow for the first time
        {
            keyPressed = true;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0)) { 

            keyPressed = true;

        }

        if (keyPressed)
        {
            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
        }

        Debug.Log(PlayerPrefs.GetInt("nails"));

    }

    void timerEnded()
    { 
        SceneManager.LoadScene(sceneBuildIndex: sceneNum); //go back to first screen when timer ends
    }
}
