using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstanteVariable : MonoBehaviour
{

    //La cantidad de salud inicial de nuestro personaje
     public int saludPersonaje = 100;
    //El deterioro de salud que recibe nuestro personaje
   public  int deterioroSalud = 10;

    public string nombrePersonaje = "Cristian";


    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Salud Inicial: " + saludPersonaje);
        
        Debug.Log("Daño que recibe: " + deterioroSalud);
        Debug.Log(saludPersonaje - deterioroSalud);
        Debug.Log("El nombre del personaje es: " + nombrePersonaje);

    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
