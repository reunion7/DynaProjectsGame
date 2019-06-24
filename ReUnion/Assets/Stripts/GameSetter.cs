using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetter : MonoBehaviour
{
    public static GameSetter gs;
    public int vidas = 4;

    void Awake ()
    {
        if(gs == null)
        {
            gs = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void Update()
    {
        
    }

    public void SetVidas(int vida)
    {
        vidas += vida;
    }

    public int GetVidas()
    {
        return vidas;
    }


}
