using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaPlataforma : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb2d;
    private BoxCollider2D collider;
    public float delay;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Invoke("Caida", delay);//llamará a esa función dentro de ese tiempo
        }
    }
    void Caida()
    {
        rb2d.isKinematic = false;
        collider.isTrigger = true;
    }
}
