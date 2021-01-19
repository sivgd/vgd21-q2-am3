using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public float cooldownTime = 2;
    private float nextFireTime = 0;
    float mx;
    public float speed = 10f;
    public float dashDistance = 15f;
    bool isDashing;
    float doubleTapTime;
    KeyCode lastKeyCode;
    private Rigidbody2D rb;
    [SerializeField] LayerMask groundlayer;
    [SerializeField] Transform feet;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Time.time > nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                nextFireTime = Time.time + cooldownTime;
            }
        }

        if (Time.time > nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                nextFireTime = Time.time + cooldownTime;
            }
        }
        Debug.Log(nextFireTime + " " + Time.time);
       // if (Time.time < nextFireTime) return;
        //Debug.Log("ok");
        if (!isDashing)
            rb.velocity = new Vector2(mx * speed, rb.velocity.y);

        mx = Input.GetAxis("Horizontal");
        // Left
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (doubleTapTime > Time.time && lastKeyCode == KeyCode.A)
            {
               
                StartCoroutine(Dash(-1f));
            }
            else
            {
                doubleTapTime = Time.time + 0.5f;
            }

            lastKeyCode = KeyCode.A;
        }
        {
            // Right
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (doubleTapTime > Time.time && lastKeyCode == KeyCode.D)
                {
                    
                        StartCoroutine(Dash(1f));
                }
                else
                {
                    doubleTapTime = Time.time + 0.5f;
                }

                lastKeyCode = KeyCode.D;
            }
        }
       
        IEnumerator Dash(float direction)
        {
            isDashing = true;
            GameManager.globalisdashing = true;
            rb.velocity = new Vector2(rb.velocity.x, 0f);
            float tmpvx = rb.velocity.x;
           // Debug.Log(dashDistance * direction);

            rb.velocity += new Vector2(dashDistance * direction, 0f);
        //rb.AddForce(new Vector2(dashDistance * direction, 0f), ForceMode2D.Impulse);
        float gravity = rb.gravityScale;
            rb.gravityScale = 0f;
            yield return new WaitForSeconds(0.4f);
            isDashing = false;
            GameManager.globalisdashing = false;
            rb.gravityScale = gravity;
            rb.velocity = new Vector2(tmpvx, 0);

        }
    }
}

