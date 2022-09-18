using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Bullet2 : ProjectileController // INHERITANCE
{

    protected override void Awake()
    {
        velocity = 20000.0f;
        base.Awake();
    }

    private void LateUpdate()
    {
        FireModifier();
    }


    protected override void Fire()  // POLYMORPHISM
    {
        bulletRb.AddForce(direction * velocity * Time.deltaTime, ForceMode.Impulse);
    }

    private void FireModifier()
    {
        base.GetDirection();

        bulletRb.AddForce(direction * velocity / 10.0f * Time.deltaTime, ForceMode.Force);
    }

}
