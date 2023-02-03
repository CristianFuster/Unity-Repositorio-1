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
        ProyectilPequeño();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ProyectilPequeño()
    {
        //Crea el daño
        int dañoProyectil = saludVida-proyectilUno;
        Debug.Log("La salud vida es:" + dañoProyectil);

        //Reduce el daño a la vida

        //dañoProyectil = dañoProyectil -4 es igual a;

        saludVida -= proyectilUno;

   
    }
}
