using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody bulletRb;
    private Transform cam;
    public float velocity = 100000;

    void Start()
    {
        cam = GameObject.Find("Main Camera").transform;
        bulletRb = GetComponent<Rigidbody>();

        Vector3 direction = cam.forward;

        bulletRb.AddForce(direction * velocity * Time.deltaTime, ForceMode.Impulse);

        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
