using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour

    {
    public float MovementSpeed = 1;
    public float JumpForce = 1;
    private Rigidbody2D _rigidbody;
    private bool doublejump;
    private BoxCollider2D box2d;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        box2d = transform.GetComponent<BoxCollider2D>();
    }

   
    private void Update()
    {



        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 40f;
            _rigidbody.velocity = Vector2.up * jumpVelocity;
        }


        }
        private bool IsGrounded()
    {
         RaycastHit2D raycasthit2d = Physics2D.BoxCast(box2d.bounds.center, box2d.bounds.size, 0f, Vector2.down * .1f);
        Debug.Log(raycasthit2d.collider);
        return raycasthit2d.collider != null;
         }
     }

   
