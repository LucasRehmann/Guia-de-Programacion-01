using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio09 : MonoBehaviour
{
    public int cap1;
    public int cap2;
    public int cap3;

    public string persona1;
    public string persona2;
    public string persona3;
    // Start is called before the first frame update
    void Start()
    {
        int total = cap1 + cap2 + cap3;

        int por1 = (100 / total * cap1);
        int por2 = (100 / total * cap1);
        int por3 = (100 / total * cap1);

        Debug.Log(por1);
        Debug.Log("Nombre: " + persona1 + ", capital aportado: $" + cap1 + ", Porcentaje del capital: %" + por1 + ", Monto total aportado: $" + total);
        Debug.Log("Nombre: " + persona2 + ", capital aportado: $" + cap2 + ", Porcentaje del capital: %" + por2 + ", Monto total aportado: $" + total);
        Debug.Log("Nombre: " + persona3 + ", capital aportado: $" + cap3 + ", Porcentaje del capital: %" + por3 + ", Monto total aportado: $" + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
