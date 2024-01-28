using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public SceneMover _sceneMover;
    public int entertainerID;

    private int minChar = 1;
    public int TotalCharacters = 7;

    private GameObject activeEntertainer;
    public GameObject entertainer1;
    public GameObject entertainer2;
    public GameObject entertainer3;
    public GameObject entertainer4;
    public GameObject entertainer5;
    public GameObject entertainer6;

    public KingMoodScript _KingMoodScript;
    // Start is called before the first frame update
    void Start()
    {
        entertainer1.SetActive(false);
        entertainer2.SetActive(false);
        entertainer3.SetActive(false);
        entertainer4.SetActive(false);
        entertainer5.SetActive(false);
        entertainer6.SetActive(false);

        entertainerID = PlayerPrefs.GetInt("entertainerID");

        switch(entertainerID)
        {
            case 1:
                entertainer1.SetActive(true);
                activeEntertainer = entertainer1;
                break;
            case 2:
                entertainer2.SetActive(true);
                activeEntertainer = entertainer2;
                break;
            case 3:
                entertainer3.SetActive(true);
                activeEntertainer = entertainer3;
                break;
            case 4:
                entertainer4.SetActive(true);
                activeEntertainer = entertainer4;
                break;
            case 5:
                activeEntertainer = entertainer5;
                entertainer5.SetActive(true);
                break;
            case 6:
                activeEntertainer = entertainer6;
                entertainer6.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown("a") /*&& _sceneMover.currentScene == "EiriksTestScene"*/)
        {
            PlayerPrefs.SetInt("entertainerID", entertainerID);
            _sceneMover.BackAndForth();
        }
        
        if (Input.GetKeyDown("d") && _sceneMover.currentScene == "EiriksTestScene")
        {
            // Get a random new character to present to the player
            entertainerID = entertainerID + 1;

            if (entertainerID >= TotalCharacters)
            {
                entertainerID = minChar;
            }

            activeEntertainer.SetActive(false);

            switch (entertainerID)
            {
                case 1:
                    entertainer1.SetActive(true);
                    activeEntertainer = entertainer1;
                    break;
                case 2:
                    entertainer2.SetActive(true);
                    activeEntertainer = entertainer2;
                    break;
                case 3:
                    entertainer3.SetActive(true);
                    activeEntertainer = entertainer3;
                    break;
                case 4:
                    entertainer4.SetActive(true);
                    activeEntertainer = entertainer4;
                    break;
                case 5:
                    activeEntertainer = entertainer5;
                    entertainer5.SetActive(true);
                    break;
                case 6:
                    activeEntertainer = entertainer6;
                    entertainer6.SetActive(true);
                    break;
            }

            // Generate new character and present it to the player
            //SpawnEntertainer();

            // Not sure why this is here? Leaving it out...
            //_KingMoodScript.HappinessUp();
        }
    }
}
