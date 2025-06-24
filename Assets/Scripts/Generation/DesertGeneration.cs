using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertGeneration : MonoBehaviour
{
    public GameObject[] blockSection;
    public int numberGen;
    public int zPos = 0;
    public GameObject timPlay;
    public GameObject doozPlay;
    public GameObject clairePlay;
    public GameObject theBossPlay;
    public GameObject arissaPlay;
    public GameObject michellePlay;
    public GameObject fakeCam;
    public int pickChar;
    public bool generatingBlock = false;

    void Start()
    {
        pickChar = StageSelect.charPlayingAs; 

        if (pickChar == 1)
        {
            timPlay.SetActive(true);
        }
        if (pickChar == 2)
        {
            arissaPlay.SetActive(true);
        }
        if (pickChar == 3)
        {
            michellePlay.SetActive(true);
        }
        if (pickChar == 4)
        {
            doozPlay.SetActive(true);
        }
        if (pickChar == 5)
        {
            clairePlay.SetActive(true);
        }
        if (pickChar == 6)
        {
            theBossPlay.SetActive(true);
        }

        fakeCam.SetActive(false);
        numberGen = Random.Range(1, 6);
        blockSection[numberGen].SetActive(true);
        Instantiate(blockSection[numberGen], new Vector3(0, 0, zPos), Quaternion.identity);
        blockSection[numberGen].SetActive(false);
        zPos += 200;
    }

    void OnTriggerEnter(Collider other)
    {
        if (generatingBlock == false)
        {
            generatingBlock = true;
            StartCoroutine(GenerateNext());
        }
    }


    IEnumerator GenerateNext()
    {
        yield return new WaitForSeconds(1);
        numberGen = Random.Range(1, 6);
        blockSection[numberGen].SetActive(true);
        Instantiate(blockSection[numberGen], new Vector3(0, 0, zPos), Quaternion.identity);
        blockSection[numberGen].SetActive(false);
        zPos += 200;
        transform.position = new Vector3(0, 3, zPos - 200);
        generatingBlock = false;
    }

}
