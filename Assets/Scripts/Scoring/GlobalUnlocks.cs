using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalUnlocks : MonoBehaviour
{
    //tracks everything unlocked -- 0=locked   1=unlocked
    public static int doozyUnlock;
    public static int claireUnlock;
    public static int bossUnlock;
    public static int iceUnlock;
    public static int forestUnlock;
    public static int townUnlock;
    public static int moonUnlock;
    public static bool saveUnlocks;


    void Start()
    {
        doozyUnlock = PlayerPrefs.GetInt("DoozyUnlock");
        claireUnlock = PlayerPrefs.GetInt("ClaireUnlock");
        bossUnlock = PlayerPrefs.GetInt("BossUnlock");
        iceUnlock = PlayerPrefs.GetInt("IceUnlock");
        forestUnlock = PlayerPrefs.GetInt("ForestUnlock");
        townUnlock = PlayerPrefs.GetInt("TownUnlock");
        moonUnlock = PlayerPrefs.GetInt("MoonUnlock");
    }

    void Update()
    {
        if (saveUnlocks == true)
        {
            saveUnlocks = false;
            PlayerPrefs.SetInt("DoozyUnlock", doozyUnlock);
            PlayerPrefs.SetInt("ClaireUnlock", claireUnlock);
            PlayerPrefs.SetInt("BossUnlock", bossUnlock);
            PlayerPrefs.SetInt("IceUnlock", iceUnlock);
            PlayerPrefs.SetInt("ForestUnlock", forestUnlock);
            PlayerPrefs.SetInt("TownUnlock", townUnlock);
            PlayerPrefs.SetInt("MoonUnlock", moonUnlock);
        }
    }
}
