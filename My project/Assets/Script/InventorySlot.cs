using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI stackSize;

    public void ClearSlot()
    {
        icon.enabled= false;
        stackSize.enabled= false;
        itemName.enabled= false;
    }

    public void DrawSlot(ItemData item)
    {
        if(item == null)
        {
            ClearSlot();
            return;
        }

        icon.enabled= true; 
        stackSize.enabled= true;    
        itemName.enabled= true;

        icon.sprite = item.itemIcon;
        itemName.text = item.itemName;
        stackSize.text = item.stackSize.ToString();

        
    }
}
