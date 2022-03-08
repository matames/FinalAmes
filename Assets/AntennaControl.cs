using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntennaControl : MonoBehaviour
{
    private float degreesPerSecond = 100;

    //different levels of opacity for the static

    public Color targetColor = new Color(1f, 1f, 1f, 0f);

    public Color targetColor2 = new Color(1f, 1f, 1f, .5f);

    public Color startcolor = new Color(1f, 1f, 1f, 1f);

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        StartCoroutine(LerpFunction(startcolor, 2));
    }

    void Update()
    {
        //antenna movement

        if (Input.GetKey(KeyCode.LeftArrow)) //the antenna rotates left when left arrow is held
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
        //when the antenna hits a signal the opacity of the static lowers
    
        if (collision.tag == "Signal")
        {
            StopAllCoroutines();
            StartCoroutine(LerpFunction(targetColor, 2));
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(LerpFunction(targetColor2, 2));
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
         //when the antenna exits a signal the static opacity goes back to 100%
        
        StopAllCoroutines();
        StartCoroutine(LerpFunction(startcolor, 2));
}

    IEnumerator LerpFunction(Color endValue, float duration)
    {

        float time = 0;
        Color startValue = spriteRenderer.color;
        while (time < duration)
        {
            spriteRenderer.color = Color.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
    }
}