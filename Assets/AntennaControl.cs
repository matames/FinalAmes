using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntennaControl : MonoBehaviour
{
    private float degreesPerSecond = 100;

    public Color targetColor = new Color(1f, 1f, 1f, 0f);

    public Color targetColor2 = new Color(1f, 1f, 1f, .5f);

    public Color startcolor = new Color(1f, 1f, 1f, 1f);

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LerpFunction(startcolor, 2));
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
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
        StopAllCoroutines();
        Debug.Log("triggerexit");
        StartCoroutine(LerpFunction(startcolor, 2));
        //spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
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
        //spriteRenderer.color = endValue;
    }
}