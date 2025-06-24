using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMenu : MonoBehaviour
{
    public GameObject doozyPlayer;
    public GameObject clairePlayer;
    public GameObject bossPlayer;
    public static bool refreshCast;
    void Start()
    {
        StartCoroutine(CharAppear());
    }

    void Update()
    {
        if (refreshCast == true)
        {
            refreshCast = false;
            if (GlobalUnlocks.doozyUnlock == 1)
            {
                doozyPlayer.SetActive(true);
            }
            if (GlobalUnlocks.claireUnlock == 1)
            {
                clairePlayer.SetActive(true);
            }
            if (GlobalUnlocks.bossUnlock == 1)
            {
                bossPlayer.SetActive(true);
            }
        }
    }

    IEnumerator CharAppear()
    {
        yield return new WaitForSeconds(0.01f);
        if (GlobalUnlocks.doozyUnlock == 1)
        {
            doozyPlayer.SetActive(true);
        }
        if (GlobalUnlocks.claireUnlock == 1)
        {
            clairePlayer.SetActive(true);
        }
        if (GlobalUnlocks.bossUnlock == 1)
        {
            bossPlayer.SetActive(true);
        }
    }
}
