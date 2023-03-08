using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopScript : MonoBehaviour
{

    public Slider healthSlider, speedSlider;

    public int maxHealth, maxSpeed;

    int currentHealth, currentSpeed;
    int cash;

    public Text cashText;

    // Start is called before the first frame update
    void Start()
    {
        SetDefs();
    }

    void SetDefs()
    {

        cash = 1000;
        cashText.text = cash + "$";

        currentHealth =  PlayerPrefs.GetInt("health",0);
        currentSpeed = PlayerPrefs.GetInt("speed", 0);

        healthSlider.maxValue = maxHealth;
        speedSlider.maxValue = maxSpeed;

        healthSlider.value = currentHealth;
        speedSlider.value = currentSpeed;
    }

    public void buyHealth(int price)
    {
        if (currentHealth < maxHealth)
        {
            if (cash > price)
            {
                cash -= price;
                cashText.text = cash + "$";
                currentHealth += 5;
                PlayerPrefs.SetInt("health", currentHealth);
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
            if (cash > price)
            {
                cash -= price;
                cashText.text = cash + "$";
                currentSpeed += 10;
                PlayerPrefs.SetInt("speed", currentSpeed);
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
        if(Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
