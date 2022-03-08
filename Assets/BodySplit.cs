using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySplit : MonoBehaviour
{
    [SerializeField] private bool isLerpVector3;
    [SerializeField] private Vector3 targetPosition;
    [SerializeField] private Vector3 startPosition;

    [SerializeField] private float speed;
    Coroutine co1;
    Coroutine co2;

    private void Start()
    {
        co1 = StartCoroutine(Vector3LerpCoroutine(gameObject, targetPosition, speed));
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            StopCoroutine(co1);
            co2 = StartCoroutine(Vector3LerpCoroutine(gameObject, startPosition, speed));
                
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            StopCoroutine(co2);
            co1 = StartCoroutine(Vector3LerpCoroutine(gameObject, targetPosition, speed));

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
