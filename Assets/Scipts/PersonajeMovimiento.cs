using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeMovimiento : MonoBehaviour
{
    [SerializeField] private float velocidad;
   //para hacer referencia tambien sirve => pero a mi no me funciona
    public bool EnMovimiento
    {
        get
        {
            return _direccionMovimiento.magnitude > 0f;
        }
    }

    public Vector2 DireccionMovimiento
    {
        get
        {
            return _direccionMovimiento;
        }
    }
    

    private Rigidbody2D _rigibody2D;
    private Vector2 _direccionMovimiento;
    private Vector2 _input;
 


    private void Awake()
    {
        _rigibody2D = GetComponent<Rigidbody2D>();

    }
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        _input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //x
        if (_input.x > 0.1)
        {
            _direccionMovimiento.x = 1f;
        }
        else if (_input.x < 0)
        {
            _direccionMovimiento.x = -1f;
        }
        else
        {
            _direccionMovimiento.x = 0;
        }
        //y

        if (_input.y > 0.1)
        {
            _direccionMovimiento.y = 1f;
        }
        else if (_input.y < 0)
        {
            _direccionMovimiento.y = -1f;
        }
        else
        {
            _direccionMovimiento.y = 0;
        }

    }

    

   

}
