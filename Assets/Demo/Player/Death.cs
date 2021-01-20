using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject spawnpoint;
    public GameObject mainPlayer;
    private Rigidbody2D rb2;
    public HealthBar script2;

    public void MaxHealth()
    {
        script2.slider.maxValue = script2.health;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            rb2 = mainPlayer.GetComponent<Rigidbody2D>();
            rb2.velocity = new Vector2(0, 0);
            mainPlayer.transform.localPosition = spawnpoint.transform.localPosition;
            MaxHealth();
        }
    }

    private void Update()
    {
        script2.slider.value = script2.health;
    }
}
