using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A03Trig : MonoBehaviour
{
    public GameObject AchUI;
    public int gemCount;
    public bool checkGemCount;

    void Update()
    {
        if (checkGemCount == false)
        {
            checkGemCount = true;
            StartCoroutine(CheckGems());
        }
        if (GlobalAchievements.A03 == 0 && gemCount > 249)
        {
            GlobalAchievements.A03 = 1;
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

    IEnumerator CheckGems()
    {
        yield return new WaitForSeconds(1);
        gemCount = PlayerPrefs.GetInt("TotalGems");
        checkGemCount = false;
    }
}
