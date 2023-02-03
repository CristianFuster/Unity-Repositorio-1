using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaVariableDos : MonoBehaviour
{

    public int[] myArrayOfInts; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i); // Print numbers from 0 to 9 (check i < 10, never 10)
        }

        for (int i = 0; i < myArrayOfInts.Length; i++)
        {
            Debug.Log(myArrayOfInts[i]); // Print array's content, array[i] takes the content in that index (i) from the array
        }
    }
}
