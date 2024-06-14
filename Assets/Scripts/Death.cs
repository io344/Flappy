using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject UIprefab; 
    public bool isDead;
    public GameObject death_particle;
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
        }
    }

    
    void killed()
    {
        isDead = true;
        Destroy(gameObject);
        Instantiate(death_particle, transform.position, Quaternion.identity);
        sm.PlaySound(1);
        makeDeathScreen();
    }

    void makeDeathScreen()
    {
        if (isDead)
        {
            Instantiate(UIprefab, Vector3.zero, Quaternion.identity);
        }
    }
}
