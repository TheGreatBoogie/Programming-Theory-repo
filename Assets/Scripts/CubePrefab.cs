using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class CubePrefab : MonoBehaviour
{
    private Rigidbody cubeRb;
    public float force = 500.0f;
    public UnityEngine.Vector3 torque;

    void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
        force = Random.Range(200.0f, 600.0f);
        cubeRb.AddForce(UnityEngine.Vector3.up * force * Time.deltaTime, ForceMode.Impulse);
        torque = new UnityEngine.Vector3(Random.Range(100f,300f),Random.Range(100f,300f),Random.Range(100f,300f));
        cubeRb.AddRelativeTorque(torque, ForceMode.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
