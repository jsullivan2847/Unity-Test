using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Transform plane = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpinObject(){
        transform.Rotate(Time.deltaTime * speed, 0, 0, Space.Self); 
    }
}
