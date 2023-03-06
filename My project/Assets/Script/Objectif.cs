using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectif : Collectible
{
    // Start is called before the first frame update
    
    
    public ItemData objectifData;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
    }
    public override void Interact()
    {
        
        base.Interact();
        InventoryManager.Instance.inventory.AddToInventory(objectifData);
        
        SpawnObjectif.Instance.Spawn();
       
       
        
    }
    public void SetStackSize(int size)
    {
        objectifData.stackSize = size;
    }
   
}
