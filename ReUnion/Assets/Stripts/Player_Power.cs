using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Power : MonoBehaviour
{
    public GameObject proyectil;
    public float distancia;
	public float velocidad;
    void Start()
    {
        distancia = 20f;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.touchCount > 0)
		{

			if (Input.GetTouch(0).phase == TouchPhase.Began)
			{

				Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
				Vector2 dir = touchPos - (new Vector2(transform.position.x, transform.position.y));
				dir.Normalize();
				GameObject bullet = Instantiate(proyectil, transform.position, Quaternion.identity) as GameObject;
				bullet.GetComponent<Rigidbody2D>().velocity = dir * velocidad;
			}
		}
		//if (Input.GetMouseButtonUp(0))
		//{
		//    Instantiate(proyectil, transform.position, transform.rotation);
		//}
	}
    public void SetDistancia(float d)
    {
        this.distancia = d;
    }
}
