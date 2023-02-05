using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceenManagerNew : MonoBehaviour
{
    
    public void play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    public void QuitToHome()
    {
        SceneManager.LoadScene("HomeScene");
    }
    public void Retry()
    {
        SceneManager.LoadScene("Game");
    }
    public void Settings()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void GoBack()
    {
        SceneManager.LoadScene("HomeScene");
    }
	public void GoBackPlay()
	{
		SceneManager.LoadScene("Game");
	}
	public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game ist Quited");
    }
}
