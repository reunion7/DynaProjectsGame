using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour

    
{

    public static bool pausa = false;
    public GameObject menuPausa;


    public void setPausaTrue()
    {
        pausa = true;
    }

    public void setPausaFalse()
    {
        pausa = false;
    }

    public void resume()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1f;
        pausa = false;
        
    }

    public void pause()
    {
        menuPausa.SetActive(true);
        Time.timeScale = 0f;
        pausa = true;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pausa)
        {
            pause();
        }
        else
        {
            resume();
        }
    }




}
