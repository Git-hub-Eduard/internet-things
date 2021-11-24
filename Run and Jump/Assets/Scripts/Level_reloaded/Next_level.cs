using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next_level : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Level_controller.instance.isEndGame();
    }
}
