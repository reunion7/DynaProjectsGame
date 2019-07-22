using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementoHistoria : MonoBehaviour
{
    public bool playerEnRango;
    public Dialogo dialogo;
    private bool yaLeido;

    void Update()
    {
        if (!yaLeido && playerEnRango)
        {
            yaLeido = true;
            TriggerDialogo();
        }
    }
    void Start()
    {
        yaLeido = false;
    }
    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.CompareTag("Player"))
        {
            playerEnRango = true;
        }

    }
    private void OnTriggerExit2D(Collider2D colision)
    {
        if (colision.CompareTag("Player"))
        {
            playerEnRango = false;
        }

    }

    public void TriggerDialogo()
    {

        FindObjectOfType<GestorDialogo>().EmpezarDialogo(dialogo);

    }

}
