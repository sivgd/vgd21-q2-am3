using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDamageTrigger : MonoBehaviour
{

    private Rigidbody2D rb2;
    public GameObject spawnpoint;
    public GameObject Player;
    public HealthBar script2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        script2.health -= 1;
    }

    public void HealthMax()
    {
        script2.health += 3;
    }


    void Update()
    {
        script2.slider.value = script2.health;
        
        if (script2.health == 0)
        {
            rb2 = Player.GetComponent<Rigidbody2D>();
            rb2.velocity = new Vector2(0, 0);
            Player.transform.localPosition = spawnpoint.transform.localPosition;
            HealthMax();
        }

    }






}






