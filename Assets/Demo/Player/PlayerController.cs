using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;
    private Rigidbody2D _rigidbody;
    public bool Turned = true;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
   // Flip is a script used for projectiles. Connor. 
    private void Flip()
    {
        Turned = !Turned;

        transform.Rotate(0f, 180f, 0f);

    }

    
    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;


        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);


        }

        //this stuff rotates the character upon turning. need it for the projectiles. Connor.
            if (Input.GetAxis("Horizontal") > 0 && !Turned)
            {
                Flip();
            }

            if (Input.GetAxis("Horizontal") < 0 && Turned)
            {
                Flip();
            }

    }

}
