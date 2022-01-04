using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTable : MonoBehaviour
{

    int x = 1;
    int max = 100;
    int min = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is Peter!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            //set max
            max = x;
            x = x - ((max - min) / 2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            //set min
            min = x;
            x = x + ((max-min)/2);
        }
        transform.position = new Vector3(x, 0, 0);
    } 
}

//working towards min=max