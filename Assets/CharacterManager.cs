using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterManager: MonoBehaviour
{
    private GameObject[] character;

    private void Start()
    {
        character = GameObject.FindGameObjectsWithTag("Character");
    }
    // Update is called once per frame
    void Update()
    {
        /*
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            foreach (GameObject player in character) {
                player.SetActive(false);
            }
        }

        else
        {
            foreach (GameObject player in character)
            {
                player.SetActive(true);
            }

        }
        */
    }
}
