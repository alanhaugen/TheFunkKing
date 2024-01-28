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
    public AudioManeger _audioManager;

    private void Start()
    {
        PlayerPrefs.SetInt("entertainerID", 0);
        kingMood.ClearHappinessNumber();



    }
    public void PlayGame()
    {
        _audioManager.PlayGameMusic();
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
