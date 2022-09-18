using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private Bullet1 bullet1;
    [SerializeField] private Bullet2 bullet2;
    
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
            Debug.Log("Fire 01");
            UnityEngine.Vector3 spawnPosition = cam.position + cam.transform.forward * 3;
            Instantiate(bullet1, spawnPosition, bullet1.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Fire 01");
            UnityEngine.Vector3 spawnPosition = cam.position + cam.transform.forward * 5 + new UnityEngine.Vector3(0f, 2f, 0f);
            Instantiate(bullet2, spawnPosition, bullet1.transform.rotation);
        }
    }
}
