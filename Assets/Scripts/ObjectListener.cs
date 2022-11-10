using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectListener : MonoBehaviour
{
    public Spin spin;
    private bool clicked;

    // Start is called before the first frame update
    void Start()
    {
        spin = GetComponent<Spin>();
        clicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(clicked){
            spin.SpinObject();
        }
        if(Input.GetMouseButtonDown(0)){
             RaycastHit hit;
       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

       if(Physics.Raycast(ray, out hit, 100.0f)){

        if(hit.transform){
            PrintName(hit.transform.gameObject);
            if(clicked){
                clicked = false;
            }
            else{
                clicked = true;
            }
        }
        }
       }
    }
     private void PrintName(GameObject go){
        print(go.name);
    }
}
