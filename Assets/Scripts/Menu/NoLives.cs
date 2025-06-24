using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoLives : MonoBehaviour
{
    public GameObject playButton;
    public GameObject needLife;
    public static bool redoLife;

    void Start()
    {
        if (GlobalLives.lifeCount == 0)
        {
            playButton.GetComponent<Button>().interactable = false;
            needLife.SetActive(true);
        }
        else
        {
            playButton.GetComponent<Button>().interactable = true;
            needLife.SetActive(false);
        }
    }

    void Update()
    {
        if (redoLife == true)
        {
            redoLife = false;
            if (GlobalLives.lifeCount == 0)
            {
                playButton.GetComponent<Button>().interactable = false;
                needLife.SetActive(true);
            }
            else
            {
                playButton.GetComponent<Button>().interactable = true;
                needLife.SetActive(false);
            }
        }
        
    }

}
