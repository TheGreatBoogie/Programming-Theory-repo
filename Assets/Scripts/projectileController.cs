using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProjectileController : MonoBehaviour
{

    protected Rigidbody bulletRb;
    protected Transform cam;
    [SerializeField] private float _velocity;
    public float velocity // ENCAPSULATION
    {
        get { return _velocity;}
        set {_velocity = value;}
    }

    protected Vector3 direction;

    protected virtual void Awake()
    {
        cam = GameObject.Find("Main Camera").transform;
        bulletRb = GetComponent<Rigidbody>();
        GetDirection();
        Fire(); // ABSTRACTION
    }

    protected virtual void Fire()
    {
        bulletRb.AddForce(direction * velocity * Time.deltaTime, ForceMode.Impulse);
    }

    protected void GetDirection()
    {
        direction = cam.forward;
    }
}
