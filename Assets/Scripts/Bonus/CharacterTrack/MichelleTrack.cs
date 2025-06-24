using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichelleTrack : MonoBehaviour
{
    public static bool isOn;

    void Start()
    {
        isOn = true;
        RewardTrack.michelleCount += 1;
        RewardTrack.saveStats = true;
    }

}