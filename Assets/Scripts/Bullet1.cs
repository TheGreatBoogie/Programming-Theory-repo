using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Bullet1 : ProjectileController // INHERITANCE
{

    protected override void Awake()
    {
        velocity = 100000.0f;
        base.Awake();
    }




    protected override void Fire()  // POLYMORPHISM
    {
        bulletRb.AddForce(direction * velocity * Time.deltaTime, ForceMode.Impulse);
    }


}
