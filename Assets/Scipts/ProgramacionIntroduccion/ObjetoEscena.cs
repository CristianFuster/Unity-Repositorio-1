using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoEscena : MonoBehaviour
{
	public GameObject objetoEncontrado;
	public GameObject personajeEncontrado;
	public GameObject nombreEncontrado;

	// Start is called before the first frame update
	void Start()
    {
		GameObject objetoEncontrado = GameObject.FindObjectOfType<SpriteRenderer>().gameObject;
		GameObject personajeEncontrado = GameObject.FindWithTag("Personaje");
		GameObject nombreEncontrado = GameObject.Find("Square");

		Debug.Log(objetoEncontrado.name);
		Debug.Log(personajeEncontrado.name);
		Debug.Log(nombreEncontrado.name);



	}
}

   

