using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A02Trig : MonoBehaviour
{
    public GameObject AchUI;
    public int coinCount;

    void Start()
    {
        StartCoroutine(CheckCoins());
    }

    void Update()
    {
        if (GlobalAchievements.A02 == 0 && coinCount > 9999)
        {
            GlobalAchievements.A02 = 1;
            GlobalAchievements.saveAchievements = true;
            GlobalAchDisplay.refreshAch = true;
            StartCoroutine(ActivateAch());
        }
    }

    IEnumerator ActivateAch()
    {
        yield return new WaitForSeconds(1);
        AchUI.SetActive(true);
        yield return new WaitForSeconds(4);
        AchUI.SetActive(false);
    }

    IEnumerator CheckCoins()
    {
        yield return new WaitForSeconds(1);
        coinCount = PlayerPrefs.GetInt("TotalCoins");
    }
}
