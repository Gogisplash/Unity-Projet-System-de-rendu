using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public float speed; // Vitesse du bateau
    public float turnSpeed; // Vitesse de rotation du bateau

    public float maxSpeed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {

        float moveVertical = Input.GetAxis("Vertical");

        float moveHorizontal = Input.GetAxis("Horizontal");

        

        Vector3 movement = transform.forward * moveVertical * speed * rb.mass;
        Quaternion turn = Quaternion.Euler(0.0f, moveHorizontal * turnSpeed * Time.deltaTime, 0.0f);

        //Boat Movement 
        if(rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(movement);
            //Debug.Log(rb.velocity.magnitude);
        }
       
        
        
        rb.MoveRotation(rb.rotation * turn); // Application de la rotation au Rigidbody du bateau


        

    }
}
