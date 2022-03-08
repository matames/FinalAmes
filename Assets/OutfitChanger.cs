using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutfitChanger : MonoBehaviour
{
    // Sprite to Change
    [SerializeField]
    private SpriteRenderer bodyPart;

    //Sprites to Cycle Through
    [SerializeField]
    private List<Sprite> options = new List<Sprite>();

    [SerializeField]
    private Button NextButton;
    [SerializeField]
    private Button PreviousButton;

    [SerializeField]
    private SceneInfo sceneInfo;

    [SerializeField]
    private GameObject Character;

    //Prevous and next button functions
    //based on code used here
    //https://www.youtube.com/watch?v=kAPIWJJ6NQI&ab_channel=BMo

    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if(currentOption >= options.Count)
        {
            currentOption = 0; //Reset if cycled through entire list 
        }
        bodyPart.sprite = options[currentOption];
    }

    public void PreviousOption()
    {
        currentOption--;
        if(currentOption < 0)
        {
            currentOption = options.Count - 1; //Reset if cycled through entire list 
        }
        bodyPart.sprite = options[currentOption];
    }
    
    public void ConfirmOption() 
    {
        Character.GetComponent<Character>().SetSprites(); //set the sprites in Character

        //** This next part doesn't fully work but when I continue to work on
        //it this will grey out the previous and next buttons once you hit confirm**//

        if (NextButton.enabled)
        {  
            NextButton.enabled = false;

            ColorBlock nextcolor = NextButton.colors;
            nextcolor.normalColor = Color.grey;
            NextButton.colors = nextcolor;

            PreviousButton.enabled = false;

            ColorBlock prevcolor = PreviousButton.colors;
            prevcolor.normalColor = Color.grey;
            PreviousButton.colors = prevcolor;
        }
        else
        {
            NextButton.enabled = true;
            ColorBlock nextcolor = NextButton.colors;
            nextcolor.normalColor = Color.white;
            NextButton.colors = nextcolor;

            PreviousButton.enabled = true;
            ColorBlock prevcolor = PreviousButton.colors;
            prevcolor.normalColor = Color.white;
            PreviousButton.colors = prevcolor;
        }
    }
}
