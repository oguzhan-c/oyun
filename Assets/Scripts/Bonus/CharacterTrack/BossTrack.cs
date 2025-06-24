using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrack : MonoBehaviour
{
    public static bool isOn;

    void Start()
    {
        isOn = true;
        RewardTrack.bossCount += 1;
        RewardTrack.saveStats = true;
    }

}
