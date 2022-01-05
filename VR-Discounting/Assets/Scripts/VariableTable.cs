using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTable : MonoBehaviour
{

    // Define initial x, max and min
    public int x = 1;
    public int max = 100;
    public int min = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is Peter!");
    }

    // Update is called once per frame
    void Update()
    {
        // Check to see if 0 key is pressed
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            // Set max to the current x value
            max = x;
            // Set x to the previous x value minus half the distance from max to min
            x = x - ((max - min) / 2);
        }

        // Check to see is 1 key is pressed
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Set min to current x value
            min = x;
            // Set x to the pervious x value plus half the distance from max to min
            x = x + ((max-min)/2);
        }

        // Change the position on the x axis
        transform.position = new Vector3(x, 0, 0);

        // Check to see if min plus 1 equals max
        if (min + 1 == max)
        {
            // Print indifference point
            Debug.Log(min);
            // Stop Program
            Debug.Break();
            Application.Quit();
        }

    }
}

//working towards min=max
