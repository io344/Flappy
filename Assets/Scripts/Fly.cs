using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{ 
    public float flyForce = 5f;
    private Rigidbody2D rb;
    public SoundManager sm;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            flyCircle();
            sm.PlaySound(0);
        }
    }

    void flyCircle()
    {
        rb.velocity = Vector2.up * flyForce;
    }
}
