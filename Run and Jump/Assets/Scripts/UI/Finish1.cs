using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish1 : MonoBehaviour
{
    // Start is called before the first frame updat

    // Update is called once per frame
    
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Level_controller.instance.isEndGame();
    }
}
