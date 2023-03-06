using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class MouvCharacter : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rBody;
    Vector3 velocity;
    public float speed = 5.0f;
   
    void Start()
    {
       rBody= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     
        
    }
    public void Mouv(InputGetter input)
    {
        Vector3 move = transform.right * input.PhorizontalAxis + transform.forward * input.PverticalAxis;
        rBody.transform.Translate(move * speed * Time.deltaTime);
        
    }
    
}
