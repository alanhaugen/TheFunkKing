using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour
{
    private KingMoodScript _kingMoodScript;
    public string currentScene;
    
    // Start is called before the first frame update
    void Start()
    {
        _kingMoodScript = GetComponent<KingMoodScript>();
        currentScene = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void BackAndForth()
    {
        if ( currentScene == ("EiriksTestScene"))
        {
            SceneManager.LoadScene("ThroneRoom");
        }
        else
        {
            _kingMoodScript.SaveHappinessNumber();
            SceneManager.LoadScene("EiriksTestScene");
        }
    }
}
