using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectangleMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    Death playerStatus;
    bool isMoving = true;

    void Start()
    {
        playerStatus = FindObjectOfType<Death>();
    }

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

            if (transform.position.x < -10f)
            {
                Destroy(gameObject);
            }
        }

        checkplayer();
        
    }

    void checkplayer()
    {
        if(playerStatus.isDead == true)
        {
            transform.position = transform.position;
            isMoving = false;
        }
    }
}
