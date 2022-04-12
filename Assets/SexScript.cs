using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SexScript : MonoBehaviour
{
    [SerializeField] private bool isLerpVector3;
    [SerializeField] private Vector3 MytargetPosition;
    [SerializeField] private Vector3 MystartPosition;

    [SerializeField] private Vector3 HertargetPosition;
    [SerializeField] private Vector3 HerstartPosition;

    [SerializeField] GameObject myBody;
    [SerializeField] GameObject HerBody;

    [SerializeField] private float speed;
    Coroutine Myco1;
    Coroutine Myco2;

    Coroutine Herco1;
    Coroutine Herco2;

    private void Start()
    {
        //body starts moving apart
        Myco1 = StartCoroutine(Vector3LerpCoroutine(myBody, MytargetPosition, speed));
        Herco1 = StartCoroutine(Vector3LerpCoroutine(HerBody, HertargetPosition, speed));
    }


    void Update()
    {
        //body movement controls

        if (Input.GetKeyDown(KeyCode.RightArrow))
        { //if you press up the body goes back together
            StopCoroutine(Myco1);
            StopCoroutine(Herco1);
            Myco2 = StartCoroutine(Vector3LerpCoroutine(myBody, MystartPosition, speed));
            Herco2 = StartCoroutine(Vector3LerpCoroutine(HerBody, HerstartPosition, speed));

        }
        if (Input.GetKeyUp(KeyCode.RightArrow)) //if you stop holding up it goes apart again
        {
            StopCoroutine(Myco2);
            StopCoroutine(Herco2);
            Myco1 = StartCoroutine(Vector3LerpCoroutine(myBody, MytargetPosition, speed));
            Herco1 = StartCoroutine(Vector3LerpCoroutine(HerBody, HertargetPosition, speed));

        }
    }

    IEnumerator Vector3LerpCoroutine(GameObject obj, Vector3 target, float speed)
    {
        Vector3 startPosition = obj.transform.position;

        float time = 0f;

        while (obj.transform.position != target)
        {
            obj.transform.position = Vector3.Lerp(startPosition, target, (time / Vector3.Distance(startPosition, target)) * speed);
            time += Time.deltaTime;
            yield return null;
        }
    }

}

