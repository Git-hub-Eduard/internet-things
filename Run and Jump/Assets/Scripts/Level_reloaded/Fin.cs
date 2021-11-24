using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Finish;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name=="Hero")
        {
            Finish.SetActive(true);
            Time.timeScale = 1f;
        }
    }
}
