using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nubes : MonoBehaviour
{

    float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(2, 5);
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 30);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-speed, rb.velocity.y);
        rb.gravityScale = 0;
    }
}
