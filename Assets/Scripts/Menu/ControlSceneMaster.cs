using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlSceneMaster : MonoBehaviour
{
    public GameObject fadeOut;
    public int levelToLoad;
    //these objects below will display if you have selected that stage
    public GameObject desertBack;
    public GameObject iceBack;
    public GameObject forestBack;
    public GameObject townBack;
    public GameObject moonBack;
    public GameObject loadText;
    public GameObject spaceBar;
    public GameObject aButton;
    public GameObject[] controlKeys;
    public GameObject leftStick;
    public GameObject rightStick;
    public GameObject crossButton;

    void Start()
    {
        if (TestJoys.joyOn == true)
        {
            if (TestJoys.layoutSet == 1)
            {
                crossButton.SetActive(true);
            }
            else
            {
                aButton.SetActive(true);
            }
            spaceBar.SetActive(false);
            controlKeys[0].SetActive(false);
            controlKeys[1].SetActive(false);
            controlKeys[2].SetActive(false);
            controlKeys[3].SetActive(false);
            controlKeys[4].SetActive(false);
            leftStick.SetActive(true);
            StartCoroutine(StickMoves());
        }
        else
        {
            aButton.SetActive(false);
            spaceBar.SetActive(true);
            controlKeys[0].SetActive(true);
            controlKeys[1].SetActive(true);
            controlKeys[2].SetActive(true);
            controlKeys[3].SetActive(true);
            controlKeys[4].SetActive(true);
            leftStick.SetActive(false);
            rightStick.SetActive(false);
        }
        levelToLoad = StageSelect.stageToGoTo;
        if (levelToLoad == 4)
        {
            desertBack.SetActive(true);
        }
        if (levelToLoad == 5)
        {
            iceBack.SetActive(true);
        }
        if (levelToLoad == 6)
        {
            forestBack.SetActive(true);
        }
        if (levelToLoad == 7)
        {
            townBack.SetActive(true);
        }
        if (levelToLoad == 8)
        {
            moonBack.SetActive(true);
        }
        StartCoroutine(Sequence());
    }

    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(2.5f);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        loadText.SetActive(true);
        SceneManager.LoadScene(levelToLoad);
    }

    IEnumerator StickMoves()
    {
        yield return new WaitForSeconds(0.5f);
        rightStick.SetActive(true);
        leftStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        leftStick.SetActive(true);
        rightStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        rightStick.SetActive(true);
        leftStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        leftStick.SetActive(true);
        rightStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        rightStick.SetActive(true);
        leftStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        leftStick.SetActive(true);
        rightStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        rightStick.SetActive(true);
        leftStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        leftStick.SetActive(true);
        rightStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        rightStick.SetActive(true);
        leftStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        leftStick.SetActive(true);
        rightStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        rightStick.SetActive(true);
        leftStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        leftStick.SetActive(true);
        rightStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        rightStick.SetActive(true);
        leftStick.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        leftStick.SetActive(true);
        rightStick.SetActive(false);
    }
}
