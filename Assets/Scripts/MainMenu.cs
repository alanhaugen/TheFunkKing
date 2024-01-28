using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int minJoy = 0;
    public int currentJoy;
    public JoyBar joyBar;
    public KingMoodScript kingMood; 
    private void Start()
    {
        PlayerPrefs.SetInt("entertainerID", 0);
        kingMood.ClearHappinessNumber();


        currentJoy = minJoy;
        joyBar.SetMinJoy(minJoy);

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
