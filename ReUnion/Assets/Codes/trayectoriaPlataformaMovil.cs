using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trayectoriaPlataformaMovil : MonoBehaviour
{
    public Transform desde;
    public Transform hasta;

    private void OnDrawGizmosSelected()
    {
        if (desde!=null && hasta != null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(desde.position, hasta.position);
        }
    }
}

