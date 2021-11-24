using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_health_system : MonoBehaviour
{
    // Start is called before the first frame update
    private int health = 3;
    private int damage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name=="Hero")
        {
            collision.GetComponent<Health_system>().TakeDamge(damage);
        }
    }
    public void TakeDamage(int amount)
    {
        health = health - amount;
        if(health<=0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }



}
