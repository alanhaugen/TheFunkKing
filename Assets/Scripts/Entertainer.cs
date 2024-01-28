using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Entertainer : MonoBehaviour
{
    public string resume = "I am a court jester!";
    public string name = "Big Money Man";
    public int entertainerId;
    public int skill = 50;
    public string style = "Joker";
    public GameObject profileBoothRoomAppearance;
    public GameObject sideKingRoomAppearance;
    private GameObject canvas;
    public TMP_Text textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        //canvas = GameObject.Find("Canvas");
        //textMeshPro = canvas.GetComponent<TextMeshPro>();
        textMeshPro.text = resume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
