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
        //int Scenenum = SceneManager.GetActiveScene().buildIndex;
        //Debug.Log(Scenenum);
        SceneManager.LoadScene(sceneBuildIndex: scenenum);
        
    }
public void SceneChangeBack()
    {
        //int Scenenum = SceneManager.GetActiveScene().buildIndex;
        //Debug.Log(scenenum);
        SceneManager.LoadScene(sceneBuildIndex: 0);
        
    }
}
