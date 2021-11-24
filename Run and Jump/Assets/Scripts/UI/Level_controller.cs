using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_controller : MonoBehaviour
{
    public static Level_controller instance = null;
    int sceneIndex;
    int LevelComplete;

    // Start is called before the first frame update
    void Start()
    {
        if(instance ==null)
        {
            instance = this;
        }
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        LevelComplete = PlayerPrefs.GetInt("LevelComplete");
    }
    public void isEndGame()
    {
        if(sceneIndex==3)
        {
            Invoke("LoadMainMenu", 1f);

        }
        else
        {
            if(LevelComplete<sceneIndex)
            {
                PlayerPrefs.SetInt("LevelComplete", sceneIndex);
            }
            Invoke("Next_Level", 1f);
        }
    }
    // Update is called once per frame
    void Next_Level()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
    void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
