using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A04Trig : MonoBehaviour
{
    public GameObject AchUI;
    public int lifeCount;
    public bool checkLifeCount;

    void Update()
    {
        if (checkLifeCount == false)
        {
            checkLifeCount = true;
            StartCoroutine(CheckLife());
        }
        if (GlobalAchievements.A04 == 0 && lifeCount > 98)
        {
            GlobalAchievements.A04 = 1;
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

    IEnumerator CheckLife()
    {
        yield return new WaitForSeconds(1);
        lifeCount = PlayerPrefs.GetInt("LifeCount");
        checkLifeCount = false;
    }
}
