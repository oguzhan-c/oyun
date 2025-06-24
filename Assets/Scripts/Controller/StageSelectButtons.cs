using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectButtons : MonoBehaviour
{
    //xbox
    public GameObject stageAButton;
    public GameObject stageLBButton;
    public GameObject stageRBButton;
    public GameObject charAButton;
    public GameObject charXButton;
    public GameObject charYButton;
    public GameObject charBButton;
    public GameObject charRBButton;
    public GameObject specialAButton;
    public GameObject specialLBButton;
    public GameObject specialRBButton;
    public GameObject extraAButton;
    public GameObject extraLBButton;
    public GameObject extraRBButton;

    //playstation
    public GameObject stageSquareButton;
    public GameObject charSquareButton;
    public GameObject charCircleButton;
    public GameObject charTriangleButton;
    public GameObject charCrossButton;
    public GameObject charR1Button;
    public GameObject specialSquareButton;
    public GameObject specialL1Button;
    public GameObject specialR1Button;
    public GameObject stageL1Button;
    public GameObject stageR1Button;
    public GameObject extraSquareButton;
    public GameObject extraL1Button;
    public GameObject extraR1Button;

    public bool isControl;

    void Update()
    {
        //isControl = TestJoys.joyOn;
        if (TestJoys.joyOn == true)
        {
            if (TestJoys.layoutSet == 1)
            {
                stageLBButton.SetActive(true);
                stageRBButton.SetActive(true);
                stageSquareButton.SetActive(true);
                charSquareButton.SetActive(true);
                charCircleButton.SetActive(true);
                charTriangleButton.SetActive(true);
                charCrossButton.SetActive(true);
                charRBButton.SetActive(true);
                stageL1Button.GetComponent<Text>().text = "L1";
                stageR1Button.GetComponent<Text>().text = "R1";
                charR1Button.GetComponent<Text>().text = "R1";
                specialSquareButton.SetActive(true);
                specialL1Button.GetComponent<Text>().text = "L1";
                specialR1Button.GetComponent<Text>().text = "R1";
                extraL1Button.GetComponent<Text>().text = "L1";
                extraR1Button.GetComponent<Text>().text = "R1";
                extraLBButton.SetActive(true);
                extraRBButton.SetActive(true);
                extraSquareButton.SetActive(true);
            }
            else
            {
                stageAButton.SetActive(true);
                stageLBButton.SetActive(true);
                stageRBButton.SetActive(true);
                charAButton.SetActive(true);
                charXButton.SetActive(true);
                charYButton.SetActive(true);
                charBButton.SetActive(true);
                charRBButton.SetActive(true);
                specialAButton.SetActive(true);
                specialLBButton.SetActive(true);
                specialRBButton.SetActive(true);
                stageL1Button.GetComponent<Text>().text = "LB";
                stageR1Button.GetComponent<Text>().text = "RB";
                charR1Button.GetComponent<Text>().text = "RB";
                specialL1Button.GetComponent<Text>().text = "LB";
                specialR1Button.GetComponent<Text>().text = "RB";
                extraL1Button.GetComponent<Text>().text = "LB";
                extraR1Button.GetComponent<Text>().text = "RB";
                extraLBButton.SetActive(true);
                extraRBButton.SetActive(true);
                extraAButton.SetActive(true);
            }

        }
        else
        {
            stageAButton.SetActive(false);
            stageLBButton.SetActive(false);
            stageRBButton.SetActive(false);
            charAButton.SetActive(false);
            charXButton.SetActive(false);
            charYButton.SetActive(false);
            charBButton.SetActive(false);
            charRBButton.SetActive(false);
            specialAButton.SetActive(false);
            specialLBButton.SetActive(false);
            specialRBButton.SetActive(false);
            stageSquareButton.SetActive(false);
            charSquareButton.SetActive(false);
            charCircleButton.SetActive(false);
            charTriangleButton.SetActive(false);
            charCrossButton.SetActive(false);
            specialSquareButton.SetActive(false);
            extraLBButton.SetActive(false);
            extraRBButton.SetActive(false);
            extraSquareButton.SetActive(false);
        }
    }
}
