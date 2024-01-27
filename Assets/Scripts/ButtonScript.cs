using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public SceneMover _sceneMover;
    public int entertainerID;

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
            entertainerID++;
            _KingMoodScript.HappinessUp();
        }
    }
}
