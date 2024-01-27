using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public SceneMover _sceneMover;

    public KingMoodScript _KingMoodScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a") /*&& _sceneMover.currentScene == "EiriksTestScene"*/)
        {
            _sceneMover.BackAndForth();
        }
        
        if (Input.GetKeyDown("d") && _sceneMover.currentScene == "EiriksTestScene")
        {
            _KingMoodScript.HappinessUp();
        }
    }
}
