using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 50;
    private SpriteRenderer sr;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        sr = GetComponent<SpriteRenderer>();
    }



    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);

    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            sr.flipX = false;
        }

        else
        {
            sr.flipX = true;
        }
    }
}
