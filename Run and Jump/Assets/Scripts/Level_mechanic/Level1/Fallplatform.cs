using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallplatform : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rg;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("Hero"))
        {
            Invoke("Fallplatf", 1f);
            Destroy(gameObject, 2f);
        }
    }
    void Fallplatf()
    {
        rg.isKinematic = false;
    }
    // Update is called once per frame

}
