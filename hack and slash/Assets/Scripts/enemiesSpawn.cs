using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesSpawn : MonoBehaviour
{
    public GameObject cam, enemies;
    public bool readyToSpawn = true;
    public GameObject[] spawnTransform;
    public float second = 2;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        spawnTransform = GameObject.FindGameObjectsWithTag("spawnPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (readyToSpawn)
            spawn();
    }
    public void spawn()
    {
        Instantiate(enemies, spawnTransform[Random.Range(0, 2)].transform.position, enemies.transform.rotation, this.transform);
        readyToSpawn = false;
        StartCoroutine(waiting());
    }
    IEnumerator waiting()
    {
        yield return new WaitForSeconds(second);
        readyToSpawn = true;
    }
}
