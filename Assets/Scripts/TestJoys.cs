using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TestJoys : MonoBehaviour
{
    public static bool joyOn;
    public GameObject buttonText;
    public bool controlsEnabled;
    public static int layoutSet; //0=xbox, 1=playstation
    public int internalLayout;

    public void PressTest()
    {
        if (joyOn == false)
        {
            EventSystem.current.SetSelectedGameObject(null);
            joyOn = true;
            buttonText.GetComponent<Text>().text = "CONTROLLER ON";
            PlayerControl.joyTest = true;
        }
        else {
            EventSystem.current.SetSelectedGameObject(null);
            joyOn = false;
            buttonText.GetComponent<Text>().text = "CONTROLLER OFF";
            PlayerControl.joyTest = false;
            }
    }

    void Update()
    {
        internalLayout = layoutSet;
        controlsEnabled = joyOn;
    }

    void Start()
    {
        if (joyOn == true)
        {
            buttonText.GetComponent<Text>().text = "CONTROLLER ON";
        }
        else
        {
            buttonText.GetComponent<Text>().text = "CONTROLLER OFF";
        }
    }



}
