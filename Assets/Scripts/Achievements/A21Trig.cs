using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A21Trig : MonoBehaviour
{
    public GameObject AchUI;
    public int gemTotal;

    void Update()
    {
        gemTotal = GlobalCoinsGems.gemCount;
        if (GlobalAchievements.A21 == 0 && gemTotal > 6)
        {
            GlobalAchievements.A21 = 1;
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
}
