using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public bool isRunning = true;

    void Start()
    {
        StartCoroutine(SpawnCube());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCube()
    {
        while(isRunning)
        {
            yield return new WaitForSeconds(0.001f);
            Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
        }
        

    }



}
