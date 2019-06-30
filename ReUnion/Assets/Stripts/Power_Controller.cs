using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_Controller : MonoBehaviour
{
    private Vector3 MousePosicion, ObjetoPosicion;
    private float angulo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MousePosicion = Input.mousePosition;
        ObjetoPosicion = Camera.main.WorldToScreenPoint(transform.position);
        angulo = Mathf.Atan2((MousePosicion.y - ObjetoPosicion.y), (MousePosicion.x - ObjetoPosicion.x) )* Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(new Vector3(0, 0, angulo));
    }
}