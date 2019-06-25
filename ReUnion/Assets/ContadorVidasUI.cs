using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorVidasUI : MonoBehaviour
{
    private Text TextoVidas;
    
    void Awake ()
    {
        TextoVidas = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        TextoVidas.text = "VIDAS: " + GameSetter.gs.GetVidas();
    }
}
