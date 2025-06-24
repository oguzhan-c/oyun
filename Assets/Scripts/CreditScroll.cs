using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditScroll : MonoBehaviour
{

    public float scrollSpeed;

    void Start()
    {
        scrollSpeed = CreditControl.canvasSize * 94;
    }

    void Update()
    {

        transform.Translate(Vector3.up * Time.deltaTime * scrollSpeed);
    }
}
