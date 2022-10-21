using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_Color", Color.magenta);
    }

    // Update is called once per frame
    //just changing for the poush....
    void Update()
    {

    }
}
