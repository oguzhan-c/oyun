using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardTrack : MonoBehaviour
{
    public static int timmyCount;
    public static int mouseyCount;
    public static int doozyCount;
    public static int claireCount;
    public static int bossCount;
    public static int arissaCount;
    public static int michelleCount;
    public int internalTimmy;
    public int internalMousey;
    public int internalDoozy;
    public int internalClaire;
    public int internalBoss;
    public int internalArissa;
    public int internalMichelle;
    public static int whichChar;
    public static bool saveStats;

    void Start()
    {
        timmyCount = PlayerPrefs.GetInt("TimmyPlay");
        mouseyCount = PlayerPrefs.GetInt("MouseyPlay");
        doozyCount = PlayerPrefs.GetInt("DoozyPlay");
        claireCount = PlayerPrefs.GetInt("ClairePlay");
        bossCount = PlayerPrefs.GetInt("BossPlay");
        arissaCount = PlayerPrefs.GetInt("ArissaPlay");
        michelleCount = PlayerPrefs.GetInt("MichellePlay");
        if (timmyCount > 7)
        {
            timmyCount = 0;
            PlayerPrefs.SetInt("TimmyPlay", 0);
        }
        if (mouseyCount > 7)
        {
            mouseyCount = 0;
            PlayerPrefs.SetInt("MouseyPlay", 0);
        }
        if (doozyCount > 7)
        {
            doozyCount = 0;
            PlayerPrefs.SetInt("DoozyPlay", 0);
        }
        if (claireCount > 7)
        {
            claireCount = 0;
            PlayerPrefs.SetInt("ClairePlay", 0);
        }
        if (bossCount > 7)
        {
            bossCount = 0;
            PlayerPrefs.SetInt("BossPlay", 0);
        }
        if (arissaCount > 7)
        {
            arissaCount = 0;
            PlayerPrefs.SetInt("ArissaPlay", 0);
        }
        if (michelleCount > 7)
        {
            michelleCount = 0;
            PlayerPrefs.SetInt("MichellePlay", 0);
        }
    }

    void Update()
    {
        if (saveStats == true)
        {
            saveStats = false;
            PlayerPrefs.SetInt("TimmyPlay", timmyCount);
            PlayerPrefs.SetInt("MouseyPlay", mouseyCount);
            PlayerPrefs.SetInt("DoozyPlay",doozyCount);
            PlayerPrefs.SetInt("ClairePlay",claireCount);
            PlayerPrefs.SetInt("BossPlay",bossCount);
            PlayerPrefs.SetInt("ArissaPlay",arissaCount);
            PlayerPrefs.SetInt("MichellePlay",michelleCount);
        }
        internalTimmy = timmyCount;
        internalMousey = mouseyCount;
        internalClaire = claireCount;
        internalDoozy = doozyCount;
        internalBoss = bossCount;
        internalArissa = arissaCount;
        internalMichelle = michelleCount;
    }
}
