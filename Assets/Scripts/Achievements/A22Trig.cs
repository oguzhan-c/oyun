using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A22Trig : MonoBehaviour
{
    public GameObject AchUI;
    public bool movedSide;
    public bool trackStart;

    private void Start()
    {
        StartCoroutine(StartTracking());
    }

    void Update()
    {
        if (trackStart == true)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || (Input.GetAxis("Horizontal") < 0) || (Input.GetAxis("Horizontal") > 0))
            {
                movedSide = true;
            }
            if (GlobalAchievements.A22 == 0 && GlobalScore.distanceLookUp > 49 && movedSide == false)
            {
                GlobalAchievements.A22 = 1;
                GlobalAchievements.saveAchievements = true;
                StartCoroutine(ActivateAch());
            }
        }
    }

    IEnumerator ActivateAch()
    {
        yield return new WaitForSeconds(2);
        AchUI.SetActive(true);
        yield return new WaitForSeconds(4);
        AchUI.SetActive(false);
    }

    IEnumerator StartTracking()
    {
        yield return new WaitForSeconds(5);
        trackStart = true;
    }
}
