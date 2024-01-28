using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public int character;
    private SpriteRenderer _spriteRenderer;
    private Animator animator;
    public AnimatorController[] _Controller;
    
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = EntertainerManager.chosenEntertainerSprite;
        animator = GetComponent<Animator>();
        ChooseCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        ClownCatMoveForward();
    }


    private void ChooseCharacter()
    {
        switch (EntertainerManager.chosenEntertainerID)
        { 
            case 0:
                ClownCatMoveForward();
            break;
            
            case 1:
                WheelChairMove();
                animator.runtimeAnimatorController = _Controller[1];
                animator.Play("walk");
            break;
            case 2:
                animator.runtimeAnimatorController = _Controller[2];
                animator.Play("shark");
                break;
            case 3:
                animator.runtimeAnimatorController = _Controller[3];
                animator.Play("shark");
                break;
            case 4:
                animator.runtimeAnimatorController = _Controller[4];
                animator.Play("shark");
                break;
            case 5:
                animator.runtimeAnimatorController = _Controller[5];
                animator.Play("shark");
                break;
            case 6:
                animator.runtimeAnimatorController = _Controller[6];
                animator.Play("shark");
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
        transform.Rotate(0f, 0f, 45f);
        
        if (transform.position.x < -8)
        {
            // Increase the X position until it reaches 20
            transform.position += new Vector3(50f, 0f, 0f) * Time.deltaTime;
        }

        if (transform.position.x > -7.5f)
        {
            animator.Play("idel");
            transform.Rotate(0f, 0f, 0f);
        }
    }
}
