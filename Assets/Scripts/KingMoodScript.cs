using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KingMoodScript : MonoBehaviour
{

    public int kingsHappiness;
    public TMP_Text kingsHappText;

    //Glenn code start
    public JoyBar joyB;
    public int minJoy;
    public int currentJoy;
    public JoyBar joyBar;
    //Glenn code stop
    
    // Start is called before the first frame update
    void Start()
    {
        LoadHappinessNumber();

        //Glenn code start
        //currentJoy = minJoy;
        //joyBar.SetMinJoy(minJoy);
        //Glenn code stop
    }

    // Update is called once per frame
    void Update()
    {
        kingsHappText.SetText(kingsHappiness.ToString());

        //Glenn code start
        if(Input.GetKeyDown(KeyCode.D))
        {
            GetJoy(1);
        }
        //Glenn code stop
        joyBar.SetJoy(currentJoy);

    }

    //Glenn code start
    void GetJoy(int joy)
    {
        currentJoy += joy;

        joyBar.SetJoy(currentJoy);

    }
    //Glenn code stop

    public void HappinessUp()
    {
        kingsHappiness++;
    }
    
    public void HappinessDown()
    {
        kingsHappiness--;
    }

    public void SaveHappinessNumber()
    {
        PlayerPrefs.SetInt("kingsHappyValue", kingsHappiness);
        PlayerPrefs.SetInt("Joy", currentJoy);
    }
    
    public void LoadHappinessNumber()
    {
        kingsHappiness = PlayerPrefs.GetInt("kingsHappyValue");
        currentJoy = PlayerPrefs.GetInt("Joy");
    }
    
    public void ClearHappinessNumber()
    {
        PlayerPrefs.SetInt("kingsHappyValue", 0);
        PlayerPrefs.SetInt("Joy", 0);
    }
}
