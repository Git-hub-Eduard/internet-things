using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject respaun;
    public GameObject UI_game_victory;
    public void Finish()
    {
        SceneManager.LoadScene("Victory");
        UI_game_victory.SetActive(false);
        Time.timeScale = 1f;

    }
}
