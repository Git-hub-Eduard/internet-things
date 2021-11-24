using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_laod : MonoBehaviour
{
    // Start is called before the first frame update
    float dirC;
    float speed = 3f;
    bool movingRight = true;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>7f)
        {
            movingRight = false;
        }
        if (transform.position.x<-2f)
        {
            movingRight = true;
        }
        if(movingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
