using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class Inventory : MonoBehaviour
{
    
    public List<ItemData> inventory = new List<ItemData>();
    //private Dictionary<ItemData, InventoryItem> itemDictionary = new Dictionary<ItemData, InventoryItem>();

    public static event Action<List<ItemData>> OnInventoryChange;
    ItemData coins;
    private void Start()
    {
        inventory.Clear();

        
    }
    public void AddToInventory(ItemData itemAdded)
    {
      
       foreach (ItemData item in inventory)
        {
            if(item.itemName == itemAdded.itemName)
            {
                item.AddToStack(itemAdded.stackSize);
                OnInventoryChange?.Invoke(inventory);
            }
        }
       if(!IsinInventory(itemAdded))
        {
            
            inventory.Add(itemAdded);
            OnInventoryChange?.Invoke(inventory);
        }
        

    }
    
    public void RemoveFromInventory(ItemData itemRemoved)
    {
        foreach(ItemData item in inventory)
        {
            if (IsinInventory(item))
            {
                item.RemoveFromStack(itemRemoved.stackSize);
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

    public bool IsinInventory(ItemData item )
    {
        bool inInventory = false;
        foreach(ItemData i in inventory)
        {
            if(i.itemName == item.itemName) 
            { 
                inInventory = true;
            }
        }
        return inInventory;
    }

    public ItemData GetCoins()
    {
        
        foreach (ItemData i in inventory)
        {
            if (i.itemName == "Gold Coins")
            {
                coins = i;
            }
        }
        return coins;
    }

}
