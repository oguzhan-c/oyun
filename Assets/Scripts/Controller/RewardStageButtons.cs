using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardStageButtons : MonoBehaviour
{
    public GameObject rewardAButton;
    public GameObject rewardXButton;
    public GameObject rewardBButton;
    public GameObject rewardCrossButton;
    public GameObject rewardSquareButton;
    public GameObject rewardCircleButton;
    public bool isControl;

    void Update()
    {
        isControl = TestJoys.joyOn;
        if (TestJoys.joyOn == true)
        {
            if (TestJoys.layoutSet == 1)
            {
                rewardCrossButton.SetActive(true);
                rewardSquareButton.SetActive(true);
                rewardCircleButton.SetActive(true);
            }
            else
            {
                rewardAButton.SetActive(true);
                rewardBButton.SetActive(true);
                rewardXButton.SetActive(true);
            }
        }
        else
        {
            rewardAButton.SetActive(false);
            rewardBButton.SetActive(false);
            rewardXButton.SetActive(false);
            rewardCrossButton.SetActive(false);
            rewardSquareButton.SetActive(false);
            rewardCircleButton.SetActive(false);
        }
    }
}
