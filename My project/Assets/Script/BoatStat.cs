using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BoatStat : MonoBehaviour
{
    public int m_health;
    public int m_speed;

    BoatController controller;

    public Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = 100;
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
        //Debug.Log("Vie :" + m_health);
        //Debug.Log("Speed :" + m_speed);
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

        if (Input.GetKey(KeyCode.Space))
        {
            m_health -= damage;
        }
    }

    public void Death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
