using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCuadrado : MonoBehaviour
{
    public int ladoUnoCuadrado = 4;
    public int ladoDosCuadrado = 4;



    // Start is called before the first frame update
    void Start()
    {
        
        comprobarArea();

    }

    void comprobarArea()
    {

        int areaCuadrado = ladoUnoCuadrado * ladoDosCuadrado;
        Debug.Log("El area del cuadrado es:" + areaCuadrado);


    }
    // Update is called once per frame
    void Update()
    {

    }
}

