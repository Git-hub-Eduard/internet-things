using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_up_down : MonoBehaviour
{
    // Start is called before the first frame update
    float dirC;
    float speed = 3f;
    bool movingUP = true;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 3f)
        {
            movingUP = false;
        }
        if (transform.position.y < -4f)
        {
            movingUP = true;
        }
        if (movingUP)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
    }
}
