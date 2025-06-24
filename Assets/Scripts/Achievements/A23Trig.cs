using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A23Trig : MonoBehaviour
{
    public GameObject AchUI;
    public int coinTotal;

    void Update()
    {
        coinTotal = GlobalCoinsGems.coinCount;
        if (GlobalAchievements.A23 == 0 && coinTotal > 249)
        {
            GlobalAchievements.A23 = 1;
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
