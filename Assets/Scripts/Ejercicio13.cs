using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    public int horas;
    int init = 16;
    int extra = 20;
    // Start is called before the first frame update
    void Start()
    {
        if (horas <= 40)
        {
            Debug.Log("El salario de la semana es $" + (horas * init));
        }

        else if (horas > 40)
        {
            Debug.Log("El salario de la semana es $" + (40 * init + ((horas - 40) * extra)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
