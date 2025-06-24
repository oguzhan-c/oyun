using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A01Trig : MonoBehaviour
{
    public GameObject AchUI;
    public int distanceRan;

    void Start()
    {
        distanceRan = PlayerPrefs.GetInt("TotalDistance");
    }

    void Update()
    {

        if (GlobalAchievements.A01 == 0 && distanceRan > 80466)
        {
            GlobalAchievements.A01 = 1;
            GlobalAchievements.saveAchievements = true;
            GlobalAchDisplay.refreshAch = true;
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
