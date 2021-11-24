using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vic : MonoBehaviour
{
    public GameObject Player;
    public GameObject UI_victory;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(Player.tag == collision.tag)
        {
            UI_victory.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
