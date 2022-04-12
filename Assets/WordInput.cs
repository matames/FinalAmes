using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public WordManager wordManager;


    void Update()
    {
       
        foreach (char letter in Input.inputString)  //returns keyboard input
            
        {
            wordManager.TypeLetter(letter);

        }
    }
}
