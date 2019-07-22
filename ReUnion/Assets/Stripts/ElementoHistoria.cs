using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementoHistoria : MonoBehaviour
{
    public bool playerEnRango;
    public Dialogo dialogo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerEnRango)
        {
            TriggerDialogo();
        }
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
