using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resum : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject respaun;
    public GameObject UI_game_over;
    public void Resume()
    {
        Player.transform.position = respaun.transform.position;
        UI_game_over.SetActive(false);
        Time.timeScale = 1f;

    }
}
