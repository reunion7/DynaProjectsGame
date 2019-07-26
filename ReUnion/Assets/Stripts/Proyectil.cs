using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidadDisparo;
    private Vector2 PosicionMouse, PosicionObjeto;
    private Vector3 posicionAnterior;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * velocidadDisparo;
        posicionAnterior = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (posicionAnterior != transform.position)
        {
            transform.right = transform.position - posicionAnterior;
            posicionAnterior = transform.position;
        }
    }

	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
	void Colision()
	{
		Destroy(gameObject);
	}
}
