using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileController : MonoBehaviour
{

    private GameObject player;
    private Rigidbody projectilRb;
    private Transform cam;
    public float projectilVelocity = 100f;
    void Start()
    {
        cam = GameObject.Find("Main Camera").transform;
        player = GameObject.Find("ThirdPersonPlayer");
        projectilRb = GetComponent<Rigidbody>();
        projectilRb.AddForce(cam.forward * projectilVelocity * Time.deltaTime, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
