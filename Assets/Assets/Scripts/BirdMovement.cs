using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float flapForce = 200f;
    private Rigidbody2D rb2D;
    private bool isDead = false;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isDead)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                Flap();
            }
        }
    }

    void Flap()
    {
        rb2D.velocity = Vector2.zero;
        rb2D.AddForce(new Vector2(0, flapForce));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        rb2D.velocity = Vector2.zero;
        rb2D.AddForce(new Vector2(0, -200f)); // Kuþun yere düþmesini saðlar
    }
}
