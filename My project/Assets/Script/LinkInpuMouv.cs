using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkInpuMouv : MonoBehaviour
{
    // Start is called before the first frame update
    MouvCharacter move;
    InputGetter input;
  
  
    void Start()
    {
        input = GetComponent<InputGetter>();
        move = GetComponent<MouvCharacter>();
       
    }

    // Update is called once per frame
    void Update()
    {
        move.Mouv(input);
        
    }

    

}
