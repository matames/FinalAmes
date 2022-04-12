using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "ames", "yaya", "moss", "mia" ,"amelia", "james", "matty", "mems", "amy",
                                        "mason", "milo", "nico", "micah", "rain", "jet",
                                        "meals","mary", "mirai", "myles", "miles",
                                        "who?", "leo", "ellis", "demetrius", "alice", "marsh", "mac", "elio",
                                        };

    public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
