using UnityEngine;
using System.Collections;

public class CoroutineTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CoroutineExample());

        StopCoroutine(CoroutineExample());

        StopAllCoroutines();
    }

    IEnumerator CoroutineExample()
    {
        Debug.Log("Hello");

        yield return new WaitForSeconds(5);

        Debug.Log("Bye");

        yield return CoroutineExample();
    }
}
