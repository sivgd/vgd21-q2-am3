using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    private Animator anim;
    public float jumpPower = 15f;
    public int extraJumps = 1;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Transform feet;
    public bool Turned = true;

    int jumpCount = 0;
    bool isGrounded;
    float mx;
    float jumpCoolDown;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        mx = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        CheckGrounded();


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
    private void FixedUpdate()
    {
        anim.SetFloat("walkspeed", Mathf.Abs(rb.velocity.x));
        if (GameManager.globalisdashing == false)
        {
            rb.gravityScale = 7.5f;

            rb.velocity = new Vector2(mx * speed, rb.velocity.y);
            anim.Play("walkcycle2");
        }
    }
    // Flip is a script used for projectiles. Connor. 
    private void Flip()
    {
        Turned = !Turned;

        transform.Rotate(0f, 180f, 0f);

    }

    void Jump()
    {
        if (isGrounded || jumpCount < extraJumps)
        {



            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jumpCount++;
        }
    }

    void CheckGrounded()
    {
        if (Physics2D.OverlapCircle(feet.position, 0.5f, groundLayer))
        {
            isGrounded = true;
            jumpCount = 0;
            jumpCoolDown = Time.time + 0.2f;

        }
        else if (Time.time < jumpCoolDown)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

}