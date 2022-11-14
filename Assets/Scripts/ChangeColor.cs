using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Highlight highlight;
    // Start is called before the first frame update
    void Start()
    {
        highlight = GetComponent<Highlight>();
        Renderer renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    //just changing for the poush....
    void Update()
    {
          if(Input.GetKeyDown(KeyCode.Tab) && highlight.isGrown){
             Renderer renderer = GetComponent<Renderer>();
             renderer.material.SetColor("_Color", Random.ColorHSV());

    }
    }
}