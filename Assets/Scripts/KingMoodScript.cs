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
    public int minJoy = 0;
    public int currentJoy;
    public JoyBar joyBar;
    //Glenn code stop
    
    // Start is called before the first frame update
    void Start()
    {
        LoadHappinessNumber();

        //Glenn code start
        currentJoy = minJoy;
        joyBar.SetMinJoy(minJoy);
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
    }
    
    public void LoadHappinessNumber()
    {
        kingsHappiness = PlayerPrefs.GetInt("kingsHappyValue");
    }
    
    public void ClearHappinessNumber()
    {
        PlayerPrefs.SetInt("kingsHappyValue", 0);
    }
}
