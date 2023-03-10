using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BoatStat : MonoBehaviour
{
    public int m_health;
    public int m_speed;

    public int m_maxHealth = 100;

    BoatController controller;

    public Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = m_maxHealth;
        ExplosiveBarrel.OnExplosion += TakeDamage;
        controller= GetComponent<BoatController>();
        controller.speed = m_speed;
    }
    private void OnDisable()
    {
        ExplosiveBarrel.OnExplosion -= TakeDamage;
    }
    // Update is called once per frame
    void Update()
    {
        healthSlider.value = m_health;
        controller.speed = m_speed;

        if(m_health <= 0)
        {
            Death();
        }
        
    }
    

    public void SetHealth(int health)
    {
        m_health = health;
    }
    public void SetSpeed(int speed)
    {
        m_speed = speed;
    }

    public void TakeDamage(int damage)
    {
        m_health -= damage;

    }

    public void SetMaxHealth(int healthUpgrade)
    {
        m_health += 10;
        m_maxHealth = healthUpgrade;
        healthSlider.maxValue = m_maxHealth;  
    }
    public void Death()
    {
        AudioManager.instance.sfxSource.Stop();
        AudioManager.instance.musicSource.Stop();
        AudioManager.instance.PlaySFX("Died");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
