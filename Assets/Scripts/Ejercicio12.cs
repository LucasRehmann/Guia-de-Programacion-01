using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    public int dado1;
    public int dado2;
    public int dado3;

    int d1;
    int d2;
    int d3;

    int total;

    // Start is called before the first frame update
    void Start()
    {
        if (dado1 == 6)
        {
            d1++;
        }

        if (dado2 == 6)
        {
            d2++;
        }

        if (dado3 == 6)
        {
            d3++;
        }

        total = d1 + d2 + d3;

        switch (total)
        {
            case 0:
                Debug.Log("Insuficiente");
                break;

            case 1:
                Debug.Log("Regular");
                break;

            case 2:
                Debug.Log("Muy Bien");
                break;

            case 3:
                Debug.Log("Excelente");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
