using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class brickwallBehaviour : MonoBehaviour
{
    private Rigidbody objectRb;
    private GameObject player;
     float minSize = 1.0f;
     float maxSize = 1.0f;
    private float finalSize;
    public float proximityFieldRadius = 10.0f;
    public float proximityFieldForce = 10.0f;

    public float attraction = 100.0f;

    void Start()
    {
        player = GameObject.Find("Player");
        objectRb = GetComponent<Rigidbody>();
        objectRb.Sleep();
        finalSize = Random.Range(minSize, maxSize);
    }

    void Update()
    {
        // if (objectRb.velocity.magnitude > .1f)
        // {
        //     transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(finalSize , finalSize, finalSize), Time.deltaTime * 2);
        // }

        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            UnityEngine.Vector3 direction = (player.transform.position - transform.position).normalized;
            objectRb.AddForce(direction * attraction * Time.deltaTime , ForceMode.Force);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            objectRb.useGravity = true;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            objectRb.useGravity = false;
        }
        
        if (Input.GetKeyDown(KeyCode.T))
        {
            Destroy(gameObject);
        }



        UnityEngine.Vector3 proximity = transform.position - player.transform.position;

        if (proximity.magnitude < proximityFieldRadius)
        {
            objectRb.AddForce(proximity * proximityFieldForce * Time.deltaTime , ForceMode.Impulse);
        }


    }





}
