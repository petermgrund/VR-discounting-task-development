using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is Peter!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;

    }
}
