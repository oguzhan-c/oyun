using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimmyTrack : MonoBehaviour
{
    public static bool isOn;

    void Start()
    {
        isOn = true;
        RewardTrack.timmyCount += 1;
        RewardTrack.saveStats = true;
    }

}
