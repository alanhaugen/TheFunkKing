using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class EntertainerManager : MonoBehaviour
{
    public GameObject[] entertainers;
    public GameObject currentEntertainer;
    
    public static Sprite chosenEntertainerSprite;
    public static int chosenEntertainerID;
    
    private Camera cam;
    public TMP_Text text;
    private SceneMover _sceneMover;

    public EntertainerManager entertainmentManager;
    public KingMoodScript _KingMoodScript;

    void Start()
    {
        _sceneMover = GameObject.Find("Script Manager").GetComponent<SceneMover>();
        cam = Camera.main;
        
        if (SceneManager.GetActiveScene().name != "ThroneRoom")
        {
            InstantiateRandomEntertainer();
        }
    }

    private void InstantiateRandomEntertainer()
    {
        if (currentEntertainer != null)
        {
            Destroy(currentEntertainer);
        }
        
        currentEntertainer = Instantiate(entertainers[Random.Range(0, entertainers.Length)], transform.position,
            Quaternion.identity);
        currentEntertainer.GetComponent<Entertainer>().textMeshPro = text;
        text.text = currentEntertainer.GetComponent<Entertainer>().resume;
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "ThroneRoom") return;
        
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            Physics.Raycast(ray, out hit, 100f);
            
            if (hit.collider.CompareTag("Yes"))
            {
                chosenEntertainerSprite = currentEntertainer.GetComponentInChildren<SpriteRenderer>().sprite;
                chosenEntertainerID = currentEntertainer.GetComponent<Entertainer>().entertainerId;
                _KingMoodScript.currentJoy += (entertainmentManager.currentEntertainer.GetComponent<Entertainer>().skill) / 50;

                if (_KingMoodScript.currentJoy < 0)
                {
                    _KingMoodScript.currentJoy = 0;
                }
                if (_KingMoodScript.currentJoy > 10)
                {
                    SceneManager.LoadScene("Gameover");
                }

                _sceneMover.BackAndForth();
            }
            else if (hit.collider.CompareTag("No"))
            {
                InstantiateRandomEntertainer();
            }
        }
    }
}
