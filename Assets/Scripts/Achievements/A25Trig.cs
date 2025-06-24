using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A25Trig : MonoBehaviour
{
    public GameObject AchUI;
    public static int secondsCounted;
    public int internalCounted;
    public bool countSec;

    void Update()
    {
        internalCounted = secondsCounted;
        if (countSec == false && GlobalCollisionDetect.hasCollided == false)
        {
            countSec = true;
            StartCoroutine(CountASec());
        }

        if (GlobalAchievements.A25 == 0 && internalCounted > 1985)
        {
            GlobalAchievements.A25 = 1;
            GlobalAchievements.saveAchievements = true;
            StartCoroutine(ActivateAch());
        }
    }

    IEnumerator ActivateAch()
    {
        yield return new WaitForSeconds(2);
        AchUI.SetActive(true);
        yield return new WaitForSeconds(4);
        AchUI.SetActive(false);
    }

    IEnumerator CountASec()
    {
        yield return new WaitForSeconds(1);
        secondsCounted += 1;
        countSec = false;
    }
}
