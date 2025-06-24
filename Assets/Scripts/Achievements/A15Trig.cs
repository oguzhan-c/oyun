using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A15Trig : MonoBehaviour
{
    public GameObject AchUI;
    public int testac;

    void Start()
    {
        testac = GlobalAchievements.A15;
        if (GlobalAchievements.A15 == 0 && StageSelect.charPlayingAs == 4)
        {
            GlobalAchievements.A15 = 1;
            GlobalAchievements.saveAchievements = true;
            StartCoroutine(ActivateAch());
        }
    }

    IEnumerator ActivateAch()
    {
        yield return new WaitForSeconds(7);
        AchUI.SetActive(true);
        yield return new WaitForSeconds(4);
        AchUI.SetActive(false);
    }
}
