using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmetScript : MonoBehaviour
{
    public Animator anim;
    public int struggle = 0;

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetKeyDown(KeyCode.UpArrow) && struggle < 4)
        {
            anim.SetBool("isStruggle", true);
            struggle++;

        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetBool("isStruggle", false);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && struggle == 4)
        {
            anim.SetBool("isNoHelmet", true);
        }

    }
}
