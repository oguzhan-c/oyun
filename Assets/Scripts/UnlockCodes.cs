using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCodes : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("DoozyUnlock", 1);
        PlayerPrefs.SetInt("ClaireUnlock", 1);
        PlayerPrefs.SetInt("BossUnlock", 1);
        PlayerPrefs.SetInt("IceUnlock", 1);
        PlayerPrefs.SetInt("ForestUnlock", 1);
        PlayerPrefs.SetInt("TownUnlock", 1);
        PlayerPrefs.SetInt("MoonUnlock", 1);
    }
}
