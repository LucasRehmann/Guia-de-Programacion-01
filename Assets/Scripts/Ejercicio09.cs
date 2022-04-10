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
        Debug.Log("Nombre: " + persona1 + ", capital aportado: $" + cap1 + ", Porcentaje del capital: %" + (100 * cap1 / (cap1 + cap2 + cap3)) + ", Monto total aportado: $" + (cap1 + cap2 + cap3));
        Debug.Log("Nombre: " + persona2 + ", capital aportado: $" + cap2 + ", Porcentaje del capital: %" + (100 * cap2 / (cap1 + cap2 + cap3)) + ", Monto total aportado: $" + (cap1 + cap2 + cap3));
        Debug.Log("Nombre: " + persona3 + ", capital aportado: $" + cap3 + ", Porcentaje del capital: %" + (100 * cap3 / (cap1 + cap2 + cap3)) + ", Monto total aportado: $" + (cap1 + cap2 + cap3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
