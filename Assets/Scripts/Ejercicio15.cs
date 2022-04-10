using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    public int numero;
    
    bool estaEnA = false;
    bool estaEnB = false;
    bool estaEnAmbos = false;
    bool noEstaEnNinguno = false;

    int undig;
    int impar;

    // Start is called before the first frame update
    void Start()
    {
        impar = numero % 2;

        if (numero < 10 && undig > -10)
        {
            estaEnA = true;
            Debug.Log("El bool estaEnA es true");
        }

        if (impar != 0)
        {
            estaEnB = true;
            Debug.Log("El bool estaEnB es true");
        }

        if (estaEnA == true && estaEnB == true)
        {
            estaEnAmbos = true;
            Debug.Log("El bool estaEnAmbos es true");
        }

        if (estaEnA == false && estaEnB == false)
        {
            noEstaEnNinguno = true;
            Debug.Log("El bool noEstaEnNinguno es true");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
