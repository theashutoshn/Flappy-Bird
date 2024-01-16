using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jumpForce = 3f; // Adjust the force as needed
    private Rigidbody2D rb;

    public int score;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Detects player input
        if (Input.GetMouseButtonDown(0) || (Input.GetKey(KeyCode.Space))) // 0 is for left click or touch
        {
            Jump();
        }

        if(transform.position.y > 4.95f)
        {
            Destroy(this.gameObject);
            Time.timeScale = 0f;
        }
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * jumpForce; // Applies upward force
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Base"))
        {
            Destroy(this.gameObject);
            Time.timeScale = 0f;

        }
    }

    //public void OnDeath()
    //{

    //}

    public void Score()
    {
        score += 1;
    }
}
