using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public KingMoodScript kingMood; 
    private void Start()
    {
        PlayerPrefs.SetInt("entertainerID", 0);
        kingMood.ClearHappinessNumber();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    
    public void GTSettings()
    {
        SceneManager.LoadScene(2);
    }
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
