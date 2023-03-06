using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputGetter : MonoBehaviour
{
    private float _horizontalAxis;
    private float _verticalAxis;
    public float PhorizontalAxis
    {
        get { return _horizontalAxis; }
        set { _horizontalAxis = value; }
    }
    public float PverticalAxis
    {
        get { return _verticalAxis; }
        set { _verticalAxis = value; }
    }
    public bool interact;
    public bool space;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalAxis = Input.GetAxis("Horizontal");
        _verticalAxis = Input.GetAxis("Vertical");
       
        interact = Input.GetKey(KeyCode.E);
        space = Input.GetKey(KeyCode.Space);

    }
}
