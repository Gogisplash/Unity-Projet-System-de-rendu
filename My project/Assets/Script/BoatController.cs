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















    ////Physics variables
    //public float mass = 1000f;
    //public float drag = 0.1f;
    //public float angularDrag = 0.1f;

    ////Mouvement variables
    //public float forwardSpeed = 10f;
    //public float backwardSpeed = 5f;
    //public float turnSpeed = 100f;

    ////Component
    //private Rigidbody rb;
    //private Transform tr;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    tr = transform;

    //    rb.mass = mass;
    //    rb.drag = drag;
    //    rb.angularDrag = angularDrag;
    //}

    //private void FixedUpdate()
    //{
    //    //Déplacement avant et arrière
    //    float forwardInput = Input.GetAxis("Vertical");
    //    float forwardVelocity = forwardInput * forwardSpeed;
    //    float backWardVelocity = forwardInput * backwardSpeed;

    //    //Tourner
    //    float turnInput = Input.GetAxis("Horizontal");
    //    float turnVelocity = turnInput * turnSpeed;

    //    //Forces
    //    Vector3 forwardForce = tr.forward * forwardVelocity * rb.mass;
    //    Vector3 backwardForce = -rb.velocity * backWardVelocity * rb.mass;
    //    Vector3 torque = tr.up * turnVelocity * rb.mass;

    //    //Apply Forces
    //    rb.AddForce(forwardForce);
    //    rb.AddForce(backwardForce);
    //    rb.AddForce(torque);

    //}


    //// Update is called once per frame
    //void Update()
    //{

    //}

}
