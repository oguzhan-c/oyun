using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadAllValuesIn : MonoBehaviour
{
    public int totalDistanceValue;
    public int totalCoinValue;
    public int totalGemValue;
    public GameObject distanceDisplay;
    public GameObject coinDisplay;
    public GameObject gemDisplay;
    public static bool hasPrevious = false; //states if we have pressed to start before
    public GameObject firstCam;
    public GameObject returnCam;
    public GameObject pressStart;
    public GameObject menuButtons;
    public GameObject[] uiInterface;
    public static bool updateStats;
    public GameObject mainLogo;

    void Start()
    {
        totalDistanceValue = PlayerPrefs.GetInt("TotalDistance");
        totalCoinValue = PlayerPrefs.GetInt("TotalCoins");
        totalGemValue = PlayerPrefs.GetInt("TotalGems");

        distanceDisplay.GetComponent<Text>().text = "" + totalDistanceValue.ToString("#,#") + "m";
        coinDisplay.GetComponent<Text>().text = "" + totalCoinValue.ToString("#,#");
        gemDisplay.GetComponent<Text>().text = "" + totalGemValue.ToString("#,#");
        if (hasPrevious == true)
        {
            mainLogo.SetActive(true);
            returnCam.SetActive(true);
            firstCam.SetActive(false);
            pressStart.SetActive(false);
            menuButtons.SetActive(true);
            uiInterface[0].SetActive(true);
            uiInterface[1].SetActive(true);
            uiInterface[2].SetActive(true);
            uiInterface[3].SetActive(true);
            uiInterface[4].SetActive(true);
            uiInterface[5].SetActive(true);
            uiInterface[6].SetActive(true);
            uiInterface[7].SetActive(true);
            uiInterface[8].SetActive(true);
            uiInterface[9].SetActive(true);
        }

    }
    void Update()
    {
        if (updateStats == true)
        {
            updateStats = false;
        totalDistanceValue = PlayerPrefs.GetInt("TotalDistance");
        totalCoinValue = PlayerPrefs.GetInt("TotalCoins");
        totalGemValue = PlayerPrefs.GetInt("TotalGems");
            distanceDisplay.GetComponent<Text>().text = "" + totalDistanceValue.ToString("#,#") + "m";
            coinDisplay.GetComponent<Text>().text = "" + totalCoinValue.ToString("#,#");
            gemDisplay.GetComponent<Text>().text = "" + totalGemValue.ToString("#,#");
        }
    }

}
