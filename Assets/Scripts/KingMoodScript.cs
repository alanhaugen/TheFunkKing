using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KingMoodScript : MonoBehaviour
{

    public int kingsHappiness;
    public TMP_Text kingsHappText;
    
    
    // Start is called before the first frame update
    void Start()
    {
       kingsHappText.SetText(kingsHappiness.ToString());
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void HappinessUp()
    {
        kingsHappiness++;
    }
    
    public void HappinessDown()
    {
        kingsHappiness--;
    }
    
}
