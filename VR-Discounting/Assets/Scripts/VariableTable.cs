using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTable : MonoBehaviour
{

    public Vector3[] targets = new[] { new Vector3(1, 1, 1) };
    int x = 0;

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
            x = 0;
            Debug.Log("Working?");
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            x = 1;
            Debug.Log("Hi");
        }
        targets = new[] { new Vector3(x, x, x) };
        //Debug.Log(x);
    } 
}
