using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed;
    private bool isSpinning;

    // Start is called before the first frame update
    void Start()
    {
        Transform plane = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isSpinning){
            SpinObject();
        }
    }

    public void SpinObject(){
                    transform.Rotate(Time.deltaTime * speed, 0, 0, Space.Self); 
    }
    void OnMouseOver(){
        if(Input.GetMouseButtonDown(0)){
            if(isSpinning){
                isSpinning = false;
            }
            else{
                isSpinning = true;
            }
        }
    }
}
