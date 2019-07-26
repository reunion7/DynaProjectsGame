using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregarVida : MonoBehaviour
{

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			GameSetter.gs.SetVidas(1);
			Destroy(gameObject);
		}
	}

}
