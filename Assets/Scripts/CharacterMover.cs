using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public int character;
    // Start is called before the first frame update
    void Start()
    {
        ChooseCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        ClownCatMoveForward();
    }


    private void ChooseCharacter()
    {
        switch (character)
        { 
            case 1:
                ClownCatMoveForward();
            break;
            
            case 2:
                WheelChairMove();
            break;
    }
    }
    private void ClownCatMoveForward()
    {
        if (transform.position.x < -8)
        {
            // Increase the X position until it reaches 20
            transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime;
        }
    }

    private void WheelChairMove()
    {
        if (transform.position.x < -8)
        {
            // Increase the X position until it reaches 20
            transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime;
        }
    }
}
