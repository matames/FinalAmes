using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMovement : MonoBehaviour
{
    public Animator anim;

    private float degreesPerSecond = 200;

    void Update()
    {
        //sword movement (same as antenna)
       
        if (Input.GetKey(KeyCode.LeftArrow)) //the sword rotates left when left arrow is held
                                             //and right when the right arrow is held
        {
            this.transform.Rotate(new Vector3(0, 0, degreesPerSecond) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(new Vector3(0, 0, -degreesPerSecond) * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetBool("isDead", true);
    }
}