using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A24Trig : MonoBehaviour
{
    public GameObject AchUI;
    public int coinTotal;
    public bool startTracking;
    public int distanceGone;

    void Start()
    {
        StartCoroutine(CommenceTracker());
    }
    void Update()
    {
        coinTotal = GlobalCoinsGems.coinCount;
        distanceGone = GlobalScore.distanceLookUp;
        if (startTracking == true)
        {
            if (GlobalAchievements.A24 == 0 && coinTotal == 0 && GlobalScore.distanceLookUp > 399)
            {
                GlobalAchievements.A24 = 1;
                GlobalAchievements.saveAchievements = true;
                StartCoroutine(ActivateAch());
            }
        }
    }

    IEnumerator ActivateAch()
    {
        yield return new WaitForSeconds(2);
        AchUI.SetActive(true);
        yield return new WaitForSeconds(4);
        AchUI.SetActive(false);
    }

    IEnumerator CommenceTracker()
    {
        yield return new WaitForSeconds(5);
        startTracking = true;
    }
}
