using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopScript : MonoBehaviour
{

    public Slider healthSlider, speedSlider;

    public int maxHealth, maxSpeed;

    int currentHealth, currentSpeed;
    

    public Text cashText;

    public GameObject player;
    BoatStat boatStat;
    int coins = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        cashText.text = coins + "$";
        boatStat = player.GetComponentInChildren<BoatStat>();

        currentHealth = boatStat.m_health;
        currentSpeed = boatStat.m_speed;

        healthSlider.maxValue = maxHealth;
        speedSlider.maxValue = maxSpeed;

        healthSlider.value = currentHealth;
        speedSlider.value = currentSpeed;
    }

    public void buyHealth(int price)
    {
        if (currentHealth < maxHealth)
        {
            if (coins > price)
            {
                InventoryManager.Instance.inventory.GetCoins().RemoveFromStack(price);
                
                
                currentHealth += 5;
                boatStat.SetHealth(currentHealth);  
                healthSlider.value = currentHealth;
                Debug.Log("health up");
            }
            else
            {
                Debug.Log("health fulll");
            }
        }
        else 
        { 
                Debug.Log("out of cash");
        }
    }

    public void buySpeed(int price)
    {
        if (currentSpeed < maxSpeed)
        {
            if (coins > price)
            {
                InventoryManager.Instance.inventory.GetCoins().RemoveFromStack(price);

                currentSpeed += 10;
                boatStat.SetSpeed(currentSpeed);
                speedSlider.value = currentSpeed;
                Debug.Log("Speed up");
            }
            else
            {
                Debug.Log("Speed fulll");
            }
        }
        else
        {
            Debug.Log("out of cash");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(InventoryManager.Instance.inventory.GetCoins() != null)
        {
            coins = InventoryManager.Instance.inventory.GetCoins().stackSize;
        }
        
        cashText.text = coins +"$";
        
    }
}
