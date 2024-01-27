using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesButton : MonoBehaviour
{
    private KingMoodScript _kingMoodScr;
    public GameObject scriptManager;
    
    // Start is called before the first frame update
    void Start()
    {
        _kingMoodScr = GetComponentInParent<KingMoodScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        _kingMoodScr.HappinessUp();
    }
}
