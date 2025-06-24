using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeductLife : MonoBehaviour
{
    public int randomNumber;
    public GameObject fadeToBlack;

    void Start()
    {
        randomNumber = Random.Range(1, 11);
        if (StageSelect.charPlayingAs == 5 && randomNumber > 6)
        {
            GlobalLives.saveLives = true;
        }
        else
        {
            GlobalLives.lifeCount -= 1;
            GlobalLives.saveLives = true;
        }
        fadeToBlack.SetActive(true);
    }

}
