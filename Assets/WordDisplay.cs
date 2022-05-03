using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour
{
    private float randomSpeed;
    public TextMeshProUGUI text;
    public SpriteRenderer sprite;

    public ParticleSystem system;

    //[SerializeField]
    //private GameObject bottom;


    [SerializeField]
    private Sprite[] spriteList = { };

    public void Start()
    {
        int randomIndex = Random.Range(0, spriteList.Length);
        Sprite randomSprite = spriteList[randomIndex];

        sprite.sprite = randomSprite;
        randomSpeed = Random.Range(0.5f, 2f);
    }

    public void SetWord(string word)
    {

        text.text = word;
    }

    public void RemoveLetter()
    {
        system.Play();
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        sprite.enabled = false;
        text.enabled = false;
        Destroy(gameObject.GetComponent<BoxCollider2D>());
        //Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -randomSpeed * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Floor")
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
    }
}