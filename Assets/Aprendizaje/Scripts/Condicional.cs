using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Condicional : MonoBehaviour
{
    public int EdadUno = 5;
    public float EdadDos = 3.6f;
    

    //Prueba todos tipos de variables 

    public int miEntero = 5;
    public float miFloat = 3.5f;
    public bool miBoolean = true;
    public string miString = "Hola Mundo";
    public int[] miArray;

    private int _miEnteroprivado = 10;
    float _miEnteroFloat = -5.0f;

    //Prueba operador modulo %

    public int miSobrante = 5 % 2;

    // Start is called before the first frame update
    void Start()
    {

        if (EdadUno >= 3.6f)
        {
            Debug.Log("EdadUno es mayor que 3.6");
        }
        else
        {
            Debug.Log("EdadUno es menor que 3.6");
        }

        if (miSobrante == 0)
        {
            Debug.Log("El sobrante es par");
        }
        else
        {
            Debug.Log("El sobrante es impar");
        }
     


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
