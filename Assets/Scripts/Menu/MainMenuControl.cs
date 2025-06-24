using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public GameObject startButton;
    public GameObject mainCamera;
    public GameObject playButton;
    public GameObject fadeOut;
    public GameObject[] uiInterface;
    public AudioSource buttonSelect;
    public GameObject completeCam;
    public GameObject achContainer;
    public GameObject storeContainer;
    public GameObject halfFade;
    public GameObject mainLogo;
    public int backgroundGen;
    public GameObject[] backgroundDisplay;
    public int backgroundChecker; //relates to the last stage
    public bool buttonPress; //test controller
    public static bool bigButtonPressed;

    void Update()
    {
        if (Input.GetButton("Jump") && buttonPress == false && bigButtonPressed == true && MainMenuButtons.menuLocation == 0 && GlobalLives.lifeCount > 0)
        {
            PlayerPrefs.SetFloat("ControlSetting", SliderPref.sliderSend);
            buttonPress = true;
            buttonSelect.Play();
            fadeOut.SetActive(true);
            playButton.SetActive(false);
            StartCoroutine(GoToStageSelect());
        }
        if (Input.GetButton("Fire1") && buttonPress == false && bigButtonPressed == true && MainMenuButtons.menuLocation == 0)
        {
            buttonPress = true;
            halfFade.GetComponent<Animator>().Play("MenuHalfIn");
            completeCam.GetComponent<Animator>().Play("MainToStore");
            playButton.SetActive(false);
            //uiInterface[0].SetActive(false);
            //uiInterface[1].SetActive(false);
            //uiInterface[2].SetActive(false);
            //uiInterface[3].SetActive(false);
            //uiInterface[4].SetActive(false);
            //uiInterface[5].SetActive(false);
            //uiInterface[6].SetActive(false);
            //uiInterface[7].SetActive(false);
            mainLogo.SetActive(false);
            StartCoroutine(DisplayStore());
        }
        if (Input.GetButton("Fire2") && buttonPress == false && bigButtonPressed == true && MainMenuButtons.menuLocation == 0)
        {
            buttonPress = true;
            halfFade.GetComponent<Animator>().Play("MenuHalfIn");
            completeCam.GetComponent<Animator>().Play("MainToAch");
            playButton.SetActive(false);
            uiInterface[0].SetActive(false);
            uiInterface[1].SetActive(false);
            uiInterface[2].SetActive(false);
            uiInterface[3].SetActive(false);
            uiInterface[4].SetActive(false);
            uiInterface[5].SetActive(false);
            uiInterface[6].SetActive(false);
            uiInterface[7].SetActive(false);
            mainLogo.SetActive(false);
            StartCoroutine(DisplayAch());
        }
        if (Input.GetButton("Fire3") && buttonPress == false && bigButtonPressed == true && MainMenuButtons.menuLocation == 0)
        {
            PlayerPrefs.SetFloat("ControlSetting", SliderPref.sliderSend);
            buttonPress = true;
            buttonSelect.Play();
            fadeOut.SetActive(true);
            playButton.SetActive(false);
        }
        if (Input.GetButton("Fire3") && buttonPress == false && bigButtonPressed == true && MainMenuButtons.menuLocation == 1)
        {
            buttonPress = true;
            halfFade.GetComponent<Animator>().Play("MenuHalfOut");
            completeCam.GetComponent<Animator>().Play("AchToMain");
            achContainer.SetActive(false);
            StartCoroutine(BackToMenu());
        }
        if (Input.GetButton("Fire3") && buttonPress == false && bigButtonPressed == true && MainMenuButtons.menuLocation == 1)
        {
            halfFade.GetComponent<Animator>().Play("MenuHalfIn");
            completeCam.GetComponent<Animator>().Play("MainToStore");
            playButton.SetActive(false);
            //uiInterface[0].SetActive(false);
            //uiInterface[1].SetActive(false);
            //uiInterface[2].SetActive(false);
            //uiInterface[3].SetActive(false);
            //uiInterface[4].SetActive(false);
            //uiInterface[5].SetActive(false);
            //uiInterface[6].SetActive(false);
            //uiInterface[7].SetActive(false);
            StartCoroutine(DisplayStore());
        }
        if (Input.GetButton("Fire3") && buttonPress == false && bigButtonPressed == true && MainMenuButtons.menuLocation == 2)
        {
            MainMenuButtons.menuLocation = 3;
            halfFade.GetComponent<Animator>().Play("MenuHalfOut");
            completeCam.GetComponent<Animator>().Play("StoreToMain");
            storeContainer.SetActive(false);
            StartCoroutine(BackToMenu());
        }
    }
    private void Start()
    {
        //generates background according to the last stage played. If first time, desert is displayed
        backgroundChecker = PlayerPrefs.GetInt("MenuBackground");
        backgroundDisplay[backgroundChecker].SetActive(true);
        //reset the statics
        GlobalCollisionDetect.hasCollided = false;
        GlobalScore.preventAdding = false;
    }

    public void PressStart() //the big main start button
    {
        mainCamera.GetComponent<Animator>().enabled = true;
        bigButtonPressed = true;
        startButton.SetActive(false);
        LoadAllValuesIn.hasPrevious = true;
        StartCoroutine(DisplayFunctions());
    }

    public void PlayButton()
    {
        PlayerPrefs.SetFloat("ControlSetting", SliderPref.sliderSend);
        buttonSelect.Play();
        fadeOut.SetActive(true);
        playButton.SetActive(false);
        StartCoroutine(GoToStageSelect());
    }

    public void BonusButton()
    {
        PlayerPrefs.SetFloat("ControlSetting", SliderPref.sliderSend);
        buttonSelect.Play();
        fadeOut.SetActive(true);
        playButton.SetActive(false);
    }

    public void CreditsButton()
    {
        PlayerPrefs.SetFloat("ControlSetting", SliderPref.sliderSend);
        buttonSelect.Play();
        fadeOut.SetActive(true);
        playButton.SetActive(false);
    }

    IEnumerator DisplayFunctions()
    {
        yield return new WaitForSeconds(1.75f);
        playButton.SetActive(true);
        uiInterface[0].SetActive(true);
        uiInterface[1].SetActive(true);
        uiInterface[2].SetActive(true);
        uiInterface[3].SetActive(true);
        uiInterface[4].SetActive(true);
        uiInterface[5].SetActive(true);
        uiInterface[6].SetActive(true);
        uiInterface[7].SetActive(true);
        completeCam.SetActive(true);
        mainCamera.SetActive(false);
        mainLogo.SetActive(true);
    }

    IEnumerator GoToStageSelect()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void MenuToAchs()
    {
        halfFade.GetComponent<Animator>().Play("MenuHalfIn");
        completeCam.GetComponent<Animator>().Play("MainToAch");
        playButton.SetActive(false);
        uiInterface[0].SetActive(false);
        uiInterface[1].SetActive(false);
        uiInterface[2].SetActive(false);
        uiInterface[3].SetActive(false);
        uiInterface[4].SetActive(false);
        uiInterface[5].SetActive(false);
        uiInterface[6].SetActive(false);
        uiInterface[7].SetActive(false);
        mainLogo.SetActive(false);
        StartCoroutine(DisplayAch());
    }

    IEnumerator DisplayAch()
    {
        yield return new WaitForSeconds(1.1f);
        achContainer.SetActive(true);
        MainMenuButtons.menuLocation = 1;
        buttonPress = false;
    }

    public void AchsToMenu()
    {
        halfFade.GetComponent<Animator>().Play("MenuHalfOut");
        completeCam.GetComponent<Animator>().Play("AchToMain");
        achContainer.SetActive(false);
        StartCoroutine(BackToMenu());
    }

    IEnumerator BackToMenu()
    {
        yield return new WaitForSeconds(1.1f);
        playButton.SetActive(true);
        uiInterface[0].SetActive(true);
        uiInterface[1].SetActive(true);
        uiInterface[2].SetActive(true);
        uiInterface[3].SetActive(true);
        uiInterface[4].SetActive(true);
        uiInterface[5].SetActive(true);
        uiInterface[6].SetActive(true);
        uiInterface[7].SetActive(true);
        MainMenuButtons.menuLocation = 0;
        mainLogo.SetActive(true);
        buttonPress = false;
    }

    IEnumerator DisplayStore()
    {
        yield return new WaitForSeconds(1.1f);
        storeContainer.SetActive(true);
        MainMenuButtons.menuLocation = 2;
        buttonPress = false;
    }

    public void MenuToStore()
    {
        halfFade.GetComponent<Animator>().Play("MenuHalfIn");
        completeCam.GetComponent<Animator>().Play("MainToStore");
        playButton.SetActive(false);
        //uiInterface[0].SetActive(false);
        //uiInterface[1].SetActive(false);
        //uiInterface[2].SetActive(false);
        //uiInterface[3].SetActive(false);
        //uiInterface[4].SetActive(false);
        //uiInterface[5].SetActive(false);
        //uiInterface[6].SetActive(false);
        //uiInterface[7].SetActive(false);
        mainLogo.SetActive(false);
        StartCoroutine(DisplayStore());
    }

    public void StoreToMenu()
    {
        halfFade.GetComponent<Animator>().Play("MenuHalfOut");
        completeCam.GetComponent<Animator>().Play("StoreToMain");
        storeContainer.SetActive(false);
        StartCoroutine(BackToMenu());
    }
}
