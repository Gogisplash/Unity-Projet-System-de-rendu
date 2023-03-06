using Engine.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : Singleton<InventoryManager>
{
    [SerializeField]
    public Inventory inventory;

    public int inventorySize;
    public GameObject slotPrefab;
    
    
    public List<InventorySlot> inventorySlots = new List<InventorySlot>(5);

    protected override void  OnEnable()
    {
        Inventory.OnInventoryChange += DrawnInventory;
    }
    protected override void OnDisable()
    {
        Inventory.OnInventoryChange -= DrawnInventory;
    }
    void ResetInventory()
    {
       
        foreach(Transform childTransform in transform)
        {
           
            Destroy(childTransform.gameObject);
        }
        inventorySlots = new List<InventorySlot>(5);
    }
    void DrawnInventory(List<ItemData> inventory)
    {
        
        ResetInventory();
        for (int i =0;i<inventorySlots.Capacity; i++) 
        {
            CreateInventorySlot();
        }
        for(int i = 0; i < inventory.Count; i++)
        {
            inventorySlots[i].DrawSlot(inventory[i]);
        }

    } 

    void CreateInventorySlot()
    {
        GameObject newSlot = Instantiate(slotPrefab);   
        newSlot.transform.SetParent(transform,false);

        InventorySlot newSlotComponent = newSlot.GetComponent<InventorySlot>();
        newSlotComponent.ClearSlot();

        inventorySlots.Add(newSlotComponent);
    }
}
