using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A17Trig : MonoBehaviour
{
    public GameObject AchUI;
    public int jumpCount;
    public bool isJumping;

    void Update()
    {
        if (PlayerControl.externalControls == true && GlobalCollisionDetect.hasCollided == false)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space) || Input.GetButton("Jump"))
            {
                if (isJumping == false)
                {
                    isJumping = true;
                    StartCoroutine(WaitJump());
                }
            }
        }
        if (GlobalAchievements.A17 == 0 && jumpCount == 100)
        {
            GlobalAchievements.A17 = 1;
            GlobalAchievements.saveAchievements = true;
            StartCoroutine(ActivateAch());
        }
    }

    IEnumerator ActivateAch()
    {
        yield return new WaitForSeconds(1);
        AchUI.SetActive(true);
        yield return new WaitForSeconds(4);
        AchUI.SetActive(false);
    }

    IEnumerator WaitJump()
    {
        jumpCount += 1;
        yield return new WaitForSeconds(0.525f);
        yield return new WaitForSeconds(0.523f);
        isJumping = false;
    }
}
