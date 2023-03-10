//using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyManager : MonoBehaviour
{
    private bool hasVisitedArea1;
    private bool hasVisitedArea2;
    private bool hasVisitedArea3;
    private bool hasVisitedArea4;

    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        hasVisitedArea1 = false;
        hasVisitedArea2 = false;
        hasVisitedArea3 = false;
        hasVisitedArea4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AreaVisited(string area)
    {
        Debug.Log(area);
        switch (area)
        {
            case "Area1":
                target = GameObject.FindGameObjectWithTag("SkyArea1");
                Destroy(target);
                break;
            case "Area2":
                target = GameObject.FindGameObjectWithTag("SkyArea2");
                Destroy(target);
                break;
            case "Area3":
                target = GameObject.FindGameObjectWithTag("SkyArea3");
                Destroy(target);
                break;
            case "Area4":
                target = GameObject.FindGameObjectWithTag("SkyArea4");
                Destroy(target);
                break;
            default:
                break;
        }
    }

    public bool getHasVisitedArea1()
    {
        return hasVisitedArea1;
    }
    public bool getHasVisitedArea2()
    {
        return hasVisitedArea2;
    }
    public bool getHasVisitedArea3()
    {
        return hasVisitedArea3;
    }
    public bool getHasVisitedArea4()
    {
        return hasVisitedArea4;
    }
}
