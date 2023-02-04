using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceenManager : MonoBehaviour
{
    
    public void play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
    public void Quit()
    {
        SceneManager.LoadScene("HomeScreen");
    }
    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Settings()
    {
        SceneManager.LoadScene("SettingsSceen");
    }
    public void GoBack()
    {
        SceneManager.LoadScene("HomeScreen");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game ist Quited");
    }
}
