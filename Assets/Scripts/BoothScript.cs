using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoothScript : MonoBehaviour
{

    private int minChar = 1;
    public int maxChar =7;
    public float RadNum = 0f;

    // Start is called before the first frame update
    void Start()
    {
        RadNum=Random.Range(minChar,maxChar);

        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
