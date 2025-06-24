using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyFlap : MonoBehaviour
{
    public float forwardMove = 1.5f;
    public float upwardMove = 0.5f;
    public int butterflyNumber;
    public GameObject[] butterflies;

    void Start()
    {
        butterflyNumber = Random.Range(0, 4);
        butterflies[butterflyNumber].SetActive(true);
    }


    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * forwardMove);
        transform.Translate(Vector3.up * Time.deltaTime * upwardMove);
    }
}
