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
             RaycastHit hit;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             renderer.material.SetColor("_Color", Random.ColorHSV());

    }
    if(highlight.isGrown){
        Debug.Log("grown");
    }
    else if (!highlight.isGrown){
        Debug.Log("notgrown");
    }
    }
}