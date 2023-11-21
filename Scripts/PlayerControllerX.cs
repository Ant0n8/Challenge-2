using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float spawnCooldown = 2.0f;
    private float lastSpawnTime;
    private bool canSpawn = true;

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastSpawnTime >= spawnCooldown)
        {
            canSpawn = true;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            lastSpawnTime = Time.time;
            canSpawn = false;
        }
    }
}