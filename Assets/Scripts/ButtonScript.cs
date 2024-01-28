using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public SceneMover _sceneMover;
    public int entertainerID;

    
    private int minChar = 1;
    public int TotalCharacters = 7;

    public KingMoodScript _KingMoodScript;
    // Start is called before the first frame update
    void Start()
    {
        entertainerID = PlayerPrefs.GetInt("entertainerID");
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
            entertainerID = Random.Range(minChar, TotalCharacters);

            // Generate new character and present it to the player
            //SpawnEntertainer();

            // Not sure why this is here? Leaving it out...
            //_KingMoodScript.HappinessUp();
        }
    }
}
