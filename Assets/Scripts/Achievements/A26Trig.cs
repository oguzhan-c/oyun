using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A26Trig : MonoBehaviour
{
    public GameObject AchUI;
    public static bool openChest;

    void Update()
    {
        if (GlobalAchievements.A26 == 0 && openChest == true)
        {
            GlobalAchievements.A26 = 1;
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
