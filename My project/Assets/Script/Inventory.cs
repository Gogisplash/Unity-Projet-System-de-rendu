using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    
    public List<ItemData> inventory = new List<ItemData>();
    //private Dictionary<ItemData, InventoryItem> itemDictionary = new Dictionary<ItemData, InventoryItem>();

    public static event Action<List<ItemData>> OnInventoryChange;

    private void Start()
    {
        inventory.Clear();

        
    }
    public void AddToInventory(ItemData itemAdded)
    {
       foreach (ItemData item in inventory)
        {
            if (item == itemAdded)
            {
                item.AddToStack();
                OnInventoryChange?.Invoke(inventory);
            }
          
        }
       if(inventory.Contains(itemAdded) == false)
        {

            inventory.Add(itemAdded);
            itemAdded.AddToStack();

            OnInventoryChange?.Invoke(inventory);
        }
        

    }
    
    public void RemoveFromInventory(ItemData itemRemoved)
    {
        foreach(ItemData item in inventory)
        {
            if (inventory.Contains(item))
            {
                item.RemoveFromStack();
                if(item.stackSize == 0)
                {
                    inventory.Remove(item);
                }
                OnInventoryChange?.Invoke(inventory);

            }
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

}
