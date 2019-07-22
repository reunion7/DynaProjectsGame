using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestorDialogo : MonoBehaviour
{
    public GameObject cajaDialogo;
    public Text textoDialogo;

    private Queue<string> frases;

    // Start is called before the first frame update
    void Start()
    {
        frases = new Queue<string>();
    }

    public void EmpezarDialogo (Dialogo dialogo)
    {
        cajaDialogo.SetActive(true);

        frases.Clear();

        foreach (string frase in dialogo.frases)
        {
            frases.Enqueue(frase);
        }

        DesplegarProximaFrase();

    }

    public void DesplegarProximaFrase()
    {
        if(frases.Count == 0)
        {
            cajaDialogo.SetActive(false);
            return;
        }
        string frase = frases.Dequeue();
        textoDialogo.text = frase;
    }

}
