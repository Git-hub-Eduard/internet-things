using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health_system : MonoBehaviour
{
    // Start is called before the first frame update
    public int health ;
    public int numberOfLives;
    public Image[] livs;
    public Sprite fullLive;
    public Sprite emptyLive;
    private Animator anim;



    // Update is called once per frame
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
      if(health>numberOfLives)
      {
         health = numberOfLives;
      }
      for(int i = 0; i<livs.Length;i++)
      {
            if(i<health)
            {
                livs[i].sprite = fullLive;
            }
            else
            {
                livs[i].sprite = emptyLive;
            }
            if(i<numberOfLives)
            {
                livs[i].enabled = true;
            }
            else 
            {
                livs[i].enabled = false;
            }
      }
    }
    public void TakeDamge(int damage)
    {
        
        health = health - damage;
        
        if (health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        
        SceneManager.LoadScene(1);
    }
}
