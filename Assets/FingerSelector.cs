using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerSelector : MonoBehaviour
{
    


    private Sprite fingerPainted;

    [SerializeField]
    private List<SpriteRenderer> fingers = new List<SpriteRenderer>();
    //list of fingers and their sprite renderers

    private int currentOption = 0;
    [SerializeField]
    private Vector3 startpos;

    [SerializeField]
    private Vector3 endpos;

   public List<Sprite> fingerPaint = new List<Sprite>();

    private void Start()
    {
        this.transform.position = startpos;
        fingerPainted = fingerPaint[PlayerPrefs.GetInt("nails")];

    }

    private void Update()
    {
        //this code is similar to the next and previous button code but
        //cannibalized for the finger minigame instead

        //arrow movement controls

        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            this.transform.position = this.transform.position + new Vector3(2, 0, 0);
            //move the arrow when you press the arrow keys

            currentOption++;

            if (currentOption >= fingers.Count)
            {
                currentOption = 0; //Reset if cycled through entire list
                this.transform.position = startpos; //go to the first position
            }
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position = this.transform.position - new Vector3(2, 0, 0);

            currentOption--;

            if (currentOption < 0)
            {
                currentOption = fingers.Count - 1; //Reset if cycled through entire list
                this.transform.position = endpos;
            }
           
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
          
            //change the finger to painted that the arrow is currently hovering over

               fingers[currentOption].sprite = fingerPainted;
            
        }
    }
}
