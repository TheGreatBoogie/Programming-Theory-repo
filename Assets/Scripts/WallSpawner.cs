using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{

    public GameObject brick;
    private Transform spawner;
    public int wallSize = 10;


    void Start()
    {
        spawner = GameObject.Find("WallSpawner").transform;

        CreateWall();

        
    }

    public void CreateWall()
    {
        float brickSize = brick.GetComponent<BoxCollider>().bounds.size.x;

        for (int i = 0; i < wallSize; i++)
        {

            for (int j = 0; j < wallSize; j++)
            {
   
                Vector3 position = new Vector3(spawner.position.x + i + 0.5f, spawner.position.y + j + 0.5f, spawner.position.z + 0.5f);
                Instantiate(brick, position , brick.transform.rotation);

            }

        }
    }

}
