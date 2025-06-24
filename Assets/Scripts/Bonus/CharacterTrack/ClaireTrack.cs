using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaireTrack : MonoBehaviour
{
    public static bool isOn;

    void Start()
    {
        isOn = true;
        RewardTrack.claireCount += 1;
        RewardTrack.saveStats = true;
    }

}
