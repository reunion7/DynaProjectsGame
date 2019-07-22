using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_controllero : MonoBehaviour
{
    public float velocidad;//velocidad del mob
    public float radioDvision;
    private Rigidbody2D rb2d;
    private Animator animador;
    private SpriteRenderer spriteRenderer;


    GameObject player;//instancia del jugador
    Vector2 posicionInicial;//posición inicial donde volvera el mob
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        posicionInicial = transform.position;
        rb2d = GetComponent<Rigidbody2D>();
        animador = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 target = posicionInicial;//Siempre intentará volver a la posición
        float distancia = Vector2.Distance(player.transform.position, transform.position);//Obtiene la distancia entre la posición del player y el mob
        if (distancia < radioDvision)
        {
            target = player.transform.position;//Si la condición se cumple, se establece la posición que el mob deberá seguir;
        }
        float velocidadnueva = velocidad * Time.deltaTime; 
        transform.position = Vector2.MoveTowards(transform.position, target, velocidadnueva);//El mob seguirá la posición del jugador a la velocidad establecida;
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, radioDvision);
    }
}
