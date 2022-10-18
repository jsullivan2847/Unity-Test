using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        Transform plane = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Time.deltaTime * 20, 0, 0, Space.Self); 
    }
}
