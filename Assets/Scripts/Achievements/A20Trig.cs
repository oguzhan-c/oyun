using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A20Trig : MonoBehaviour
{
    public GameObject AchUI;
    public int lifeCount;
    public bool checkLifeCount;
    public bool startTracking;

    void Update()
    {
        if (checkLifeCount == false)
        {
            checkLifeCount = true;
            StartCoroutine(CheckLife());
        }
        if (startTracking == true)
        {
            if (GlobalAchievements.A20 == 0 && lifeCount == 0)
            {
                GlobalAchievements.A20 = 1;
                GlobalAchievements.saveAchievements = true;
                GlobalAchDisplay.refreshAch = true;
                StartCoroutine(ActivateAch());
            }
        }
    }

    void Start()
    {
        StartCoroutine(StartTrack());
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

    IEnumerator StartTrack()
    {
        yield return new WaitForSeconds(1);
        startTracking = true;
    }
}
