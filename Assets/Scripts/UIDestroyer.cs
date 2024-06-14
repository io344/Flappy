using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDestroyer : MonoBehaviour
{
    [SerializeField] Death playerStatus;
    void Update()
    {
        if (playerStatus.isDead)
        {
            Destroy(gameObject);
        }
    }
}
