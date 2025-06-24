using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    //xbox buttons
    public GameObject mainAButton;
    public GameObject mainXButton;
    public GameObject mainYButton;
    public GameObject mainBButton;
    public GameObject achBButton;
    public GameObject storeAButton;
    public GameObject storeXButton;
    public GameObject storeYButton;
    public GameObject storeBButton;
    public GameObject storeLBButton;
    public GameObject storeRBButton;
    public GameObject storeLTButton;
    public GameObject storeRTButton;
    public GameObject storeL3Button;
    public GameObject storeR3Button;

    //playstation buttons
    public GameObject mainSquareButton;
    public GameObject mainCircleButton;
    public GameObject mainTriangleButton;
    public GameObject mainCrossButton;
    public GameObject achCrossButton;
    public GameObject storeCrossButton;
    public GameObject storeSquareButton;
    public GameObject storeTriangleButton;
    public GameObject storeCircleButton;
    public GameObject storeL1Button;
    public GameObject storeR1Button;
    public GameObject storeL2Button;
    public GameObject storeR2Button;
    public GameObject storeShareButton;
    public GameObject storeOptButton;

    //attributes
    public GameObject mapText;
    public GameObject selectSlider;
    public GameObject xboxText;
    public GameObject psText;


    public static int menuLocation; //0=main, 1=achievements, 2=store

    void Update()
    {
        if (TestJoys.joyOn == true)
        {
            if (TestJoys.layoutSet == 1)
            {
                mainSquareButton.SetActive(true);
                mainCircleButton.SetActive(true);
                mainTriangleButton.SetActive(true);
                mainCrossButton.SetActive(true);
                achCrossButton.SetActive(true);
                storeCrossButton.SetActive(true);
                storeSquareButton.SetActive(true);
                storeTriangleButton.SetActive(true);
                storeCircleButton.SetActive(true);
                storeLBButton.SetActive(true);
                storeRBButton.SetActive(true);
                storeLTButton.SetActive(true);
                storeRTButton.SetActive(true);
                storeL1Button.GetComponent<Text>().text = "L1";
                storeR1Button.GetComponent<Text>().text = "R1";
                storeL2Button.GetComponent<Text>().text = "L2";
                storeR2Button.GetComponent<Text>().text = "R2";
                storeR1Button.GetComponent<Text>().text = "R1";
                storeL2Button.GetComponent<Text>().text = "L2";
                storeR2Button.GetComponent<Text>().text = "R2";
                storeShareButton.SetActive(true);
                storeOptButton.SetActive(true);
                storeL3Button.SetActive(false);
                storeR3Button.SetActive(false);
            }
            else
            {
                mainAButton.SetActive(true);
                mainXButton.SetActive(true);
                mainYButton.SetActive(true);
                mainBButton.SetActive(true);
                achBButton.SetActive(true);
                storeAButton.SetActive(true);
                storeXButton.SetActive(true);
                storeYButton.SetActive(true);
                storeBButton.SetActive(true);
                storeLBButton.SetActive(true);
                storeRBButton.SetActive(true);
                storeLTButton.SetActive(true);
                storeRTButton.SetActive(true);
                storeL3Button.SetActive(true);
                storeR3Button.SetActive(true);
                mainSquareButton.SetActive(false);
                mainCircleButton.SetActive(false);
                mainTriangleButton.SetActive(false);
                mainCrossButton.SetActive(false);
                achCrossButton.SetActive(false);
                storeCrossButton.SetActive(false);
                storeSquareButton.SetActive(false);
                storeTriangleButton.SetActive(false);
                storeCircleButton.SetActive(false);
                storeL1Button.GetComponent<Text>().text = "LB";
                storeR1Button.GetComponent<Text>().text = "RB";
                storeL2Button.GetComponent<Text>().text = "LT";
                storeR2Button.GetComponent<Text>().text = "RT";
                storeShareButton.SetActive(false);
                storeOptButton.SetActive(false);
            }
            mapText.SetActive(true);
            selectSlider.SetActive(true);
            xboxText.SetActive(true);
            psText.SetActive(true);
        }
        else
        {
            mainAButton.SetActive(false);
            mainXButton.SetActive(false);
            mainYButton.SetActive(false);
            mainBButton.SetActive(false);
            achBButton.SetActive(false);
            storeAButton.SetActive(false);
            storeXButton.SetActive(false);
            storeYButton.SetActive(false);
            storeBButton.SetActive(false);
            storeLBButton.SetActive(false);
            storeRBButton.SetActive(false);
            storeLTButton.SetActive(false);
            storeRTButton.SetActive(false);
            storeL3Button.SetActive(false);
            storeR3Button.SetActive(false);
            mapText.SetActive(false);
            selectSlider.SetActive(false);
            xboxText.SetActive(false);
            psText.SetActive(false);
            mainSquareButton.SetActive(false);
            mainCircleButton.SetActive(false);
            mainTriangleButton.SetActive(false);
            mainCrossButton.SetActive(false);
            achCrossButton.SetActive(false);
            storeCrossButton.SetActive(false);
            storeSquareButton.SetActive(false);
            storeTriangleButton.SetActive(false);
            storeCircleButton.SetActive(false);
            storeShareButton.SetActive(false);
            storeOptButton.SetActive(false);
        }
    }
}
