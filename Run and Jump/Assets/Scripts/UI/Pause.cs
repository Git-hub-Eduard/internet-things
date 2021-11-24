using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIspause = false;
    public GameObject pause_menu;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIspause)
            {
                Resume();
            }
            else 
            {
                Paus();
            }
        }
    }
    public void Resume()
    {
        pause_menu.SetActive(false);
        Time.timeScale = 1f;
        GameIspause = false;
    }
    void Paus()
    {
        pause_menu.SetActive(true);
        Time.timeScale = 0f;
        GameIspause = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
