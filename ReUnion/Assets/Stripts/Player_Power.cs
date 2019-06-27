using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Power : MonoBehaviour
{
    public GameObject proyectil;
    public float distancia;
    void Start()
    {
        distancia = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(proyectil, transform.position, transform.rotation);
        }
    }
    public void SetDistancia(float d)
    {
        this.distancia = d;
    }
}
