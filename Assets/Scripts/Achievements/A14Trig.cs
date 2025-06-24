using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A14Trig : MonoBehaviour
{
    public GameObject AchUI;

    void Start()
    {
        if (GlobalAchievements.A14 == 0 && StageSelect.charPlayingAs == 3)
        {
            GlobalAchievements.A14 = 1;
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
