using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A05Trig : MonoBehaviour
{
    public GameObject AchUI;
    public int distanceRan;
    public bool startTracking;

    void Start()
    {
        StartCoroutine(TrackAch());
    }

    void Update()
    {
        distanceRan = GlobalScore.distanceLookUp;
        if (startTracking == true)
        {
            if (GlobalAchievements.A05 == 0 && distanceRan > 599)
            {
                GlobalAchievements.A05 = 1;
                GlobalAchievements.saveAchievements = true;
                GlobalAchDisplay.refreshAch = true;
                StartCoroutine(ActivateAch());
            }
        }
    }

    IEnumerator ActivateAch()
    {
        yield return new WaitForSeconds(1);
        AchUI.SetActive(true);
        yield return new WaitForSeconds(4);
        AchUI.SetActive(false);
    }

    IEnumerator TrackAch()
    {
        yield return new WaitForSeconds(5);
        startTracking = true;
    }

}
