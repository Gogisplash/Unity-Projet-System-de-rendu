using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBarrel : Interactable
{
    // Start is called before the first frame update

    public static event Action<int> OnExplosion;
    public ParticleSystem[] explosion;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        explosion[0].Play();
        explosion[1].Play();
        explosion[2].Play();
        base.Interact();
        OnExplosion?.Invoke(15);
    }
}
