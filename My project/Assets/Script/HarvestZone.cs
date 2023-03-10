using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HarvestZone : MonoBehaviour
{
    [SerializeField]
    private Vector3 zoneSize;

    private SliderController harvestingSlider;

    public GameObject harvestingBar;

    bool Harvesting;

    float harvestingProgresse;

    int coinsInside;

    public GameObject chestPrefab;

    private Objectif chestData;

    private GameObject chestInstance;

    private GameObject Player;

    
    
    private void Awake()
    {
        harvestingProgresse = 0;
        harvestingBar = GameObject.Find("HarvestingBar");
        harvestingSlider = harvestingBar.GetComponent<SliderController>();
        chestData = chestPrefab.GetComponentInChildren<Objectif>();
        coinsInside = Random.Range(1, 100);
    }
    private void Start()
    {
        //Debug.Log(chestData);
        bool inInventory = InventoryManager.Instance.inventory.IsinInventory(chestData.FirstobjectifData);
        chestData.SetStackSize(coinsInside, inInventory);
        
        
        harvestingBar.SetActive(false);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, zoneSize);
    }
    private void OnTriggerEnter(Collider other)
    {
        harvestingBar.SetActive(true);
        Player = other.gameObject;
        Debug.Log(other.gameObject.name);
        if (other.CompareTag("Character"))
        {
            Harvesting= true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        harvestingBar.SetActive(false);
        if (other.CompareTag("Character"))
        {
            Harvesting = false;
        }
    }

    private void Update()
    {
        
        if(Harvesting)
        {
            harvestingProgresse += 0.3f;
            
        }
        harvestingSlider.SetSlider(harvestingProgresse);

        if (harvestingProgresse >= 100)
        {
            chestInstance = Instantiate(chestPrefab);
            chestInstance.transform.position = transform.position;
            
            gameObject.SetActive(false);
        }

    }

   
}
