using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioProyectil : MonoBehaviour
{
    int saludVida = 100;
    int proyectilUno = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        ProyectilPeque�o();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ProyectilPeque�o()
    {
        //Crea el da�o
        int da�oProyectil = saludVida-proyectilUno;
        Debug.Log("La salud vida es:" + da�oProyectil);

        //Reduce el da�o a la vida

        //da�oProyectil = da�oProyectil -4 es igual a;

        saludVida -= proyectilUno;

   
    }
}
