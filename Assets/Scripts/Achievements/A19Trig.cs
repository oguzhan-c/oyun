using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A19Trig : MonoBehaviour
{
    public GameObject AchUI;
    public int coinTotal;

    void Update()
    {
        coinTotal = GlobalCoinsGems.coinCount;
        if (GlobalAchievements.A19 == 0 && coinTotal == 42 && ManholeDrop.inManhole == true)
        {
            GlobalAchievements.A19 = 1;
            GlobalAchievements.saveAchievements = true;
            StartCoroutine(ActivateAch());
        }
    }

    IEnumerator ActivateAch()
    {
        yield return new WaitForSeconds(0.5f);
        AchUI.SetActive(true);
        yield return new WaitForSeconds(4);
        AchUI.SetActive(false);
    }
}
