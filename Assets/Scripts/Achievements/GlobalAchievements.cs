using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalAchievements : MonoBehaviour
{
    public static int A01;
    public static int A02;
    public static int A03;
    public static int A04;
    public static int A05;
    public static int A06;
    public static int A07;
    public static int A08;
    public static int A09;
    public static int A10;
    public static int A11;
    public static int A12;
    public static int A13;
    public static int A14;
    public static int A15;
    public static int A16;
    public static int A17;
    public static int A18;
    public static int A19;
    public static int A20;
    public static int A21;
    public static int A22;
    public static int A23;
    public static int A24;
    public static int A25;
    public static int A26;
    public static int A27;
    public static bool saveAchievements;
    public static int totalAch;

    void Start()
    {
        A01 = PlayerPrefs.GetInt("Achievement01");
        A02 = PlayerPrefs.GetInt("Achievement02");
        A03 = PlayerPrefs.GetInt("Achievement03");
        A04 = PlayerPrefs.GetInt("Achievement04");
        A05 = PlayerPrefs.GetInt("Achievement05");
        A06 = PlayerPrefs.GetInt("Achievement06");
        A07 = PlayerPrefs.GetInt("Achievement07");
        A08 = PlayerPrefs.GetInt("Achievement08");
        A09 = PlayerPrefs.GetInt("Achievement09");
        A10 = PlayerPrefs.GetInt("Achievement10");
        A11 = PlayerPrefs.GetInt("Achievement11");
        A12 = PlayerPrefs.GetInt("Achievement12");
        A13 = PlayerPrefs.GetInt("Achievement13");
        A14 = PlayerPrefs.GetInt("Achievement14");
        A15 = PlayerPrefs.GetInt("Achievement15");
        A16 = PlayerPrefs.GetInt("Achievement16");
        A17 = PlayerPrefs.GetInt("Achievement17");
        A18 = PlayerPrefs.GetInt("Achievement18");
        A19 = PlayerPrefs.GetInt("Achievement19");
        A20 = PlayerPrefs.GetInt("Achievement20");
        A21 = PlayerPrefs.GetInt("Achievement21");
        A22 = PlayerPrefs.GetInt("Achievement22");
        A23 = PlayerPrefs.GetInt("Achievement23");
        A24 = PlayerPrefs.GetInt("Achievement24");
        A25 = PlayerPrefs.GetInt("Achievement25");
        A26 = PlayerPrefs.GetInt("Achievement26");
        A27 = PlayerPrefs.GetInt("Achievement27");
        totalAch = A01 + A02 + A03 + A04 + A05 + A06 + A07 + A08 + A09 + A10 + A11 + A12 + A13 + A14 + A15 + A16 + A17 + A18 + A19 + A20 + A21 + A22 + A23 + A24 + A25 + A26 + A27;
    }

    void Update()
    {
        if (saveAchievements == true)
        {
            saveAchievements = false;
            PlayerPrefs.SetInt("Achievement01", A01);
            PlayerPrefs.SetInt("Achievement02", A02);
            PlayerPrefs.SetInt("Achievement03", A03);
            PlayerPrefs.SetInt("Achievement04", A04);
            PlayerPrefs.SetInt("Achievement05", A05);
            PlayerPrefs.SetInt("Achievement06", A06);
            PlayerPrefs.SetInt("Achievement07", A07);
            PlayerPrefs.SetInt("Achievement08", A08);
            PlayerPrefs.SetInt("Achievement09", A09);
            PlayerPrefs.SetInt("Achievement10", A10);
            PlayerPrefs.SetInt("Achievement11", A11);
            PlayerPrefs.SetInt("Achievement12", A12);
            PlayerPrefs.SetInt("Achievement13", A13);
            PlayerPrefs.SetInt("Achievement14", A14);
            PlayerPrefs.SetInt("Achievement15", A15);
            PlayerPrefs.SetInt("Achievement16", A16);
            PlayerPrefs.SetInt("Achievement17", A17);
            PlayerPrefs.SetInt("Achievement18", A18);
            PlayerPrefs.SetInt("Achievement19", A19);
            PlayerPrefs.SetInt("Achievement20", A20);
            PlayerPrefs.SetInt("Achievement21", A21);
            PlayerPrefs.SetInt("Achievement22", A22);
            PlayerPrefs.SetInt("Achievement23", A23);
            PlayerPrefs.SetInt("Achievement24", A24);
            PlayerPrefs.SetInt("Achievement25", A25);
            PlayerPrefs.SetInt("Achievement26", A26);
            PlayerPrefs.SetInt("Achievement27", A27);
            totalAch = A01 + A02 + A03 + A04 + A05 + A06 + A07 + A08 + A09 + A10 + A11 + A12 + A13 + A14 + A15 + A16 + A17 + A18 + A19 + A20 + A21 + A22 + A23 + A24 + A25 + A26 + A27;
        }
    }

    


}
