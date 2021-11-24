using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D phis;
    public Transform player;
    public float speed;
    public float DistAgr;
    private Animator anim;
    void Start()
    {
        phis = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float disToPlayer = Vector2.Distance(transform.position, player.position);
        if(disToPlayer<DistAgr)
        {
            StarHant();
        }
        else
        {
            StopHant();
        }

    }
    void StarHant()
    {
        if(player.position.x <transform.position.x)
        {
            phis.velocity = new Vector2(-speed, 0);
            anim.SetBool("Running", true);
            transform.localScale = new Vector2(1, 1);
        }
        else if (player.position.x > transform.position.x)
        {
            phis.velocity = new Vector2(speed, 0);
            anim.SetBool("Running", true);
            transform.localScale = new Vector2(-1, 1);
        }
    }
    void StopHant()
    {
        phis.velocity = new Vector2(0, 0);
        anim.SetBool("Running", false);
    }
}
