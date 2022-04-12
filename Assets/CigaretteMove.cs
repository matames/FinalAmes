using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CigaretteMove : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);

    public ParticleSystem system;

    public Animator anim;

    private void Start()
    {
        system.Pause();
    }
    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triggered");
        anim.enabled = true;
        anim.SetBool("IsSmoking",true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exited");
        system.Play();
        anim.enabled = false;
    }
}
