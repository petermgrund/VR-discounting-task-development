using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTable : MonoBehaviour
{

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
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            x += 1;
        }
        transform.position = new Vector3(x, 0, 0);
    } 
}
