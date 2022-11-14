using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public bool isGrown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver(){
            transform.localScale = new Vector3(1.1f,1.1f,1.1f);
            isGrown = true;
    }
    void OnMouseExit(){
        transform.localScale = new Vector3(1,1,1);
        isGrown = false;
    }
}
