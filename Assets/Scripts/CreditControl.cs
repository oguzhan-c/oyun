using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditControl : MonoBehaviour
{

    public Transform theCanvas;
    public static float canvasSize;
    public GameObject fadeOut;
    public GameObject backBButton;
    public GameObject backCrossButton;
    public GameObject backButton;
    public bool buttonPress;

    void Start()
    {
        canvasSize = theCanvas.localScale.y;
        if (TestJoys.joyOn == true)
        {
            if (TestJoys.layoutSet == 1)
            {
                backCrossButton.SetActive(true);
            }
            else
            {
                backBButton.SetActive(true);
            }
        }
        StartCoroutine(FullCredits());
    }

    void Update()
    {
        if (Input.GetButton("Fire3") && buttonPress == false)
        {
            buttonPress = true;
            StartCoroutine(ReturnToMenu());
        }
    }

    public void BackToMenu()
    {
        buttonPress = true;
        StartCoroutine(ReturnToMenu());
    }

    IEnumerator ReturnToMenu()
    {
        fadeOut.SetActive(true);
        backButton.SetActive(false);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }

    IEnumerator FullCredits()
    {
        yield return new WaitForSeconds(29);
        fadeOut.SetActive(true);
        backButton.SetActive(false);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}

