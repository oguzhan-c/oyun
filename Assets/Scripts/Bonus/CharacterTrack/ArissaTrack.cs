using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArissaTrack : MonoBehaviour
{
    public static bool isOn;

    void Start()
    {
        isOn = true;
        RewardTrack.arissaCount += 1;
        RewardTrack.saveStats = true;
    }

}