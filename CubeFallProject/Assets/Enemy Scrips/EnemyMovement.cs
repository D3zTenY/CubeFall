using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

  public Vector3 speed = new Vector3(10, 10);

    public float acceleration = 1.0f;
    public float maxSpeed = 20.0f;

    private float curSpeed = 0.0f;

    public Vector3 direction = new Vector3(0, 0);

    private Vector3 movement;
    private Rigidbody2D rigidbodyComponent;

    void Update()
    {
        
        curSpeed = rigidbodyComponent.velocity.magnitude;

        if (curSpeed > maxSpeed)
            curSpeed = maxSpeed;

        movement = new Vector3(
            speed.x * direction.x,
            speed.y * direction.y,
            0);


    }
    void FixedUpdate()
    {
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        rigidbodyComponent.AddForce (movement);

        curSpeed = rigidbodyComponent.velocity.magnitude;

        if (curSpeed > maxSpeed)
            curSpeed = maxSpeed;

        movement = new Vector3(
            speed.x * direction.x,
            speed.y * direction.y,
            0);

        if (curSpeed < maxSpeed)
            rigidbodyComponent.AddForce (movement);
    }
}
