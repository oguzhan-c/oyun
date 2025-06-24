using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseyTrack : MonoBehaviour
{
    public static bool isOn;

    void Start()
    {
        isOn = true;
        RewardTrack.mouseyCount += 1;
        RewardTrack.saveStats = true;
    }

}
