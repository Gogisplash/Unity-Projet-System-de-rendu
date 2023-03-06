using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDetector : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        Interactable collectible = other.GetComponent<Interactable>();
        if(collectible != null) 
        { 
            collectible.Interact(); 
        }
        
    }
    
}
