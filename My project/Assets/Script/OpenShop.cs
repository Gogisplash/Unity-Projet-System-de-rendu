using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenShop : MonoBehaviour
{

    public Image uiShop; 


    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Character") && Input.GetKey(KeyCode.E)) 
        { 

            uiShop.gameObject.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Character"))
        {
            uiShop.gameObject.SetActive(false);
        }
        
    }
}
