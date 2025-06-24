using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalStore : MonoBehaviour
{
    public int gemCount;
    public int coinCount;
    public GameObject lifeBuy;
    public GameObject gemBuy;
    public GameObject iceBuy;
    public GameObject forestBuy;
    public GameObject townBuy;
    public GameObject moonBuy;
    public GameObject doozyBuy;
    public GameObject claireBuy;
    public GameObject bossBuy;
    public GameObject lifeLockout;
    public GameObject gemLockout;
    public GameObject iceLockout;
    public GameObject forestLockout;
    public GameObject townLockout;
    public GameObject moonLockout;
    public GameObject doozyLockout;
    public GameObject claireLockout;
    public GameObject bossLockout;
    public GameObject iceUnlocked;
    public GameObject forestUnlocked;
    public GameObject townUnlocked;
    public GameObject moonUnlocked;
    public GameObject doozyUnlocked;
    public GameObject claireUnlocked;
    public GameObject bossUnlocked;
    public AudioSource tillPurchase;
    public GameObject lifeFullBlock;
    public bool pressingButton;
    public bool doozyBlock;
    public bool claireBlock;
    public bool bossBlock;
    public bool iceBlock;
    public bool forestBlock;
    public bool townBlock;
    public bool moonBlock;

    public int doozyUnlock;
    public int claireUnlock;
    public int bossUnlock;
    public int iceUnlock;
    public int forestUnlock;
    public int townUnlock;
    public int moonUnlock;

    public static bool refreshPurchase;

    void Update()
    {
        if (GlobalLives.lifeCount > 98)
        {
            lifeFullBlock.SetActive(true);
            lifeBuy.SetActive(false);
        }
        else
        {
            lifeFullBlock.SetActive(false);
            lifeBuy.SetActive(true);
        }
        if (refreshPurchase == true)
        {
            refreshPurchase = false;
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            //general
            if (coinCount < 20)
            {
                lifeBuy.GetComponent<Button>().interactable = false;
                lifeLockout.SetActive(true);
            }
            else
            {
                lifeBuy.GetComponent<Button>().interactable = true;
                lifeLockout.SetActive(false);
            }
            if (coinCount < 60)
            {
                gemBuy.GetComponent<Button>().interactable = false;
                gemLockout.SetActive(true);
            }
            else
            {
                gemBuy.GetComponent<Button>().interactable = true;
                gemLockout.SetActive(false);
            }
            //stages
            if (gemCount < 15)
            {
                iceBuy.GetComponent<Button>().interactable = false;
                iceLockout.SetActive(true);
            }
            else
            {
                iceBuy.GetComponent<Button>().interactable = true;
                iceLockout.SetActive(false);
            }
            if (gemCount < 50)
            {
                forestBuy.GetComponent<Button>().interactable = false;
                forestLockout.SetActive(true);
            }
            else
            {
                forestBuy.GetComponent<Button>().interactable = true;
                forestLockout.SetActive(false);
            }
            if (gemCount < 100)
            {
                townBuy.GetComponent<Button>().interactable = false;
                townLockout.SetActive(true);
            }
            else
            {
                townBuy.GetComponent<Button>().interactable = true;
                townLockout.SetActive(false);
            }
            if (gemCount < 150)
            {
                moonBuy.GetComponent<Button>().interactable = false;
                moonLockout.SetActive(true);
            }
            else
            {
                moonBuy.GetComponent<Button>().interactable = true;
                moonLockout.SetActive(false);
            }
            //runners
            if (gemCount < 30)
            {
                doozyBuy.GetComponent<Button>().interactable = false;
                doozyLockout.SetActive(true);
            }
            else
            {
                doozyBuy.GetComponent<Button>().interactable = true;
                doozyLockout.SetActive(false);
            }
    
            if (gemCount < 75)
            {
                claireBuy.GetComponent<Button>().interactable = false;
                claireLockout.SetActive(true);
            }
            else
            {
                claireBuy.GetComponent<Button>().interactable = true;
                claireLockout.SetActive(false);
            }
            if (gemCount < 125)
            {
                bossBuy.GetComponent<Button>().interactable = false;
                bossLockout.SetActive(true);
            }
            else
            {
                bossBuy.GetComponent<Button>().interactable = true;
                bossLockout.SetActive(false);
            }
        }


        if (Input.GetButton("L3Button") && pressingButton == false && MainMenuControl.bigButtonPressed == true && MainMenuButtons.menuLocation == 2)
        {
            if (GlobalLives.lifeCount < 99 && coinCount > 19)
            {
                pressingButton = true;
                tillPurchase.Play();
                coinCount -= 20;
                PlayerPrefs.SetInt("TotalCoins", coinCount);
                LoadAllValuesIn.updateStats = true;
                GlobalLives.lifeCount += 1;
                GlobalLives.saveLives = true;
                NoLives.redoLife = true;
                StartCoroutine(ReRunStats());
            }
        }

        if (Input.GetButton("R3Button") && pressingButton == false && MainMenuControl.bigButtonPressed == true && MainMenuButtons.menuLocation == 2)
        {
            if (coinCount > 59)
            {
                pressingButton = true;
                tillPurchase.Play();
                coinCount -= 60;
                gemCount += 1;
                PlayerPrefs.SetInt("TotalCoins", coinCount);
                PlayerPrefs.SetInt("TotalGems", gemCount);
                LoadAllValuesIn.updateStats = true;
                StartCoroutine(ReRunStats());
            }
        }

        if (Input.GetButton("Jump") && pressingButton == false && MainMenuControl.bigButtonPressed == true && MainMenuButtons.menuLocation == 2 && doozyBlock == false && doozyUnlock == 0)
        {
            if (gemCount > 29)
            {

                pressingButton = true;
                doozyBlock = true;
                tillPurchase.Play();
                gemCount -= 30;
                PlayerPrefs.SetInt("TotalGems", gemCount);
                LoadAllValuesIn.updateStats = true;
                doozyUnlocked.SetActive(true);
                doozyBuy.SetActive(false);
                GlobalUnlocks.doozyUnlock = 1;
                GlobalUnlocks.saveUnlocks = true;
                CharacterMenu.refreshCast = true;
                StartCoroutine(ReRunStats());
            }
        }

        if (Input.GetButton("Fire1") && pressingButton == false && MainMenuControl.bigButtonPressed == true && MainMenuButtons.menuLocation == 2 && claireBlock == false && claireUnlock ==0)
        {
            if (gemCount > 74)
            {
                pressingButton = true;
                claireBlock = true;
                tillPurchase.Play();
                gemCount -= 75;
                PlayerPrefs.SetInt("TotalGems", gemCount);
                LoadAllValuesIn.updateStats = true;
                claireUnlocked.SetActive(true);
                claireBuy.SetActive(false);
                GlobalUnlocks.claireUnlock = 1;
                GlobalUnlocks.saveUnlocks = true;
                CharacterMenu.refreshCast = true;
                StartCoroutine(ReRunStats());
            }
        }

        if (Input.GetButton("Fire2") && pressingButton == false && MainMenuControl.bigButtonPressed == true && MainMenuButtons.menuLocation == 2 & bossBlock == false && bossUnlock == 0)
        {
            if (gemCount > 124)
            {
                pressingButton = true;
                bossBlock = true;
                tillPurchase.Play();
                gemCount -= 125;
                PlayerPrefs.SetInt("TotalGems", gemCount);
                LoadAllValuesIn.updateStats = true;
                bossUnlocked.SetActive(true);
                bossBuy.SetActive(false);
                GlobalUnlocks.bossUnlock = 1;
                GlobalUnlocks.saveUnlocks = true;
                CharacterMenu.refreshCast = true;
                StartCoroutine(ReRunStats());
            }
        }

        if (Input.GetButton("LBButton") && pressingButton == false && MainMenuControl.bigButtonPressed == true && MainMenuButtons.menuLocation == 2 & iceBlock == false && iceUnlock == 0)
        {
            if (gemCount > 14)
            {
                pressingButton = true;
                iceBlock = true;
                tillPurchase.Play();
                gemCount -= 15;
                PlayerPrefs.SetInt("TotalGems", gemCount);
                LoadAllValuesIn.updateStats = true;
                iceUnlocked.SetActive(true);
                iceBuy.SetActive(false);
                GlobalUnlocks.iceUnlock = 1;
                GlobalUnlocks.saveUnlocks = true;
                StartCoroutine(ReRunStats());
            }
        }

        if (Input.GetButton("RBButton") && pressingButton == false && MainMenuControl.bigButtonPressed == true && MainMenuButtons.menuLocation == 2 & forestBlock == false && forestUnlock == 0)
        {
            if (gemCount > 49)
            {
                pressingButton = true;
                forestBlock = true;
                tillPurchase.Play();
                gemCount -= 50;
                PlayerPrefs.SetInt("TotalGems", gemCount);
                LoadAllValuesIn.updateStats = true;
                forestUnlocked.SetActive(true);
                forestBuy.SetActive(false);
                GlobalUnlocks.forestUnlock = 1;
                GlobalUnlocks.saveUnlocks = true;
                StartCoroutine(ReRunStats());
            }
        }

        //triggers
        if (Input.GetAxis("LTButton") > 0 || Input.GetButton("PSLT"))
        {
            if (pressingButton == false && MainMenuControl.bigButtonPressed == true && MainMenuButtons.menuLocation == 2 & townBlock == false && townUnlock == 0)
            {
                if (gemCount > 99)
                {
                    pressingButton = true;
                    townBlock = true;
                    tillPurchase.Play();
                    gemCount -= 100;
                    PlayerPrefs.SetInt("TotalGems", gemCount);
                    LoadAllValuesIn.updateStats = true;
                    townUnlocked.SetActive(true);
                    townBuy.SetActive(false);
                    GlobalUnlocks.townUnlock = 1;
                    GlobalUnlocks.saveUnlocks = true;
                    StartCoroutine(ReRunStats());
                }
            }
        }

        if (Input.GetAxis("RTButton") > 0 || Input.GetButton("PSRT"))
        {
            if (pressingButton == false && MainMenuControl.bigButtonPressed == true && MainMenuButtons.menuLocation == 2 & moonBlock == false && moonUnlock == 0)
            {
                if (gemCount > 149)
                {
                    pressingButton = true;
                    moonBlock = true;
                    tillPurchase.Play();
                    gemCount -= 150;
                    PlayerPrefs.SetInt("TotalGems", gemCount);
                    LoadAllValuesIn.updateStats = true;
                    moonUnlocked.SetActive(true);
                    moonBuy.SetActive(false);
                    GlobalUnlocks.moonUnlock = 1;
                    GlobalUnlocks.saveUnlocks = true;
                    StartCoroutine(ReRunStats());
                }
            }
        }


    }

    void Start()
    {
        coinCount = PlayerPrefs.GetInt("TotalCoins");
        gemCount = PlayerPrefs.GetInt("TotalGems");

        doozyUnlock = PlayerPrefs.GetInt("DoozyUnlock");
        claireUnlock = PlayerPrefs.GetInt("ClaireUnlock");
        bossUnlock = PlayerPrefs.GetInt("BossUnlock");
        iceUnlock = PlayerPrefs.GetInt("IceUnlock");
        forestUnlock = PlayerPrefs.GetInt("ForestUnlock");
        townUnlock = PlayerPrefs.GetInt("TownUnlock");
        moonUnlock = PlayerPrefs.GetInt("MoonUnlock");

        if (iceUnlock == 1)
        {
            iceUnlocked.SetActive(true);
            iceBuy.SetActive(false);
        }
        if (forestUnlock == 1)
        {
            forestUnlocked.SetActive(true);
            forestBuy.SetActive(false);
        }
        if (townUnlock == 1)
        {
            townUnlocked.SetActive(true);
            townBuy.SetActive(false);
        }
        if (moonUnlock == 1)
        {
            moonUnlocked.SetActive(true);
            moonBuy.SetActive(false);
        }
        if (doozyUnlock == 1)
        {
            doozyUnlocked.SetActive(true);
            doozyBuy.SetActive(false);
        }
        if (claireUnlock == 1)
        {
            claireUnlocked.SetActive(true);
            claireBuy.SetActive(false);
        }
        if (bossUnlock == 1)
        {
            bossUnlocked.SetActive(true);
            bossBuy.SetActive(false);
        }
        //general
        if (coinCount < 20)
        {
            lifeBuy.GetComponent<Button>().interactable = false;
            lifeLockout.SetActive(true);
        }
        else
        {
            lifeBuy.GetComponent<Button>().interactable = true;
            lifeLockout.SetActive(false);
        }
        if (coinCount < 60)
        {
            gemBuy.GetComponent<Button>().interactable = false;
            gemLockout.SetActive(true);
        }
        else
        {
            gemBuy.GetComponent<Button>().interactable = true;
            gemLockout.SetActive(false);
        }
        //stages
        if (gemCount < 15)
        {
            iceBuy.GetComponent<Button>().interactable = false;
            iceLockout.SetActive(true);
        }
        else
        {
            iceBuy.GetComponent<Button>().interactable = true;
            iceLockout.SetActive(false);
        }
        if (gemCount < 50)
        {
            forestBuy.GetComponent<Button>().interactable = false;
            forestLockout.SetActive(true);
        }
        else
        {
            forestBuy.GetComponent<Button>().interactable = true;
            forestLockout.SetActive(false);
        }
        if (gemCount < 100)
        {
            townBuy.GetComponent<Button>().interactable = false;
            townLockout.SetActive(true);
        }
        else
        {
            townBuy.GetComponent<Button>().interactable = true;
            townLockout.SetActive(false);
        }
        if (gemCount < 150)
        {
            moonBuy.GetComponent<Button>().interactable = false;
            moonLockout.SetActive(true);
        }
        else
        {
            moonBuy.GetComponent<Button>().interactable = true;
            moonLockout.SetActive(false);
        }
        //runners
        if (gemCount < 30)
        {
            doozyBuy.GetComponent<Button>().interactable = false;
            doozyLockout.SetActive(true);
        }
        else
        {
            doozyBuy.GetComponent<Button>().interactable = true;
            doozyLockout.SetActive(false);
        }
        if (gemCount < 75)
        {
            claireBuy.GetComponent<Button>().interactable = false;
            claireLockout.SetActive(true);
        }
        else
        {
            claireBuy.GetComponent<Button>().interactable = true;
            claireLockout.SetActive(false);
        }
        if (gemCount < 125)
        {
            bossBuy.GetComponent<Button>().interactable = false;
            bossLockout.SetActive(true);
        }
        else
        {
            bossBuy.GetComponent<Button>().interactable = true;
            bossLockout.SetActive(false);
        }
    }

    public void BuyExtraLife()
    {
        lifeBuy.GetComponent<Button>().interactable = false;
        tillPurchase.Play();
        coinCount -= 20;
        PlayerPrefs.SetInt("TotalCoins", coinCount);
        LoadAllValuesIn.updateStats = true;
        GlobalLives.lifeCount += 1;
        GlobalLives.saveLives = true;
        NoLives.redoLife = true;
        StartCoroutine(ReRunStats());
    }


    public void BuyExtraGem()
    {
        gemBuy.GetComponent<Button>().interactable = false;
        tillPurchase.Play();
        coinCount -= 60;
        gemCount += 1;
        PlayerPrefs.SetInt("TotalCoins", coinCount);
        PlayerPrefs.SetInt("TotalGems", gemCount);
        LoadAllValuesIn.updateStats = true;
        StartCoroutine(ReRunStats());
    }



    public void BuyIcyIssues()
    {
        iceBuy.GetComponent<Button>().interactable = false;
        tillPurchase.Play();
        gemCount -= 15;
        PlayerPrefs.SetInt("TotalGems", gemCount);
        LoadAllValuesIn.updateStats = true;
        iceUnlocked.SetActive(true);
        iceBuy.SetActive(false);
        GlobalUnlocks.iceUnlock = 1;
        GlobalUnlocks.saveUnlocks = true;
        StartCoroutine(ReRunStats());
    }


    public void BuyFeistyForest()
    {
        forestBuy.GetComponent<Button>().interactable = false;
        tillPurchase.Play();
        gemCount -= 50;
        PlayerPrefs.SetInt("TotalGems", gemCount);
        LoadAllValuesIn.updateStats = true;
        forestUnlocked.SetActive(true);
        forestBuy.SetActive(false);
        GlobalUnlocks.forestUnlock = 1;
        GlobalUnlocks.saveUnlocks = true;
        StartCoroutine(ReRunStats());
    }


    public void BuyTreacleTown()
    {
        townBuy.GetComponent<Button>().interactable = false;
        tillPurchase.Play();
        gemCount -= 100;
        PlayerPrefs.SetInt("TotalGems", gemCount);
        LoadAllValuesIn.updateStats = true;
        townUnlocked.SetActive(true);
        townBuy.SetActive(false);
        GlobalUnlocks.townUnlock = 1;
        GlobalUnlocks.saveUnlocks = true;
        StartCoroutine(ReRunStats());
    }


    public void BuyMentalMoonbase()
    {
        moonBuy.GetComponent<Button>().interactable = false;
        tillPurchase.Play();
        gemCount -= 150;
        PlayerPrefs.SetInt("TotalGems", gemCount);
        LoadAllValuesIn.updateStats = true;
        moonUnlocked.SetActive(true);
        moonBuy.SetActive(false);
        GlobalUnlocks.moonUnlock = 1;
        GlobalUnlocks.saveUnlocks = true;
        StartCoroutine(ReRunStats());
    }

    public void BuyDoozy()
    {
        doozyBuy.GetComponent<Button>().interactable = false;
        tillPurchase.Play();
        gemCount -= 30;
        PlayerPrefs.SetInt("TotalGems", gemCount);
        LoadAllValuesIn.updateStats = true;
        doozyUnlocked.SetActive(true);
        doozyBuy.SetActive(false);
        GlobalUnlocks.doozyUnlock = 1;
        GlobalUnlocks.saveUnlocks = true;
        CharacterMenu.refreshCast = true;
        StartCoroutine(ReRunStats());
    }

    public void BuyClaire()
    {
        claireBuy.GetComponent<Button>().interactable = false;
        tillPurchase.Play();
        gemCount -= 75;
        PlayerPrefs.SetInt("TotalGems", gemCount);
        LoadAllValuesIn.updateStats = true;
        claireUnlocked.SetActive(true);
        claireBuy.SetActive(false);
        GlobalUnlocks.claireUnlock = 1;
        GlobalUnlocks.saveUnlocks = true;
        CharacterMenu.refreshCast = true;
        StartCoroutine(ReRunStats());
    }

    public void BuyBoss()
    {
        bossBuy.GetComponent<Button>().interactable = false;
        tillPurchase.Play();
        gemCount -= 125;
        PlayerPrefs.SetInt("TotalGems", gemCount);
        LoadAllValuesIn.updateStats = true;
        bossUnlocked.SetActive(true);
        bossBuy.SetActive(false);
        GlobalUnlocks.bossUnlock = 1;
        GlobalUnlocks.saveUnlocks = true;
        CharacterMenu.refreshCast = true;
        StartCoroutine(ReRunStats());
    }


    IEnumerator ReRunStats()
    {
        yield return new WaitForSeconds(0.25f);
        coinCount = PlayerPrefs.GetInt("TotalCoins");
        gemCount = PlayerPrefs.GetInt("TotalGems");
        //general
        if (coinCount < 20)
        {
            lifeBuy.GetComponent<Button>().interactable = false;
            lifeLockout.SetActive(true);
        }
        else
        {
            lifeBuy.GetComponent<Button>().interactable = true;
            lifeLockout.SetActive(false);
        }
        if (coinCount < 60)
        {
            gemBuy.GetComponent<Button>().interactable = false;
            gemLockout.SetActive(true);
        }
        else
        {
            gemBuy.GetComponent<Button>().interactable = true;
            gemLockout.SetActive(false);
        }
        //stages
        if (gemCount < 15)
        {
            iceBuy.GetComponent<Button>().interactable = false;
            iceLockout.SetActive(true);
        }
        else
        {
            iceBuy.GetComponent<Button>().interactable = true;
            iceLockout.SetActive(false);
        }
        if (gemCount < 50)
        {
            forestBuy.GetComponent<Button>().interactable = false;
            forestLockout.SetActive(true);
        }
        else
        {
            forestBuy.GetComponent<Button>().interactable = true;
            forestLockout.SetActive(false);
        }
        if (gemCount < 100)
        {
            townBuy.GetComponent<Button>().interactable = false;
            townLockout.SetActive(true);
        }
        else
        {
            townBuy.GetComponent<Button>().interactable = true;
            townLockout.SetActive(false);
        }
        if (gemCount < 150)
        {
            moonBuy.GetComponent<Button>().interactable = false;
            moonLockout.SetActive(true);
        }
        else
        {
            moonBuy.GetComponent<Button>().interactable = true;
            moonLockout.SetActive(false);
        }
        //runners
        if (gemCount < 30)
        {
            doozyBuy.GetComponent<Button>().interactable = false;
            doozyLockout.SetActive(true);
        }
        else
        {
            doozyBuy.GetComponent<Button>().interactable = true;
            doozyLockout.SetActive(false);
        }
        if (gemCount < 75)
        {
            claireBuy.GetComponent<Button>().interactable = false;
            claireLockout.SetActive(true);
        }
        else
        {
            claireBuy.GetComponent<Button>().interactable = true;
            claireLockout.SetActive(false);
        }
        if (gemCount < 125)
        {
            bossBuy.GetComponent<Button>().interactable = false;
            bossLockout.SetActive(true);
        }
        else
        {
            bossBuy.GetComponent<Button>().interactable = true;
            bossLockout.SetActive(false);
        }
        pressingButton = false;
    }
}
