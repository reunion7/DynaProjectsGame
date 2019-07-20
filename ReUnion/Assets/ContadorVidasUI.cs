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
		if(GameSetter.gs.GetVidas() >= 0)
		{
			TextoVidas.text = "VIDAS: " + GameSetter.gs.GetVidas();
		}  
    }
}
