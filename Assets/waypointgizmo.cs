using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointgizmo : MonoBehaviour
{
    public float scale = 1f;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, scale);
    }
    public  void OnPostRender()
    {
        Debug.Log("pointer working ");
    }
}
