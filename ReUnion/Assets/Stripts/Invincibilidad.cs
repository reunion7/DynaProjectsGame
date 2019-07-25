using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibilidad : MonoBehaviour
{
    private Renderer rend;
    public Color colorFlash;

    void Start()
    {
        rend = GetComponent<Renderer>();
        colorFlash = rend.material.color;

    }

    void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.CompareTag("Enemy") && GameSetter.gs.GetVidas() >= 0)
        {
            StartCoroutine("GetInvencible");
        }

    }

    private IEnumerator GetInvencible()
    {
        Physics2D.IgnoreLayerCollision(8, 9, true);
        colorFlash.a = 0.5f;
        rend.material.color = colorFlash;
        yield return new WaitForSeconds(3f);
        Physics2D.IgnoreLayerCollision(8, 9, false);
        colorFlash.a = 1f;
        rend.material.color = colorFlash;

    }
}
