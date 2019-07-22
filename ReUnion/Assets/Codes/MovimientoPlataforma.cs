using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlataforma : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float speed;//velocidad de la plataforma
    private Vector3 empiezo, final;
    void Start()
    {
        if (target != null)
        {
            target.parent = null;//Hace que por el tiempo de ejecución del juego, target no sea hija de la plataforma
            //Esto último porque se movia junto con la plataforma y no entendia por que
            empiezo = transform.position;
            final = target.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (target != null)
        {
            float speedportiempo = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, speedportiempo);//Mueve la plataforma hasta la posición del target
        }  
        if (transform.position == target.position)
        {
            target.position = (target.position == empiezo) ? final : empiezo;
        }//Para que se devuelva, así cambia la posición del target y por lo tanto la plataforma lo seguirá
    }
}
