using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{
    public int hora;
    int HORA_APERTURA = 10;
    int HORA_CIERRE = 18;
    bool esteAbierto;

    // Start is called before the first frame update
    void Start()
    {
        if(hora >= 0 && hora <= 24)
        {
            if(hora >= HORA_APERTURA && hora <= HORA_CIERRE)
            {
                esteAbierto = true;
            }

            else
            {
                esteAbierto = false;
            }

            switch (esteAbierto)
            {
                case true:
                Debug.Log("El estacionamiento se encuentra abierto");
                    break;

                case false:
                    Debug.Log("El estacionamiento se encuentra cerrado");
                    break;
            }
        }

        else
        {
            Debug.Log("Ha ingresado una hora incorrecta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
