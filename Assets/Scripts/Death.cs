using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public CircleCollider2D cc;
    public GameObject UIprefab; 
    public bool isDead;
    public GameObject death_particle;
    public Fly fly;
    public SoundManager sm;

    void Start()
    {
        isDead = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trap"))
        {
            killed();
            makeDeathScreen();
        }
    }

    
    void killed()
    {
        isDead = true;
        fly.enabled = false; // to stop the annoying sound!
        rb.bodyType = RigidbodyType2D.Static;
        Instantiate(death_particle, transform.position, Quaternion.identity);
        sm.PlaySound(1);
        sr.enabled = false;
        cc.enabled = false;
    }

    void makeDeathScreen()
    {
        if (isDead)
        {
            Instantiate(UIprefab, Vector3.zero, Quaternion.identity);
        }
    }
}
