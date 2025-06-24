using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAchDisplay : MonoBehaviour
{
    public GameObject ach01;
    public GameObject ach02;
    public GameObject ach03;
    public GameObject ach04;
    public GameObject ach05;
    public GameObject ach06;
    public GameObject ach07;
    public GameObject ach08;
    public GameObject ach09;
    public GameObject ach10;
    public GameObject ach11;
    public GameObject ach12;
    public GameObject ach13;
    public GameObject ach14;
    public GameObject ach15;
    public GameObject ach16;
    public GameObject ach17;
    public GameObject ach18;
    public GameObject ach19;
    public GameObject ach20;
    public GameObject ach21;
    public GameObject ach22;
    public GameObject ach23;
    public GameObject ach24;
    public GameObject ach25;
    public GameObject ach26;
    public GameObject ach27;
    public GameObject totalAchCount;
    public static bool refreshAch;

    void Update()
    {
        if (refreshAch == true)
        {
            refreshAch = false;
            StartCoroutine(LoadAchievements());
        }
    }

    void Start()
    {
        StartCoroutine(LoadAchievements());
    }

    IEnumerator LoadAchievements()
    {
        yield return new WaitForSeconds(1);
        if (GlobalAchievements.A01 == 1)
        {
            ach01.SetActive(true);
        }
        if (GlobalAchievements.A02 == 1)
        {
            ach02.SetActive(true);
        }
        if (GlobalAchievements.A03 == 1)
        {
            ach03.SetActive(true);
        }
        if (GlobalAchievements.A04 == 1)
        {
            ach04.SetActive(true);
        }
        if (GlobalAchievements.A05 == 1)
        {
            ach05.SetActive(true);
        }
        if (GlobalAchievements.A06 == 1)
        {
            ach06.SetActive(true);
        }
        if (GlobalAchievements.A07 == 1)
        {
            ach07.SetActive(true);
        }
        if (GlobalAchievements.A08 == 1)
        {
            ach08.SetActive(true);
        }
        if (GlobalAchievements.A09 == 1)
        {
            ach09.SetActive(true);
        }
        if (GlobalAchievements.A10 == 1)
        {
            ach10.SetActive(true);
        }
        if (GlobalAchievements.A11 == 1)
        {
            ach11.SetActive(true);
        }
        if (GlobalAchievements.A12 == 1)
        {
            ach12.SetActive(true);
        }
        if (GlobalAchievements.A13 == 1)
        {
            ach13.SetActive(true);
        }
        if (GlobalAchievements.A14 == 1)
        {
            ach14.SetActive(true);
        }
        if (GlobalAchievements.A15 == 1)
        {
            ach15.SetActive(true);
        }
        if (GlobalAchievements.A16 == 1)
        {
            ach16.SetActive(true);
        }
        if (GlobalAchievements.A17 == 1)
        {
            ach17.SetActive(true);
        }
        if (GlobalAchievements.A18 == 1)
        {
            ach18.SetActive(true);
        }
        if (GlobalAchievements.A19 == 1)
        {
            ach19.SetActive(true);
        }
        if (GlobalAchievements.A20 == 1)
        {
            ach20.SetActive(true);
        }
        if (GlobalAchievements.A21 == 1)
        {
            ach21.SetActive(true);
        }
        if (GlobalAchievements.A22 == 1)
        {
            ach22.SetActive(true);
        }
        if (GlobalAchievements.A23 == 1)
        {
            ach23.SetActive(true);
        }
        if (GlobalAchievements.A24 == 1)
        {
            ach24.SetActive(true);
        }
        if (GlobalAchievements.A25 == 1)
        {
            ach25.SetActive(true);
        }
        if (GlobalAchievements.A26 == 1)
        {
            ach26.SetActive(true);
        }
        if (GlobalAchievements.A27 == 1)
        {
            ach27.SetActive(true);
        }
        totalAchCount.GetComponent<Text>().text = GlobalAchievements.totalAch + "/27 Achievements Unlocked";
    }
}
