using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDamageTrigger : MonoBehaviour
{

    public int health;
    public Slider healthBar;
    private Rigidbody2D rb2;
    public GameObject spawnpoint;
    public GameObject Player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        health -= 1;
    }

    public void HealthMax()
    {
        health += 6;
    }


    void Update()
    {
        healthBar.value = health;
        
        if (health == 0)
        {
            rb2 = Player.GetComponent<Rigidbody2D>();
            rb2.velocity = new Vector2(0, 0);
            Player.transform.localPosition = spawnpoint.transform.localPosition;
            HealthMax();
        }

    }






}






