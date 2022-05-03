using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameInput : MonoBehaviour
{
    private string nameofPlayer;
    private string saveName;


    [SerializeField]
    private TextMeshProUGUI inputText;
    [SerializeField]
    private TextMeshProUGUI loadedName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nameofPlayer = PlayerPrefs.GetString("name", "your name here");
        loadedName.text = nameofPlayer;
    }

    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
    }
}

