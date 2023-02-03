using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour
{

    public Vector2 speed = new Vector2(10, 10);
    private Vector2 movement = new Vector2(1, 1);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal"); float inputY = Input.GetAxis("Vertical");

        movement = new Vector2 (speed.x * inputX, speed.y * inputY);

        if (Input.GetKeyDown("space"))
            transform.Translate(Vector2.up * 140 * Time.deltaTime, Space.World);
        
    }
}
