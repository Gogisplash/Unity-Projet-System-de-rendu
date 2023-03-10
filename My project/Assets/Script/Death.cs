using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject player;
    BoatStat boatStat;
    int currentHealth;

    void Start()
    {
        boatStat = player.GetComponentInChildren<BoatStat>();

        currentHealth = boatStat.m_health;
     
    }


    void Update()
    {

            if (currentHealth <= 0)
            {
                AudioManager.instance.sfxSource.Stop();
                AudioManager.instance.musicSource.Stop();
                AudioManager.instance.PlaySFX("Death");
                //Debug.Log("Deadggggggggg");
                boatStat.Death();
            }
            else
            {
                //Debug.Log("alive");
            }
        }

}
