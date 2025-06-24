using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftText : MonoBehaviour
{
    public GameObject textUI;

    void Start()
    {
        StartCoroutine(TextFlash());
    }

    IEnumerator TextFlash()
    {
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        textUI.SetActive(true);
    }

}
