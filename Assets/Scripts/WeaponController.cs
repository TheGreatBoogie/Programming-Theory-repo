using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullet2;
    
    private Transform cam;

    void Start()
    {
        cam = GameObject.Find("Main Camera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    public void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            UnityEngine.Vector3 spawnPosition = cam.position + cam.transform.forward * 3;
            Instantiate(bullet, spawnPosition, bullet.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            UnityEngine.Vector3 spawnPosition = cam.position + cam.transform.forward * 5 + new UnityEngine.Vector3(0f, 2f, 0f);
            Instantiate(bullet2, spawnPosition, bullet.transform.rotation);
        }
    }
}
