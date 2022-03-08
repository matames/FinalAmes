using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField]
    //scene you want this button to change to
    private int scenenum;

public void SceneChange()
    {
        SceneManager.LoadScene(sceneBuildIndex: scenenum);
        
    }
public void SceneChangeBack()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
        
    }

public void Ending()
    {
        SceneManager.LoadScene(sceneBuildIndex: 4);
    }
}
