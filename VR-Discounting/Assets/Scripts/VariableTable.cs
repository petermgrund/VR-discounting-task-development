using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTable : MonoBehaviour
{

    public Vector3[] targets = new[] { new Vector3(1, 1, 1) };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is Peter!");
    }

    // Update is called once per frame
    void Update()
    {
        targets = new[] { new Vector3(2, 2, 2) };
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            print("Zero was pressed!");
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            print("One was pressed!");
        }
    }
}
