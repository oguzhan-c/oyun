using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject fadeIn;
    public GameObject pressPlay;
    public AudioSource buttonPress;
    public AudioSource startPress;
    public int stageShowing = 1;
    public GameObject theCamera;
    public GameObject stageName;
    public GameObject rightArrow;
    public GameObject leftArrow;
    public static int stageToGoTo; 
    public static int charPlayingAs; 
    public GameObject screenSelectText;
    public GameObject[] charSelButtons;
    public GameObject playButtonText;
    public GameObject playLockout;
    public GameObject doozyLockout;
    public GameObject claireLockout;
    public GameObject bossLockout;
    public GameObject doozyButton;
    public GameObject claireButton;
    public GameObject bossButton;
    public GameObject doozyText;
    public GameObject claireText;
    public GameObject bossText;
    public GameObject loadText;
    public static int stageShowingExternal;
    public GameObject specialLeft;
    public GameObject extraSpecialRight;
    public GameObject extraSpecialLeft;
    public GameObject extraSpecialPlay;
    public bool showingBlock;
    public bool pressingButton;
    public bool selectedStageNow;
    public bool isMoving;
    public bool canMoveToBlock;
    public bool blockBarrageOnly;
    public bool startingBlock;

    void Update()
    {
        stageShowingExternal = stageShowing;
        if (stageShowing == 5 && UnlockBlock.isVisible == 1 && showingBlock == false)
        {
            StartCoroutine(ShowBlock());
            showingBlock = true;
        }

        if (Input.GetButton("RBButton") && pressingButton == false && selectedStageNow == false && MashAbility.onSpecial == false)
        {
            pressingButton = true;
            StartCoroutine(ReleaseButtons());
            MashAbility.showSpecial = false;
            if (stageShowing == 1)
            {
                theCamera.GetComponent<Animator>().Play("DesertToIce");
                stageShowing += 1;
                if (GlobalUnlocks.iceUnlock == 0)
                {
                    playButtonText.GetComponent<Text>().text = "LOCKED!";
                    pressPlay.GetComponent<Button>().interactable = false;
                    playLockout.SetActive(true);
                }
                else
                {
                    playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                    pressPlay.GetComponent<Button>().interactable = true;
                    playLockout.SetActive(false);
                }
                StartCoroutine(ButtonDelay());
                return;
            }

            if (stageShowing == 2)
            {
                theCamera.GetComponent<Animator>().Play("IceToForest");
                stageShowing += 1;
                if (GlobalUnlocks.forestUnlock == 0)
                {
                    playButtonText.GetComponent<Text>().text = "LOCKED!";
                    pressPlay.GetComponent<Button>().interactable = false;
                    playLockout.SetActive(true);
                }
                else
                {
                    playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                    pressPlay.GetComponent<Button>().interactable = true;
                    playLockout.SetActive(false);
                }
                StartCoroutine(ButtonDelay());
                return;
            }
            if (stageShowing == 3)
            {
                theCamera.GetComponent<Animator>().Play("ForestToTown");
                stageShowing += 1;
                if (GlobalUnlocks.townUnlock == 0)
                {
                    playButtonText.GetComponent<Text>().text = "LOCKED!";
                    pressPlay.GetComponent<Button>().interactable = false;
                    playLockout.SetActive(true);
                }
                else
                {
                    playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                    pressPlay.GetComponent<Button>().interactable = true;
                    playLockout.SetActive(false);
                }
                StartCoroutine(ButtonDelay());
                return;
            }
            if (stageShowing == 4)
            {
                theCamera.GetComponent<Animator>().Play("TownToMoon");
                stageShowing += 1;
                if (GlobalUnlocks.moonUnlock == 0)
                {
                    playButtonText.GetComponent<Text>().text = "LOCKED!";
                    pressPlay.GetComponent<Button>().interactable = false;
                    playLockout.SetActive(true);
                }
                StartCoroutine(ButtonDelay());
                return;
            }
            if (stageShowing == 5 && canMoveToBlock == true && UnlockBlock.isVisible == 1)
            {
                canMoveToBlock = false;
                theCamera.GetComponent<Animator>().Play("MoonToBlock");
                stageShowing = 1;
                extraSpecialRight.SetActive(false);
                StartCoroutine(BlockSeq());
            }
        }

        if (Input.GetButton("LBButton") && pressingButton == false && selectedStageNow == false && MashAbility.onSpecial == false)
        {
            pressingButton = true;
            StartCoroutine(ReleaseButtons());
            if (stageShowing == 2)
            {
                theCamera.GetComponent<Animator>().Play("IceToDesert");
                stageShowing -= 1;
                playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                pressPlay.GetComponent<Button>().interactable = true;
                playLockout.SetActive(false);
                StartCoroutine(ButtonDelay());
                return;
            }

            if (stageShowing == 3)
            {
                theCamera.GetComponent<Animator>().Play("ForestToIce");
                stageShowing -= 1;
                if (GlobalUnlocks.iceUnlock == 0)
                {
                    playButtonText.GetComponent<Text>().text = "LOCKED!";
                    pressPlay.GetComponent<Button>().interactable = false;
                    playLockout.SetActive(true);
                }
                else
                {
                    playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                    pressPlay.GetComponent<Button>().interactable = true;
                    playLockout.SetActive(false);
                }
                StartCoroutine(ButtonDelay());
                return;
            }
            if (stageShowing == 4)
            {
                theCamera.GetComponent<Animator>().Play("TownToForest");
                stageShowing -= 1;
                if (GlobalUnlocks.forestUnlock == 0)
                {
                    playButtonText.GetComponent<Text>().text = "LOCKED!";
                    pressPlay.GetComponent<Button>().interactable = false;
                    playLockout.SetActive(true);
                }
                else
                {
                    playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                    pressPlay.GetComponent<Button>().interactable = true;
                    playLockout.SetActive(false);
                }
                StartCoroutine(ButtonDelay());
                return;
            }
            if (stageShowing == 5)
            {
                extraSpecialRight.SetActive(false);
                theCamera.GetComponent<Animator>().Play("MoonToTown");
                stageShowing -= 1;
                canMoveToBlock = false;
                if (GlobalUnlocks.townUnlock == 0)
                {
                    playButtonText.GetComponent<Text>().text = "LOCKED!";
                    pressPlay.GetComponent<Button>().interactable = false;
                    playLockout.SetActive(true);
                }
                else
                {
                    playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                    pressPlay.GetComponent<Button>().interactable = true;
                    playLockout.SetActive(false);
                }
                StartCoroutine(ButtonDelay());
                StartCoroutine(ChangeToFalse());
                return;
            }

            if (blockBarrageOnly == true)
            {
                blockBarrageOnly = false;
                theCamera.GetComponent<Animator>().Play("BlockToMoon");
                stageShowing = 5;
                extraSpecialLeft.SetActive(false);
                extraSpecialPlay.SetActive(false);
                StartCoroutine(BackToMoon());
            }
        }
        if (Input.GetButton("Jump") && pressingButton == false && selectedStageNow == false && isMoving == false && MashAbility.onSpecial == false && blockBarrageOnly == true && startingBlock == true)
        {
            startingBlock = false;
            pressPlay.SetActive(false);
            fadeOut.SetActive(true);
            StartCoroutine(FadeToBlocky());
        }
        if (Input.GetButton("Jump") && pressingButton == false && selectedStageNow == false && isMoving == false && MashAbility.onSpecial == false && blockBarrageOnly == false)
        {
            if (stageShowing == 1)
            {
                isMoving = true;
                specialLeft.SetActive(false);
                theCamera.GetComponent<Animator>().Play("CharFromDesert");
                StartCoroutine(CharSelect());
                return;
            }
            if (stageShowing == 2 && GlobalUnlocks.iceUnlock == 1)
            {
                isMoving = true;
                specialLeft.SetActive(false);
                theCamera.GetComponent<Animator>().Play("CharFromIce");
                StartCoroutine(CharSelect());
                return;
            }
            if (stageShowing == 3 && GlobalUnlocks.forestUnlock == 1)
            {
                isMoving = true;
                specialLeft.SetActive(false);
                theCamera.GetComponent<Animator>().Play("CharFromForest");
                StartCoroutine(CharSelect());
                return;
            }
            if (stageShowing == 4 && GlobalUnlocks.townUnlock == 1)
            {
                isMoving = true;
                specialLeft.SetActive(false);
                theCamera.GetComponent<Animator>().Play("CharFromTown");
                StartCoroutine(CharSelect());
                return;
            }
            if (stageShowing == 5 && GlobalUnlocks.moonUnlock == 1)
            {
                isMoving = true;
                specialLeft.SetActive(false);
                theCamera.GetComponent<Animator>().Play("CharFromMoon");
                StartCoroutine(CharSelect());
                return;
            }
        }


        if (Input.GetButton("Jump") && pressingButton == false && selectedStageNow == true && MashAbility.onSpecial == false)
        {
            pressingButton = true;
            pressPlay.SetActive(false);
            fadeOut.SetActive(true);
            charPlayingAs = 1;
            StartCoroutine(FadeToPlay());
        }

        if (Input.GetButton("Fire1") && pressingButton == false && selectedStageNow == true && MashAbility.onSpecial == false)
        {
            pressingButton = true;
            pressPlay.SetActive(false);
            fadeOut.SetActive(true);
            charPlayingAs = 2;
            StartCoroutine(FadeToPlay());
        }

        if (Input.GetButton("Fire2") && pressingButton == false && selectedStageNow == true && GlobalUnlocks.doozyUnlock == 1 && MashAbility.onSpecial == false)
        {
            pressingButton = true;
            pressPlay.SetActive(false);
            fadeOut.SetActive(true);
            charPlayingAs = 4;
            StartCoroutine(FadeToPlay());
        }

        if (Input.GetButton("Fire3") && pressingButton == false && selectedStageNow == true && GlobalUnlocks.claireUnlock == 1 && MashAbility.onSpecial == false)
        {
            pressingButton = true;
            pressPlay.SetActive(false);
            fadeOut.SetActive(true);
            charPlayingAs = 5;
            StartCoroutine(FadeToPlay());
        }

        if (Input.GetButton("RBButton") && pressingButton == false && selectedStageNow == true && GlobalUnlocks.bossUnlock == 1 && MashAbility.onSpecial == false)
        {
            pressingButton = true;
            pressPlay.SetActive(false);
            fadeOut.SetActive(true);
            charPlayingAs = 6;
            StartCoroutine(FadeToPlay());
        }
    }

    void Start()
    {
        MashAbility.onSpecial = false;
        stageShowing = 1;
        stageToGoTo = 4;
        if (GlobalUnlocks.doozyUnlock == 1)
        {
            doozyLockout.SetActive(false);
            doozyButton.GetComponent<Button>().interactable = true;
            doozyText.GetComponent<Text>().text = "DOOZY";
        }
        else
        {
            doozyLockout.SetActive(true);
            doozyButton.GetComponent<Button>().interactable = false;
            doozyText.GetComponent<Text>().text = "LOCKED!";
        }
        if (GlobalUnlocks.claireUnlock == 1)
        {
            claireLockout.SetActive(false);
            claireButton.GetComponent<Button>().interactable = true;
            claireText.GetComponent<Text>().text = "CLAIRE";
        }
        else
        {
            claireLockout.SetActive(true);
            claireButton.GetComponent<Button>().interactable = false;
            claireText.GetComponent<Text>().text = "LOCKED!";
        }
        if (GlobalUnlocks.bossUnlock == 1)
        {
            bossLockout.SetActive(false);
            bossButton.GetComponent<Button>().interactable = true;
            bossText.GetComponent<Text>().text = "THE BOSS";
        }
        else
        {
            bossLockout.SetActive(true);
            bossButton.GetComponent<Button>().interactable = false;
            bossText.GetComponent<Text>().text = "LOCKED!";
        }
        StartCoroutine(ActiveSelect());
    }

    public void StageSelected()
    {
        selectedStageNow = true;
        specialLeft.SetActive(false);
        if (stageShowing == 1)
        {
            theCamera.GetComponent<Animator>().Play("CharFromDesert");
            StartCoroutine(CharSelect());
            return;
        }
        if (stageShowing == 2)
        {
            theCamera.GetComponent<Animator>().Play("CharFromIce");
            StartCoroutine(CharSelect());
            return;
        }
        if (stageShowing == 3)
        {
            theCamera.GetComponent<Animator>().Play("CharFromForest");
            StartCoroutine(CharSelect());
            return;
        }
        if (stageShowing == 4)
        {
            theCamera.GetComponent<Animator>().Play("CharFromTown");
            StartCoroutine(CharSelect());
            return;
        }
        if (stageShowing == 5)
        {
            theCamera.GetComponent<Animator>().Play("CharFromMoon");
            StartCoroutine(CharSelect());
            return;
        }
    }

    IEnumerator ActiveSelect()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }

    public void RightButton()
    {
        MashAbility.showSpecial = false;
        if (stageShowing == 1)
        {
            theCamera.GetComponent<Animator>().Play("DesertToIce");
            stageShowing += 1;
            if (GlobalUnlocks.iceUnlock == 0)
            {
                playButtonText.GetComponent<Text>().text = "LOCKED!";
                pressPlay.GetComponent<Button>().interactable = false;
                playLockout.SetActive(true);
            }
            else
            {
                playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                pressPlay.GetComponent<Button>().interactable = true;
                playLockout.SetActive(false);
            }
            StartCoroutine(ButtonDelay());
            return;
        }

        if (stageShowing == 2)
        {
            theCamera.GetComponent<Animator>().Play("IceToForest");
            stageShowing += 1;
            if (GlobalUnlocks.forestUnlock == 0)
            {
                playButtonText.GetComponent<Text>().text = "LOCKED!";
                pressPlay.GetComponent<Button>().interactable = false;
                playLockout.SetActive(true);
            }
            else
            {
                playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                pressPlay.GetComponent<Button>().interactable = true;
                playLockout.SetActive(false);
            }
            StartCoroutine(ButtonDelay());
            return;
        }
        if (stageShowing == 3)
        {
            theCamera.GetComponent<Animator>().Play("ForestToTown");
            stageShowing += 1;
            if (GlobalUnlocks.townUnlock == 0)
            {
                playButtonText.GetComponent<Text>().text = "LOCKED!";
                pressPlay.GetComponent<Button>().interactable = false;
                playLockout.SetActive(true);
            }
            else
            {
                playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                pressPlay.GetComponent<Button>().interactable = true;
                playLockout.SetActive(false);
            }
            StartCoroutine(ButtonDelay());
            return;
        }
        if (stageShowing == 4)
        {
            theCamera.GetComponent<Animator>().Play("TownToMoon");
            stageShowing += 1;
            if (GlobalUnlocks.moonUnlock == 0)
            {
                playButtonText.GetComponent<Text>().text = "LOCKED!";
                pressPlay.GetComponent<Button>().interactable = false;
                playLockout.SetActive(true);
            }
            StartCoroutine(ButtonDelay());
            return;
        }
    }

    public void LeftButton()
    {
        if (stageShowing == 2)
        {
            theCamera.GetComponent<Animator>().Play("IceToDesert");
            stageShowing -= 1;
            playButtonText.GetComponent<Text>().text = "PLAY STAGE";
            pressPlay.GetComponent<Button>().interactable = true;
            playLockout.SetActive(false);
            StartCoroutine(ButtonDelay());
            return;
        }

        if (stageShowing == 3)
        {
            theCamera.GetComponent<Animator>().Play("ForestToIce");
            stageShowing -= 1;
            if (GlobalUnlocks.iceUnlock == 0)
            {
                playButtonText.GetComponent<Text>().text = "LOCKED!";
                pressPlay.GetComponent<Button>().interactable = false;
                playLockout.SetActive(true);
            }
            else
            {
                playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                pressPlay.GetComponent<Button>().interactable = true;
                playLockout.SetActive(false);
            }
            StartCoroutine(ButtonDelay());
            return;
        }
        if (stageShowing == 4)
        {
            theCamera.GetComponent<Animator>().Play("TownToForest");
            stageShowing -= 1;
            if (GlobalUnlocks.forestUnlock == 0)
            {
                playButtonText.GetComponent<Text>().text = "LOCKED!";
                pressPlay.GetComponent<Button>().interactable = false;
                playLockout.SetActive(true);
            }
            else
            {
                playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                pressPlay.GetComponent<Button>().interactable = true;
                playLockout.SetActive(false);
            }
            StartCoroutine(ButtonDelay());
            return;
        }
        if (stageShowing == 5)
        {
            extraSpecialRight.SetActive(false);
            theCamera.GetComponent<Animator>().Play("MoonToTown");
            stageShowing -= 1;
            if (GlobalUnlocks.townUnlock == 0)
            {
                playButtonText.GetComponent<Text>().text = "LOCKED!";
                pressPlay.GetComponent<Button>().interactable = false;
                playLockout.SetActive(true);
            }
            else
            {
                playButtonText.GetComponent<Text>().text = "PLAY STAGE";
                pressPlay.GetComponent<Button>().interactable = true;
                playLockout.SetActive(false);
            }
            StartCoroutine(ButtonDelay());
            StartCoroutine(ChangeToFalse());
            return;
        }
    }

    IEnumerator ButtonDelay()
    {
        rightArrow.SetActive(false);
        leftArrow.SetActive(false);
        stageName.SetActive(false);
        pressPlay.SetActive(false);
        yield return new WaitForSeconds(1.1f);
        if (stageShowing == 1)
        {
            stageName.GetComponent<Text>().text = "ÇÖL";
            stageToGoTo = 4;
        }
        if (stageShowing == 2)
        {
            stageName.GetComponent<Text>().text = "BUZ";
            stageToGoTo = 5;
        }
        if (stageShowing == 3)
        {
            stageName.GetComponent<Text>().text = "ORMAN";
            stageToGoTo = 6;
        }
        if (stageShowing == 4)
        {
            stageName.GetComponent<Text>().text = "ŞEHİR";
            stageToGoTo = 7;
        }
        if(stageShowing == 5)
        {
            stageName.GetComponent<Text>().text = "AY";
            canMoveToBlock = true;
            stageToGoTo = 8;
        }
        stageName.SetActive(true);
        pressPlay.SetActive(true);
        if (stageShowing == 5)
        {
            rightArrow.SetActive(false);
        }
        else
        {
            rightArrow.SetActive(true);
        }

        if (stageShowing == 1)
        {
            leftArrow.SetActive(false);
        }
        else
        {
            leftArrow.SetActive(true);
        }
        if (stageShowing == 1)
        {
            MashAbility.showSpecial = true;
        }
        pressingButton = false;
    }

    IEnumerator CharSelect()
    {
        MashAbility.showSpecial = false;
        buttonPress.Play();
        extraSpecialRight.SetActive(false);
        rightArrow.SetActive(false);
        leftArrow.SetActive(false);
        stageName.SetActive(false);
        pressPlay.SetActive(false);
        screenSelectText.SetActive(false);
        screenSelectText.GetComponent<Text>().text = "PICK A RUNNER";
        yield return new WaitForSeconds(1.1f);
        screenSelectText.SetActive(true);
        charSelButtons[1].SetActive(true);
        charSelButtons[2].SetActive(true);
        charSelButtons[3].SetActive(true);
        charSelButtons[4].SetActive(true);
        charSelButtons[5].SetActive(true);
        charSelButtons[6].SetActive(true);

        selectedStageNow = true;
    }

    // original section
    public void TimmyPlay()
    {
        pressPlay.SetActive(false);
        fadeOut.SetActive(true);
        charPlayingAs = 1;
        StartCoroutine(FadeToPlay());
    }
    public void DoozyPlay()
    {
        pressPlay.SetActive(false);
        fadeOut.SetActive(true);
        charPlayingAs = 4;
        StartCoroutine(FadeToPlay());
    }
    public void ClairePlay()
    {
        pressPlay.SetActive(false);
        fadeOut.SetActive(true);
        charPlayingAs = 5;
        StartCoroutine(FadeToPlay());
    }
    public void TheBossPlay()
    {
        pressPlay.SetActive(false);
        fadeOut.SetActive(true);
        charPlayingAs = 6;
        StartCoroutine(FadeToPlay());
    }

    public void ArissaPlay()
    {
        pressPlay.SetActive(false);
        fadeOut.SetActive(true);
        charPlayingAs = 2;
        StartCoroutine(FadeToPlay());
    }
    public void MichellePlay()
    {
        pressPlay.SetActive(false);
        fadeOut.SetActive(true);
        charPlayingAs = 3;
        StartCoroutine(FadeToPlay());
    }

    IEnumerator FadeToPlay()
    {
        startPress.Play();
        charSelButtons[1].SetActive(false);
        charSelButtons[2].SetActive(false);
        charSelButtons[3].SetActive(false);
        charSelButtons[4].SetActive(false);
        charSelButtons[5].SetActive(false);
        charSelButtons[6].SetActive(false);
        PlayerPrefs.SetInt("MenuBackground", stageToGoTo);
        yield return new WaitForSeconds(1);
        loadText.SetActive(true);
        SceneManager.LoadScene(3);
    }

    IEnumerator ShowBlock()
    {
        yield return new WaitForSeconds(1);
        extraSpecialRight.SetActive(true);
    }

    public void ExtraRight()
    {
        theCamera.GetComponent<Animator>().Play("MoonToBlock");
        stageShowing = 1;
        extraSpecialRight.SetActive(false);
        StartCoroutine(BlockSeq());
    }

    IEnumerator BlockSeq()
    {
        rightArrow.SetActive(false);
        leftArrow.SetActive(false);
        stageName.SetActive(false);
        pressPlay.SetActive(false);
        extraSpecialRight.SetActive(false);
        yield return new WaitForSeconds(1.1f);
        blockBarrageOnly = true;
        startingBlock = true;
            stageName.GetComponent<Text>().text = "BLOCK BARRAGE";
            stageToGoTo = 1;
        stageName.SetActive(true);
        extraSpecialLeft.SetActive(true);
        extraSpecialPlay.SetActive(true);
    }

    public void PlayBlock()
    {
        pressPlay.SetActive(false);
        fadeOut.SetActive(true);
        StartCoroutine(FadeToBlocky());
    }

    IEnumerator FadeToBlocky()
    {
        startPress.Play();
        extraSpecialLeft.SetActive(false);
        extraSpecialPlay.SetActive(false);
        yield return new WaitForSeconds(1);
        loadText.SetActive(true);
        SceneManager.LoadScene(12);
    }

    public void ExtraLeft()
    {
        theCamera.GetComponent<Animator>().Play("BlockToMoon");
        stageShowing = 5;
        extraSpecialLeft.SetActive(false);
        extraSpecialPlay.SetActive(false);
        StartCoroutine(BackToMoon());
    }

    IEnumerator BackToMoon()
    {
        rightArrow.SetActive(false);
        leftArrow.SetActive(false);
        stageName.SetActive(false);
        pressPlay.SetActive(false);
        yield return new WaitForSeconds(1.1f);
        canMoveToBlock = true;
        stageName.GetComponent<Text>().text = "MENTAL MOONBASE";
        stageToGoTo = 8;
        stageName.SetActive(true);
        leftArrow.SetActive(true);
        extraSpecialRight.SetActive(true);
        pressPlay.SetActive(true);
    }

    IEnumerator ChangeToFalse()
    {
        yield return new WaitForSeconds(2);
        showingBlock = false;
    }

    IEnumerator ReleaseButtons()
    {
        yield return new WaitForSeconds(1.1f);
        pressingButton = false;
    }
}
