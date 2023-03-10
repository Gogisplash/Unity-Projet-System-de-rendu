using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UpgradeHubShop : MonoBehaviour
{
    public Text cashText;
    public GameObject player;
    int coins = 0;

    private HouseSpawn house;


    // Start is called before the first frame update
    void Start()
    {
        cashText.text = coins + "$";
        house = house.GetComponent<HouseSpawn>();
    }

    public void buyHouse(int price)
    {
            if (coins > price)
            {
                InventoryManager.Instance.inventory.GetCoins().RemoveFromStack(price);

                Debug.Log("house buyed");
            }
            else
            {
                Debug.Log("house no buyed");
            }
    }

    public void buyBoat(int price)
    {
        if (coins > price)
        {
            InventoryManager.Instance.inventory.GetCoins().RemoveFromStack(price);

            Debug.Log("boat buyed");
        }
        else
        {
            Debug.Log("boat no buyed");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (InventoryManager.Instance.inventory.GetCoins() != null)
        {
            coins = InventoryManager.Instance.inventory.GetCoins().stackSize;
        }

        cashText.text = coins + "$";

    }
}
