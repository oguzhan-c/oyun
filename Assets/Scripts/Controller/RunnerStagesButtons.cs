using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerStagesButtons : MonoBehaviour
{
    public GameObject stageAButton;
    public GameObject stageSquareButton;
    public bool isControl;

    void Update()
    {
        isControl = TestJoys.joyOn;
        if (TestJoys.joyOn == true)
        {
            if (TestJoys.layoutSet == 1)
            {
                stageSquareButton.SetActive(true);
            }
            else
            {
                stageAButton.SetActive(true);
            }
        }
        else
        {
            stageAButton.SetActive(false);
            stageSquareButton.SetActive(false);
        }
    }
}
