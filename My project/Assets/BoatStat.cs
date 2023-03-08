using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatStat : MonoBehaviour
{
    public int m_health;
    public int m_speed;

    BoatController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller= GetComponent<BoatController>();
        controller.speed = m_speed;
    }

    // Update is called once per frame
    void Update()
    {
        controller.speed = m_speed;
        Debug.Log("Vie :" + m_health);
        Debug.Log("Speed :" + m_speed);
    }

    public void SetHealth(int health)
    {
        m_health = health;
    }
    public void SetSpeed(int speed)
    {
        m_speed = speed;
    }
}
