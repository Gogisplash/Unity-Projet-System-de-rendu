using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectif : Collectible
{
    // Start is called before the first frame update
    
    
    public ItemData FirstobjectifData;
    public ItemData secondObjectData;
 
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
     
        
        if(InventoryManager.Instance.inventory.IsinInventory(FirstobjectifData)) 
        {
            InventoryManager.Instance.inventory.AddToInventory(secondObjectData);
        }
        else
        {
            InventoryManager.Instance.inventory.AddToInventory(FirstobjectifData);

        }

        SpawnObjectif.Instance.Spawn();
       
       
        
    }
    public void SetStackSize(int size, bool isStart)
    {
       if(!isStart)
        {
            FirstobjectifData.stackSize = size;
        }
        else
        {
            secondObjectData.stackSize = size;
            
        }
        
    }

   
}
