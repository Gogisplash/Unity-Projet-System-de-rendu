using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowZone : MonoBehaviour
{
    [SerializeField]
    public Vector3 zoneSize;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, zoneSize);
    }
}
