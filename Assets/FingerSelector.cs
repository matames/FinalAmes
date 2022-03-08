using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerSelector : MonoBehaviour
{
    [SerializeField]
    private Sprite fingerpainted;

    [SerializeField]
    private List<SpriteRenderer> fingers = new List<SpriteRenderer>();
    // Start is called before the first frame update
    private int currentOption = 0;
    [SerializeField]
    private Vector3 startpos;

    [SerializeField]
    private Vector3 endpos;

    private void Start()
    {
        this.transform.position = startpos;
    }

    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            this.transform.position = this.transform.position + new Vector3(2, 0, 0);

            currentOption++;

            if (currentOption >= fingers.Count)
            {
                currentOption = 0; //Reset if cycled through entire list
                this.transform.position = startpos;
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
          
           
               fingers[currentOption].sprite = fingerpainted;
            
        }
    }
}
