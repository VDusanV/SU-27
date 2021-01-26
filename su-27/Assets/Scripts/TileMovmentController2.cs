using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovmentController2 : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;

    [SerializeField]
    float accelerationPower = 5f;
    [SerializeField]
    float steeringPower = 5f;
    [SerializeField]
    float maxSpeed = 5f;

    float steeringAmount, speed, direction;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
            steeringAmount = -Input.GetAxis("Horizontal1");
       
           
      
            speed = Input.GetAxis("Vertical1") * accelerationPower;
       


        rb.rotation += steeringAmount * steeringPower;


        rb.AddRelativeForce(Vector2.up * speed);
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
        // rb.AddRelativeForce(-Vector2.right * rb.velocity.magnitude * steeringAmount / 2);

    }
}
