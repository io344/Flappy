using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectangleSpawner : MonoBehaviour
{
    public GameObject rect_prefabs; // pwede pala folder bonak
    public float spawnIntervals = 2f;
    float spawnTimer = 0f;
    Death playerStatus;

    void Start()
    {
        playerStatus = FindObjectOfType<Death>();
        spawnRect();
    }

    void Update()
    {
        timeofspawn();
    }

    void timeofspawn()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnIntervals)
        {
            spawnRect();
            spawnTimer = 0f;
        }

        checkplayerded();
    }

    void spawnRect() {
        float randomY = Random.Range(-1.5f, 1f); // bonak ni chatgpttt

        Vector3 spawnPos = new Vector3(10f, randomY,  0f);
        Instantiate(rect_prefabs, spawnPos, Quaternion.identity);

    }

    void checkplayerded()
    {
        if(playerStatus.isDead)
        {
            Destroy(gameObject);
        }
    }
}
