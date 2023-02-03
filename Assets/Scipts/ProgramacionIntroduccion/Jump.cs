using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

   public bool isJumping = false; //Para comprobar si ya está saltando
    [Range(1, 500)] public float potenciaSalto; //Potencia de salto del jugador 
    Rigidbody2D rb2d;
   
    SpriteRenderer spRd;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spRd = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
       
    }

    // Update is called once per frame

   
    

   


    void FixedUpdate()
    {

        if (Input.GetButton("Jump") && !isJumping)
        {
            //Le aplico la fuerza de salto
            rb2d.AddForce(Vector2.up * potenciaSalto);
            //Digo que está saltando (para que no pueda volver a saltar)
            isJumping = true;
            
        }

        
    }

    void OnTriggerEnter2D(Collision2D other)
    {
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colisiona");
        //Si el jugador colisiona con un objeto con la etiqueta suelo
        if (collision.gameObject.CompareTag("Suelo"))

        {
            Debug.Log("suelo");
            //Digo que no está saltando (para que pueda volver a saltar)
            isJumping = false;
            //Le quito la fuerza de salto remanente que tuviera
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
        }

    }
}


    

