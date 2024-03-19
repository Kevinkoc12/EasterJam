using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cesta : MonoBehaviour
{

    public Rigidbody2D rb;
    private float inputValue;
    public float moveSpeed = 25;
    private Vector2 direction;

    void Update()
    {
        move();
    }

    void move()
    {
        inputValue = Input.GetAxisRaw("Horizontal");
        if (inputValue == 1)
        {
            direction = Vector2.right;
        }
        else if (inputValue == -1)
        {
            direction = Vector2.left;

        }
        else
        {
            direction = Vector2.zero;
        }

        rb.AddForce(direction * moveSpeed * Time.deltaTime * 50);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Huevo")
        {
            Destroy(collision.gameObject);
        }
    }

}
