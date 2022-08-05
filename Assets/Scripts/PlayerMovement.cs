using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalMov;
    public float verticalMov;
    public float speed;
    public float jumpforce;
    public bool isJumping = false;
    private Rigidbody2D rb2d;
    bool isJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalMov = Input.GetAxisRaw("Horizontal") * speed;
        verticalMov = Input.GetAxisRaw("Vertical") * speed;

        if (verticalMov > 0f)
        {
            isJump = true;
        }
    }

    void FixedUpdate()
    {

        if (horizontalMov > 0.1f || horizontalMov < -0.1f)
        {
            rb2d.AddForce(new Vector2(horizontalMov * speed, 0f), ForceMode2D.Impulse);
        }

        if (verticalMov > 0f && !isJumping)
        {
            rb2d.AddForce(new Vector2(0f, jumpforce * verticalMov), ForceMode2D.Impulse);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

            isJumping = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = true;
        }

    }
}
