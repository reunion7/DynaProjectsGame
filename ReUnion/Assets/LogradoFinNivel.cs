using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogradoFinNivel : MonoBehaviour
{
	public string SiguienteNivel;
	public int NumeroSiguienteNivel;
	Fader fader;
	
    // Start is called before the first frame update
    void Start()
    {
		fader = FindObjectOfType<Fader>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter2D(Collider2D col)
	{
		PlayerPrefs.SetInt("nivelAlcanzado", NumeroSiguienteNivel);
		fader.FadeTo(SiguienteNivel);
		
	}

}
