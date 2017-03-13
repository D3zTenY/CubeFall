using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAcceleration : MonoBehaviour
{


    public float acceleration = 1.0f;
    public float maxSpeed = 200.0f;

    private float curSpeed = 0.0f;

    void Update()
    {

        transform.Translate(Vector3.forward * curSpeed);

        curSpeed += acceleration;

        if (curSpeed > maxSpeed)
            curSpeed = maxSpeed;

    }

}
