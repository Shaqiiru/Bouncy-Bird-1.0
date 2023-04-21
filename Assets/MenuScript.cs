using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
	private void Start()
	{
		creditsPanel.SetActive(false);
	}

	public GameObject creditsPanel;

    public void PlayGame()
    {
    	SceneManager.LoadScene("SampleScene");
    	Time.timeScale = 1f;
    }

    public void Credits()
    {
    	creditsPanel.SetActive(true);
    	Time.timeScale = 0f;
    }

    public void Back()
    {
    	creditsPanel.SetActive(false);
    	Time.timeScale = 1f;
    }

    public void QuitGame()
    {
    	Application.Quit();
    	Debug.Log("quitgame");
    }

    public void BackToMenu()
    {
    	SceneManager.LoadScene("MenuScreen");
    	Time.timeScale = 1f;
    }
}
