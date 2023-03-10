using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "CollectibleItemScripatableObject", menuName = "Item/ItemData", order = 1)]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    public int stackSize;

    private void Awake()
    {
        stackSize = 0;
    }


    public void AddToStack(int added)
    {
        Debug.Log("ajouter " + added);
        stackSize += added;
       
    }
    public void RemoveFromStack(int removed)
    {
        stackSize -= removed;
    }
}
