using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    public string YYYYMMDD;
    public string comprador;
    public string producto;

    public int cantidad;
    public int precio;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Fecha de compra: " + YYYYMMDD);
        Debug.Log("Nombre del Comprador: " + comprador);
        Debug.Log("Producto Solicitado: " + producto);
        Debug.Log("Cantidad Solicitada: " + cantidad);
        Debug.Log("Precio Unitario: $" + precio);
        Debug.Log("Total a pagar: $" + (precio * cantidad));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
